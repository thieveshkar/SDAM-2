using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CB013248_Windows_Forms.Classes
{
    class Participant : User//PARTICIPANT CLASS WILL BE THE CHILD CLASS OF USER, WHICH MEANS PARTICIPANT CLASS INHERITS FROM USER CLASS
    {

        //
        ///below is the method used to view events that the participant has already registered
        //

        public void ViewRegisteredEvents(string loggeddusername, DataGridView Databasetable)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    string query = "SELECT `Participant Username`, `Event Name`, `Venue`, `Date` FROM participant_enrolled_event WHERE `Participant Username`=@ParticipantUsername";//query to get all the events registered by the logged in user(participant)

                    using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn))
                    {
                        mySqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ParticipantUsername", loggeddusername);
                        DataTable dt = new DataTable();
                        mySqlDataAdapter.Fill(dt);

                        if (dt.Rows.Count > 0)//if the particpant is registered to an event it will show them in the table
                        {
                            Databasetable.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("You are not registered for any events.");
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
        ///below is the method used to register to an event
        ///{THIS METHOD IS THE REASON WHY THE PARTICIPANT CLASS AND EVENT CLASS HAS A ASSOCIATION RELATIONSHIP}
        //

        public static string RegisterEvent(int eventId)
        {
            Eventclass eventDetails = Eventclass.GetEventDetails(eventId);
            string username = Loggedinuser;

            if (eventDetails == null)//if event doesnt exist the return a error message
            {
                return "Event not found.";
            }

            if (eventDetails.Registeredcount >= eventDetails.Maximumparticipants)//if event full then display a message{a comparison between the maxinumparticipant and already registercount is being done here }
            {
                return "Seats are full for this event.";
            }
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection


                    string checkuserenrollment = "SELECT COUNT(*) FROM participant_enrolled_event " +
                             "WHERE `Participant Username` = @Username AND `Event Name` = @EventName";//query to check if the is alrady enrolled in the event

                    MySqlCommand cmd3 = new MySqlCommand(checkuserenrollment, conn);
                    cmd3.Parameters.AddWithValue("@Username", username);
                    cmd3.Parameters.AddWithValue("@EventName", eventDetails.Event_Name);

                    int enrollmentCount = Convert.ToInt32(cmd3.ExecuteScalar());

                    if (enrollmentCount > 0)//if particpant has enrolled then return a error message
                    {
                        return "You are already enrolled for this event.";
                    }


                    string insertQuery = "INSERT INTO participant_enrolled_event " +
                     "(Participant_Enrollment_Id, `Participant Username`, `Event Name`, Venue, `Date`) " +
                     "VALUES (NULL, @Username, @EventName, @Venue, @EventDate)";//query to register the participant to the event

                    MySqlCommand cmd4 = new MySqlCommand(insertQuery, conn);
                    cmd4.Parameters.AddWithValue("@Username", username);
                    cmd4.Parameters.AddWithValue("@EventName", eventDetails.Event_Name);
                    cmd4.Parameters.AddWithValue("@Venue", eventDetails.Event_Venue);
                    cmd4.Parameters.AddWithValue("@EventDate", eventDetails.Event_Date);

                    cmd4.ExecuteNonQuery();

                    string updateQuery = "UPDATE event_table SET `Registered User Counts` = `Registered User Counts` + 1 " +
                     "WHERE `Event ID` = @EventId";//query to upadate the register count in the event table after registering

                    MySqlCommand cmd5 = new MySqlCommand(updateQuery, conn);
                    cmd5.Parameters.AddWithValue("@EventId", eventId);

                    cmd5.ExecuteNonQuery();

                    return "You have successfully registered for the event.";
                }
                catch (Exception ex)
                {
                    return ex.Message;//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method used unregister from an event 
        //

        public static void UnregisterEvents(string Eventname)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection
                    string SelectionQuery = "SELECT COUNT(*) FROM `participant_enrolled_event` WHERE `Event Name` = @Eventname";//query to check if the event exist in the enrolled events table in the databse
                    MySqlCommand command = new MySqlCommand(SelectionQuery, conn);
                    command.Parameters.AddWithValue("@Eventname", Eventname);
                    int eventCount = Convert.ToInt32(command.ExecuteScalar());

                    if (eventCount == 0)//if it doesnt exist then show error message
                    {
                        MessageBox.Show("Event Doesnt exist");
                    }
                    else
                    {
                        string Unregistereventquery = "DELETE FROM `participant_enrolled_event` WHERE `Event Name` = @Eventname";//query to unregister from the event
                        MySqlCommand cmd = new MySqlCommand(Unregistereventquery, conn);
                        cmd.Parameters.AddWithValue("@Eventname", Eventname);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Unregistered from the event successfully");

                        string UpdateEventTableQuery = @"
                        UPDATE `event_table` 
                        SET `Registered User Counts` = `Registered User Counts` - 1 
                        WHERE `Event Name` = @Eventname";//query to update the registered count in the event table 

                        MySqlCommand updateCmd = new MySqlCommand(UpdateEventTableQuery, conn);
                        updateCmd.Parameters.AddWithValue("@Eventname", Eventname);
                        updateCmd.ExecuteNonQuery();
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
