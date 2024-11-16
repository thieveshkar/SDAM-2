using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB013248_Windows_Forms.Classes
{
    internal class Eventclass//ORGANIZER CLASS HAS A ASSOCIATION RELATIONSHIP  WITH THIS EVENTCLASS
    {
        //private attributes of the event class.
        private int event_id;
        private string event_name;
        private DateTime event_date;
        private string venue;
        private int maximumparticipants;
        private int registerdcount;
        private string organizerusername;
        private string status;


        // public properties to get and set the event attributes.
        public int Event_ID
        {
            get { return event_id; }
            set { event_id = value; }
        }
        public string Event_Name
        {
            get { return event_name; }
            set { event_name = value; }
        }
        public DateTime Event_Date
        {
            get { return event_date; }
            set { event_date = value; }
        }
        public string Event_Venue
        {
            get { return venue; }
            set { venue = value; }
        }
        public int Maximumparticipants
        {
            get { return maximumparticipants; }
            set { maximumparticipants = value; }
        }
        public string Organizerusername
        {
            get { return organizerusername; }
            set { organizerusername = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int Registeredcount
        {
            get { return registerdcount; }
            set { registerdcount = value; }
        }

        // constructor to initialize the event object with the specified attributes.
        public Eventclass(string eventName, DateTime eventDate, string venue, int maxParticipants, int registerdcount, string organizerUsername, string status)
        {
            this.Event_Name = eventName;
            this.Event_Date = eventDate;
            this.Event_Venue = venue;
            this.Maximumparticipants = maxParticipants;
            this.Registeredcount = registerdcount;
            this.Organizerusername = organizerUsername;
            this.Status = status;

        }

        //
        ///below is the method used to display all event contenet from the database in the datagridview
        //

        public static void displaycontentindatabase(DataGridView Databasetable)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                conn.Open();//line of code inorder to open the connection
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM event_table", conn);//query to retrieve all data from event table
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)//if the table contains rows , then it willl bind the data to the datagridview
                {
                    Databasetable.DataSource = dt;
                }
                else//if no then it will display a message
                {
                    MessageBox.Show("Table is empty or some error occured during fetching the data from Database");
                }
            }
        }

        //
        ///below is the method used to display only the approved events by the admin from the database in the datagridview
        //

        public static void displyaapprovedevents(DataGridView Databasetable)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();

            using (MySqlConnection conn = connection.GetConnection())
            {
                conn.Open();//line of code inorder to open the connection
                string query = "SELECT * FROM event_table WHERE `Status` = 'Approved'";//query to get only the approved events by filtereing out using ths status column

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                mySqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)//if events exist then display them in the datagridview
                {
                    Databasetable.DataSource = dt;
                }
                else//if not display message
                {
                    MessageBox.Show("No approved events found or some error occurred during fetching the data from the Database");
                }
            }
        }

        //
        ///below is the method used to get all the event details based on a specified ID
        //

        public static Eventclass GetEventDetails(int eventId)
        {
            //created a connection object using User_Connection class inorder to establish connection between the SQL database and the system
            User_Connection connection = new User_Connection();
            Eventclass eventDetails = null;

            using (MySqlConnection conn = connection.GetConnection())
            {
                try
                {
                    conn.Open();//line of code inorder to open the connection


                    string selectQuery = "SELECT `Event Name`, `Event Date`, `Venue`, `Maximum Participants`, `Registered User Counts`, `Event Created By`, `Status` " +
                                         "FROM event_table WHERE `Event ID` = @EventId";

                    MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
                    cmd.Parameters.AddWithValue("@EventId", eventId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())//if event is found it will create an eventclass object with the reterived data
                        {
                            eventDetails = new Eventclass(
                                reader["Event Name"].ToString(),
                                Convert.ToDateTime(reader["Event Date"]),
                                reader["Venue"].ToString(),
                                Convert.ToInt32(reader["Maximum Participants"]),
                                Convert.ToInt32(reader["Registered User Counts"]),
                                reader["Event Created By"].ToString(),
                                reader["Status"].ToString()
                            );
                        }
                        else//if no then display a error message
                        { 
                            MessageBox.Show("No records found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);//this line of code is used to show the error message if there were any error occured 
                }
            }
            return eventDetails;//return the event deatils
        }
    }
}
