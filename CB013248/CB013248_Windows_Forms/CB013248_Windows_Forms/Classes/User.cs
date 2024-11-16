using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CB013248_Windows_Forms.Classes
{
    public class User//THIS USER CLASS WILL BE THE PARENT CLASS OF ADMIN, ORGANIZER AND PARTICIPANT CLASSES
    {
        //    
        ///static field to store the loggedin user's username and type(to store admin, participant or organizer)
        //

        private static string loggedinuser;
        private static string usertype;

        //
        ///since the static field are being set ot private, below propertoies are being created in order to access
        //

        public static string Loggedinuser // property to access the loggedd in user's username
        {
            get { return loggedinuser; }
            set { loggedinuser = value; }
        }
        public static string Usertype //property to access the logged in user type(to store admin, participant or organizer)
        {
            get { return usertype; }
            set { usertype = value; }
        }

        //
        /// below is the method for logging in a user in to the event managementt system, it takes username, password and the form as the parameters
        ///  {REASON FOR TAKING FORM AS A PARAMETER: the reason to take the login form as a parameter is to hide the login form after the sucessfull login process}
        //

        public static void Login(string username, string password, Login_Screen f1)//common method for all three actors(admin, organizer and participant)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    string query = "SELECT `User Type` FROM users WHERE Username=@Username AND Password=@Password";//this quesry is being used to select the user type from the users table based on the username and password, entered by the end user from the database
                    using (var command = new MySqlCommand(query, conn))
                    {

                        command.Parameters.AddWithValue("@Username", username);//this line of code is being used to avoid sql injections, which means that, rather than hardcoding it in the query itself, it is safe to pass the values as parameters in the form variables to avoid sql injections
                        command.Parameters.AddWithValue("@Password", password);// this line of code is also same as the previous line code, meaning it is used to avoid sql injections

                        string userType = command.ExecuteScalar()?.ToString();//here the i am trying to get the user, by using excutescalar, which means it will return single value(usertype)

                        if (!string.IsNullOrEmpty(userType))//here i am trying to comeup with a with if statement to redirect to the specfic screen(admin dashboard, organizer dashboard and participant screen) based on the user type and hide the login form 
                        {
                            //set the static fields for loogedin user's username and type of the user
                            Loggedinuser = username;
                            Usertype = userType;

                            if (userType == "ADMIN")
                            {
                                MessageBox.Show("Logged in as Admin");
                                Admin_Dashboard showadmindashboard = new Admin_Dashboard();
                                showadmindashboard.Show();
                                f1.Hide();

                            }
                            else if (userType == "PARTICIPANT")
                            {
                                MessageBox.Show("Logged in as Participant");
                                Partcicpant_Form participantscreen = new Partcicpant_Form();
                                participantscreen.Show();
                                f1.Hide();
                            }
                            else if (userType == "ORGANIZER")
                            {
                                MessageBox.Show("Logged in as Organizer");
                                Organizer_Screen organizerScreem = new Organizer_Screen();
                                organizerScreem.Show();
                                f1.Hide();
                            }
                        }
                        else//here i am checking if the login fails, to check if thr user is there in removed user table in the datasbe, because the admin and organizer do have permission to remove particpant whereas admin has a privelliage to remove organizer from the system, which mean if the user was removed, they will be updated in th eremoved user table and reomved from the user table. so that they will be prompted if they were removed
                        {
                            string removedUserQuery = "SELECT Username FROM removed_users WHERE Username = @Username";
                            using (var removedCommand = new MySqlCommand(removedUserQuery, conn))
                            {
                                removedCommand.Parameters.AddWithValue("@Username", username);
                                var removedUserResult = removedCommand.ExecuteScalar();

                                if (removedUserResult != null)
                                {
                                    MessageBox.Show("You have been removed from the system");
                                }
                                else//if the the username and password is not vaild in both the tables then it means that in username or password has to be incorrect . so a messsge will shown
                                {
                                    MessageBox.Show("Incorrect username or password");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method used to create a new participant account, only particicpant accounts can be created under this method because when it comes to creating admin and organizer ac, it has to be decided by the organization, for security reasons.because a privilege is being given to end user to create a admin or organizer ac, they would be able to make changes in the system
        //

        public static void createaccount(string newuser_username, string new_password)//taking user entered username and password to create an participant ac
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = @Username";//query to check if the username already exists in the users table in order to prevent same username useage
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", newuser_username);
                        int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (userCount > 0)//if the username already exist, a message will be showned
                        {

                            MessageBox.Show("Username already exists. Please choose a different username");
                            return;
                        }
                    }
                    //if the username doesnt exist, a new participant ac will be created by inserting the details in to the users table in the database
                    string insertquery = "INSERT INTO users (Username, Password, `User Type`) VALUES (@Username, @Password, 'PARTICIPANT')";
                    using (MySqlCommand cm2 = new MySqlCommand(insertquery, conn))
                    {
                        cm2.Parameters.AddWithValue("@Username", newuser_username);
                        cm2.Parameters.AddWithValue("@Password", new_password);

                        cm2.ExecuteNonQuery();//line of code which is used to excute the query
                        MessageBox.Show("Participant account has been created successfully");//show a sucessfull message if the ac is created successfully
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//line of code which is used to display error, if any error occured during account creating process
                }
            }
        }

        //
        ///below is the method which is used to log out of the system and return to the login screen. here i am taking the form as the parameter inorder to close the form
        //

        public static void logout(Form currentForm)//common method for all three actors(admin, organizer and participant)
        {
            currentForm.Close();//close the currently opened form(admin, participant dashboard or participant screen)
            Login_Screen loginscreen = new Login_Screen();
            loginscreen.Show();///show login screen
        }

        //
        ///below is the method which is used to view the registered events by participants for admin and orgainzer
        ///this method is method for only admin and organizer but not particpant, this will be inheritated to their classes(child class)
        //

        public void ViewRegisteredEvents(string loggeddusername, DataGridView Databasetable)
        {
            //code implementation will be done in the child classes, according to the privileges
        }

        //
        ///below is the method which is used to display the participants in a datagridview
        //

        public void ShowParticipants(DataGridView Databasetable)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    MySqlDataAdapter mysqldataadapters = new MySqlDataAdapter("SELECT `ID`, `Username`, `User Type` FROM `users` WHERE `User Type` = 'PARTICIPANT'", conn);//query only to select the participant user type from the users table and display in a datagridview
                    DataTable dataTable = new DataTable();
                    mysqldataadapters.Fill(dataTable);//line of code which will fill the dtaatable with the query results


                    if (dataTable.Rows.Count > 0)//line of code which is used to checck if there are any participants 
                    {

                        Databasetable.DataSource = dataTable;//line code to bind the data to the dtagridview if found
                    }
                    else
                    {
                        MessageBox.Show("No participants found.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method which is used to remove a particpant and update in realted tables
        //

        public void Removeparticipants(string removedperson, string participantusername)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection
                    string query = "DELETE FROM users WHERE Username = @Username AND `User Type` = 'PARTICIPANT'";//the query which is used to delete a particpnat from the users table

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Username", participantusername);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Participant removed successfully");

                            string insertquery = "INSERT INTO removed_users (Username, User_type, Removed_by) VALUES (@Username, 'PARTICIPANT', @RemovedBy)";//query which is useed to inrsert the removed participant  into the removed_users table in database
                            using (MySqlCommand cm2 = new MySqlCommand(insertquery, conn))
                            {
                                cm2.Parameters.AddWithValue("@Username", participantusername);
                                cm2.Parameters.AddWithValue("@RemovedBy", removedperson);
                                cm2.ExecuteNonQuery();//excute the delete command
                            }

                            // Check if the participant is enrolled in any event
                            string checkEnrollmentQuery = "SELECT `Event Name` FROM participant_enrolled_event WHERE `Participant Username` = @Username";
                            using (MySqlCommand cm3 = new MySqlCommand(checkEnrollmentQuery, conn))
                            {
                                cm3.Parameters.AddWithValue("@Username", participantusername);
                                var eventName = cm3.ExecuteScalar()?.ToString();//command to get the event name

                                if (eventName != null)//if the participant has enrolled to any event then retrieve the event id and update in the event's enrolled user count
                                {
                                    // retrieve the event ID using the event name
                                    string getEventIdQuery = "SELECT `Event ID` FROM event_table WHERE `Event Name` = @EventName";
                                    using (MySqlCommand cm4 = new MySqlCommand(getEventIdQuery, conn))
                                    {
                                        cm4.Parameters.AddWithValue("@EventName", eventName);
                                        var eventId = cm4.ExecuteScalar();

                                        if (eventId != null)
                                        {
                                            // Reduce Registered User Counts by 1 in event_table
                                            string updateEventQuery = "UPDATE event_table SET `Registered User Counts` = `Registered User Counts` - 1 WHERE `Event ID` = @EventId";
                                            using (MySqlCommand cm5 = new MySqlCommand(updateEventQuery, conn))
                                            {
                                                cm5.Parameters.AddWithValue("@EventId", eventId);
                                                cm5.ExecuteNonQuery();
                                            }
                                            //delete particpant details from enrolment deatils
                                            string deleteEnrolledEventDetailQuery = "DELETE FROM participant_enrolled_event WHERE `Participant Username` = @Username";
                                            using (MySqlCommand cm6 = new MySqlCommand(deleteEnrolledEventDetailQuery, conn))
                                            {
                                                cm6.Parameters.AddWithValue("@Username", participantusername);
                                                cm6.ExecuteNonQuery();
                                            }

                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No participant found with that username");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }
    }
}