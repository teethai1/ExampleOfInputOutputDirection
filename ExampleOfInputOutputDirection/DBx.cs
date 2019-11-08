using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ExampleOfInputOutputDirection
{
    class DBx
    {

        private string c_ConnectionString;

        public string ConnectionString
        {
            get { return c_ConnectionString; }
            set
            {
                c_ConnectionString = value;
            }
        }


        public SimpleUser NewUser(string firstName, string lastName, short age, string status)
        {

            SimpleUser newUser = null;

            string strSql = "INSERT INTO EXP.SimpleUser (FirstName, LastName, Age, Status, LastUpdate) " + 
                "VALUES (@FirstName, @LastName, @Age, @Status, GETDATE()) " +
                "SELECT @ID = ID, @LastUpdate = LastUpdate FROM EXP.SimpleUser WHERE ID = @@IDENTITY";

            //****without using Stored procedure: incase of we need multiple value
            using (SqlConnection con = new SqlConnection(c_ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = strSql;

                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = firstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = lastName;
                cmd.Parameters.Add("@Age", SqlDbType.SmallInt).Value = age;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = status;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@LastUpdate", SqlDbType.DateTime).Direction = ParameterDirection.Output;

                con.Open();

                int affectedRow = cmd.ExecuteNonQuery();
                if (affectedRow == 1)
                {
                    newUser = new SimpleUser()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Status = status,
                        ID = (int)cmd.Parameters["@ID"].Value,
                        LastUpdate = (DateTime)cmd.Parameters["@LastUpdate"].Value
                   };
                }

            }

            return newUser;


        }

        public void UpdateUser(SimpleUser user)
        {
            throw new Exception("Hello error");

            string strSql = "UPDATE EXP.SimpleUser SET FirstName = @FirstName, LastName = @LastName, " +
                "Age = @Age, Status = Status, LastUpdate = GETDATE() WHERE ID = @ID " +
                "SELECT @LastUpdate = LastUpdate FROM EXP.SimpleUser WHERE ID = @ID";

            //****without using Stored procedure: incase of we need multiple value
            using (SqlConnection con = new SqlConnection(c_ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = strSql;

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = user.ID;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = user.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = user.LastName;
                cmd.Parameters.Add("@Age", SqlDbType.SmallInt).Value = user.Age;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = user.Status;

                cmd.Parameters.Add("@LastUpdate", SqlDbType.DateTime).Direction = ParameterDirection.Output;

                con.Open();

                int affectedRow = cmd.ExecuteNonQuery();
                if (affectedRow == 1)
                {
                    user.LastUpdate = (DateTime)cmd.Parameters["@LastUpdate"].Value;
                }

            }
        }
    }
}
