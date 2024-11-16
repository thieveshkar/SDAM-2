using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CB013248_Windows_Forms.Classes
{
    internal class Admin : User//ADMIN CLASS WILL BE THE CHILD CLASS OF USER, WHICH MEANS ADDMINN CLASS INHERITS FROM USER CLASS 
    {
        //
        ///below is the method used to open manage event screen and close the admin dashboard screen
        //

        public void open_manage_event()
        {
            Admin_Dashboard closeadmindashboard = new Admin_Dashboard();//creating a object out of the admindashboard to close it
            Manage_Events manageeventscreen = new Manage_Events();//creating a object out of the manage event screen to open it
            manageeventscreen.Show();//show the manaange event screen
            closeadmindashboard.Close();//close the admin dashboard
        }

        //
        ///below is the method used to disapprove an event based on the id entered by the end user and update the event status in then database
        //

        public static string Disapprove_event(int ID)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection newconnection = new User_Connection();
            using (MySqlConnection conn = newconnection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection


                    //lines of codes to check if the event ID exist in the event_table
                    string CheckID = "SELECT COUNT(*) FROM `event_table` WHERE `Event ID` = @Id";
                    MySqlCommand checkidcmd = new MySqlCommand(CheckID, conn);
                    checkidcmd.Parameters.AddWithValue("@Id", ID);
                    int IDExist = Convert.ToInt32(checkidcmd.ExecuteScalar());

                    if (IDExist == 0)//if event ID doesnt exist, show a message 
                    {
                        MessageBox.Show("Invaild ID");
                        return "";
                    }

                    //lines of codess to check the current status of the event
                    string CheckStatus = "SELECT Status FROM `event_table` WHERE `Event ID` = @Id";
                    MySqlCommand checkstatuscmd = new MySqlCommand(CheckStatus, conn);
                    checkstatuscmd.Parameters.AddWithValue("@Id", ID);
                    string Currentstatus = checkstatuscmd.ExecuteScalar()?.ToString();

                    if (Currentstatus == "Disapproved")//if the event already dissapproved then a message will be shown
                    {
                        MessageBox.Show("Event has already been marked as Disapproved.");
                        return "";
                    }

                    string AdminUpdate = "Disapproved";
                    //if is is not already disapproved, then the below lines of codes will be used to update the status to disapproved
                    string QueryUpdate = "UPDATE `event_table` SET Status = @Status WHERE `Event ID`=@Id ";
                    MySqlCommand updateCmd = new MySqlCommand(QueryUpdate, conn);
                    updateCmd.Parameters.AddWithValue("@Status", AdminUpdate);
                    updateCmd.Parameters.AddWithValue("@Id", ID);

                    updateCmd.ExecuteNonQuery();//line of code useed excute the query

                    MessageBox.Show("Event status updated successfully.");
                    return "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                    return "";
                }
            }
        }

        //
        ///below is the method used to approve an event based on the id entered by the end user and update the event status in then database
        //

        public static string Approve_event(int ID)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection newconnection = new User_Connection();
            using (MySqlConnection conn = newconnection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    //lines of codes to check if the event ID exist in the event_table
                    string CheckID = "SELECT COUNT(*) FROM `event_table` WHERE `Event ID` = @Id";
                    MySqlCommand checkidcmd = new MySqlCommand(CheckID, conn);
                    checkidcmd.Parameters.AddWithValue("@Id", ID);
                    int IDExist = Convert.ToInt32(checkidcmd.ExecuteScalar());

                    if (IDExist == 0)//if event ID doesnt exist, show a message 
                    {
                        MessageBox.Show("Invaild ID");
                        return "";
                    }

                    //lines of codess to check the current status of the event
                    string CheckStatus = "SELECT Status FROM `event_table` WHERE `Event ID` = @Id";
                    MySqlCommand checkstatuscmd = new MySqlCommand(CheckStatus, conn);
                    checkstatuscmd.Parameters.AddWithValue("@Id", ID);
                    string Currentstatus = checkstatuscmd.ExecuteScalar()?.ToString();

                    if (Currentstatus == "Approved")
                    {
                        MessageBox.Show("Event has already been been approved");//if the event already approved then a message will be shown
                        return "";
                    }

                    string AdminUpdate = "Approved";
                    //if is is not already approved, then the below lines of codes will be used to update the status to approved
                    string QueryUpdate = "UPDATE `event_table` SET Status = @Status WHERE `Event ID`=@Id ";
                    MySqlCommand updateCmd = new MySqlCommand(QueryUpdate, conn);
                    updateCmd.Parameters.AddWithValue("@Status", AdminUpdate);
                    updateCmd.Parameters.AddWithValue("@Id", ID);

                    updateCmd.ExecuteNonQuery();//line of code useed excute the query

                    MessageBox.Show("Event status updated successfully.");
                    return "";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                    return "";
                }
            }
        }

        //
        ///below is the method used to display all the organizers in a database
        //

        public void Showorganizer(DataGridView Databasetable)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection


                    MySqlDataAdapter mysqldataadapters = new MySqlDataAdapter("SELECT `ID`, `Username`, `User Type` FROM `users` WHERE `User Type` = 'ORGANIZER'", conn);//query to get all the users with usertype "ORGANIZER" from the users table from users table
                    DataTable dataTable = new DataTable();
                    mysqldataadapters.Fill(dataTable);//fill the results with the datatable 


                    if (dataTable.Rows.Count > 0)//if data is found then set the datagridview's data source to the fetched data, which has been passsed as a parameter inn the method
                    {

                        Databasetable.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No Organizer found.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method used to remove an organizer from the users table and insert the organizer's deatils to the removed user tabel in the database and delete all relevant evenst that were created by that organizer
        //

        public void Removeorganizer(string removedperson, string participantusername)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection
                    string query = "DELETE FROM users WHERE Username = @Username AND `User Type` = 'ORGANIZER'";//query to delete organizer based on the username entered by the admin


                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Username", participantusername);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)//if the organizer was found, remove from the users table and log the informantion to the removed users table and then remove the events 
                        {
                            MessageBox.Show("Organizer removed sucessfully");

                            string insertquery = "INSERT INTO removed_users (Username, User_type, Removed_by) VALUES (@Username, 'Organizer', @RemovedBy)";

                            using (MySqlCommand cm2 = new MySqlCommand(insertquery, conn))
                            {
                                cm2.Parameters.AddWithValue("@Username", participantusername);
                                cm2.Parameters.AddWithValue("@RemovedBy", removedperson);

                                cm2.ExecuteNonQuery();//the line of code to excute the insert command 
                            }

                            string deleteenrolledeventdetailquer = "DELETE FROM event_table WHERE `Event Created By` = @Username";
                            using (MySqlCommand cm3 = new MySqlCommand(deleteenrolledeventdetailquer, conn))
                            {
                                cm3.Parameters.AddWithValue("@Username", participantusername);
                                cm3.ExecuteNonQuery();//the line of code to excute the delete command for the events
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Organizer found with that username");
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
        ///below is the method used to display the booking for a given organizer in the datagridview
        ///{THIS METHOD IS THE REASON WHY THE ADMIN CLASS AND BOOKING CLASS HAS A COMPOSITION RELATIONSHIP}
        //

        public void ViewBooking(string loggeddusername, DataGridView Databasetable)
        {
            Booking booking = new Booking();// creating an object out of the booking class
            booking.ViewRegisteredEvents(loggeddusername, Databasetable); //calling the method to view the registered events
        }
    }
}

