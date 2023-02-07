using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace GettingDataFromDatabase
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                       Initial Catalog=ExampleDatabase;
                                       User ID=DESKTOP-UP22UV6\mpasc;
                                       Password=;
                                       Trusted_Connection=Yes;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Debug.WriteLine("Conncted to Server!");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM dbo.People";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    Debug.WriteLine(reader.GetString(1) + "-" + reader.GetString(2));
                }
            }

            connection.Close();

        }
           

        

       
    }

 
}
