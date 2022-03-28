using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDataBase
{
    internal class constructor
    {
        // Getter and Setter properties for the project

        public string VehicleRegNo { get; set; }
        public string Make { get; set; }
        public string EngineSize { get; set; }
        public DateTime DateRegistered { get; set; }
        public decimal RentalPerDay { get; set; }
        public bool Available { get; set; }

        // creating a connection variable
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);

        public DataTable Select()
        {
            // creating an object of our database
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tblCar";

                // create cmd using conn and sql
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Create sql adapter using cmd
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                string query = cmd.CommandText;

                foreach (SqlParameter p in cmd.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }

                //open our connection
                conn.Open();

               // Fill it with the database object
                sda.Fill(dt);
            }

            catch (Exception ex) //can be error, because we need to add necessary library
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close(); //this method for Select
            }

            return dt;
        }

    }
}
