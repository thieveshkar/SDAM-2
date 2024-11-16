using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB013248_Windows_Forms.Classes
{
    class Booking//ADMIN AND ORGANIZER CLASS HAS A COMPOSITION RELATIONSHIP WITH THIS CLASS 
    {
        //
        ///below is the method used to view the registered events 
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
                    MySqlDataAdapter mysqldataadapeters = new MySqlDataAdapter("SELECT * FROM `participant_enrolled_event`", conn);//query to get the complete table 
                    DataTable dataTable = new DataTable();
                    mysqldataadapeters.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Databasetable.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Table is empty.");
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
