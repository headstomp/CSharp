using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            List<Person> people = new List<Person>();
            string cs = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("dbo.People_GetByLastName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@LastName";
                parameterId.Value = lastName;
                cmd.Parameters.Add(parameterId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    people.Add(
                        new Person() {
                            id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            EmailAddress = reader["EmailAddress"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString()
                        }
                    );
                }
            }
            return people;
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
           
            string cs = ConfigurationManager.ConnectionStrings["DemoDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("dbo.People_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterFirstName = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = firstName
                };
                cmd.Parameters.Add(parameterFirstName);

                SqlParameter parameterLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = lastName
                };
                cmd.Parameters.Add(parameterLastName);

                SqlParameter ParameterEmailAddress = new SqlParameter
                {
                    ParameterName = "@EmailAddress",
                    Value = emailAddress
                };
                cmd.Parameters.Add(ParameterEmailAddress);

                SqlParameter ParameterPhoneNumber = new SqlParameter
                {
                    ParameterName = "@PhoneNumber",
                    Value = phoneNumber
                };
                cmd.Parameters.Add(ParameterPhoneNumber);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
