using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Data;

namespace CB013248_Windows_Forms.Classes
{
    internal class Organizer : User//ORGANIZER CLASS WILL BE THE CHILD CLASS OF USER, WHICH MEANS ORGANIZER CLASS INHERITS FROM USER CLASS 
    {
        //
        ///below is the method used to create an event or update a event that already exist
        //
        public static void CreateEvent(Eventclass events)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection

                    string query0 = @"
                            SELECT COUNT(*) 
                            FROM event_table 
                            WHERE `Event Name` = @EventName
                            AND DATE(`Event Date`) = DATE(@EventDate)";//query to check if an event with the same name and date already exist

                    MySqlCommand cmd = new MySqlCommand(query0, conn);//created a excute command to check if the event exist already
                    cmd.Parameters.AddWithValue("@EventName", events.Event_Name);
                    cmd.Parameters.AddWithValue("@EventDate", events.Event_Date);

                    int rowcount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (rowcount > 0)
                    {

                        string updaterow = @"
                            UPDATE event_table 
                            SET 
                                `Venue` = @Venue, 
                                `Maximum Participants` = @MaxParticipants, 
                                `Event Created By` = @OrganizerUsername, 
                                `Status` = @Status
                            WHERE `Event Name` = @EventName 
                            AND DATE(`Event Date`) = DATE(@EventDate)";//query to update the event if the event already exists

                        MySqlCommand cmd3 = new MySqlCommand(updaterow, conn);
                        cmd3.Parameters.AddWithValue("@EventName", events.Event_Name);
                        cmd3.Parameters.AddWithValue("@EventDate", events.Event_Date);
                        cmd3.Parameters.AddWithValue("@Venue", events.Event_Venue);
                        cmd3.Parameters.AddWithValue("@MaxParticipants", events.Maximumparticipants);
                        cmd3.Parameters.AddWithValue("@OrganizerUsername", events.Organizerusername);
                        cmd3.Parameters.AddWithValue("@Status", events.Status);

                        cmd3.ExecuteNonQuery();//line of code to excute the update query
                        MessageBox.Show("This event already exists on the same date, and it has been updated with new information.");
                    }
                    else
                    {

                        string query1 = @"
                        INSERT INTO event_table (`Event Name`, `Event Date`, `Venue`, `Maximum Participants`, `Event Created By`, `Status`)
                        VALUES (@EventName, @EventDate, @Venue, @MaxParticipants, @OrganizerUsername, @Status)";//the query to insert the information to the event table if the event doesnt exist

                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        cmd1.Parameters.AddWithValue("@EventName", events.Event_Name);
                        cmd1.Parameters.AddWithValue("@EventDate", events.Event_Date);
                        cmd1.Parameters.AddWithValue("@Venue", events.Event_Venue);
                        cmd1.Parameters.AddWithValue("@MaxParticipants", events.Maximumparticipants);
                        cmd1.Parameters.AddWithValue("@OrganizerUsername", events.Organizerusername);
                        cmd1.Parameters.AddWithValue("@Status", events.Status);

                        cmd1.ExecuteNonQuery();//line of code to excute the insert query
                        MessageBox.Show("Event Created");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method used to remove an event based on the entered event id
        //

        public static void removeanevent(int ID)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection


                    string CheckID = "SELECT COUNT(*) FROM `event_table` WHERE `Event ID` = @Id";//query to check if the event with the entered ID exist
                    MySqlCommand checkidcmd = new MySqlCommand(CheckID, conn);
                    checkidcmd.Parameters.AddWithValue("@Id", ID);
                    int IDExist = Convert.ToInt32(checkidcmd.ExecuteScalar());

                    if (IDExist == 0)
                    {
                        MessageBox.Show("Invaid Id");//if no, display message
                    }
                    else
                    {
                        string Deleteeventquery = "DELETE FROM `event_table` WHERE `Event ID` = @Id";//query to check if the event exist, delete the event
                        MySqlCommand cmd = new MySqlCommand(Deleteeventquery, conn);
                        cmd.Parameters.AddWithValue("@Id", ID);
                        cmd.ExecuteNonQuery();//excute the deletee query

                        MessageBox.Show("Event Removed sucessfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
        }

        //
        ///below is the method used to view the booked events for an organizer
        ///{THIS METHOD IS THE REASON WHY THE ORGANIZER CLASS AND BOOKING CLASS HAS A COMPOSITION RELATIONSHIP}
        //

        public void ViewBooking(string loggeddusername, DataGridView Databasetable)
        {
            Booking booking = new Booking();//creating a booking object outta booking class
            booking.ViewRegisteredEvents(loggeddusername, Databasetable);//calling the method to display registered events in the datagridview which has been passed as a parammeter in the method
        }
    }
}
