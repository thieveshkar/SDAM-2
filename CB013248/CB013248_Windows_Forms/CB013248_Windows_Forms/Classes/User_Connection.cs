using MySql.Data.MySqlClient;

namespace CB013248_Windows_Forms.Classes
{

    // this User_Connection class manages the MySQL database connection for the application.
    // this class is essential for all database-related operations in other classes{ALL OTHER CLASSES HAVE A DEPENDENCY RELATIONSHIP WITH THIS CLASS}
    internal class User_Connection
    {
        private static string connectionString = "server=localhost;database=eventmanagementdb;user=root;password=;";//connection string for establishing a connection with the sql database

        //below is the method tp create and return sqlconnection object, using the connection string
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);//return a sqlconnection object
        }
    }
}