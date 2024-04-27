using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PersonData
    {
        private string connectionString = "Data Source=LAB1504-10\\SQLEXPRESS;Initial Catalog=facturadb;User ID=myriamdb;Password=123456"; // Cambia esto por tu cadena de conexión

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("ListCustomers", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.PersonID = Convert.ToInt32(reader["customer_id"]);
                            person.FirstName = reader["name"].ToString();
                            person.Address = reader["address"].ToString();

                            person.Phone = reader["phone"].ToString();
                            person.Active = Convert.ToBoolean(reader["active"]);

                          
                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }



        public void Insert()
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {
        }
    }
    
}
