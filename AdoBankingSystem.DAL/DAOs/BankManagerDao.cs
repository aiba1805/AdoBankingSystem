using AdoBankingSystem.DAL.Interfaces;
using AdoBankingSystem.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoBankingSystem.DAL.DAOs
{
    public class BankManagerDao : IDAO<BankManagerDto>
    {
        private SqlConnection sqlConnection;



        public string Create(BankManagerDto t)
        {
            int result;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();



                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string sqlCode = "INSERT INTO [dbo].[BankManagers]" +

                    "([Id],[Email],[FirstName],[LastName],[PasswordHash],[CreatedTime],[ApplicationClientType],[EntityStatus])" +

                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})";

                    string realInsertQuery = String.Format(sqlCode,

                        t.Id, t.Email, t.FirstName, t.LastName,

                        t.PasswordHash, t.CreatedTime.ToString()

                        , (int)t.ApplicationClientType, (int)t.EntityStatus);



                    sqlCommand.CommandText = realInsertQuery;

                    sqlCommand.CommandType = CommandType.Text;



                    result = sqlCommand.ExecuteNonQuery();

                }

                sqlConnection.Close();

            }

            if (result != 0)

            {

                return t.Id;

            }

            else return string.Empty;

        }



        public void Remove(string id)

        {

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string realInsertQuery = String.Format(@"DELETE FROM [dbo].[BankManagers] WHERE Id = {0}", id.ToString());

                    sqlCommand.CommandText = realInsertQuery;

                    sqlCommand.CommandType = CommandType.Text;



                    int result = sqlCommand.ExecuteNonQuery();

                    Console.WriteLine(result);

                }

                sqlConnection.Close();

            }

        }



        public BankManagerDto Read(string id)
        {

            BankManagerDto managerDto = null;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                string sqlCode = String.Format(@"SELECT * FROM [dbo].[BankManagers] WHERE Id = '{0}'", id.ToString());

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlCode, sqlConnection))

                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();



                    reader.Read();

                    managerDto = new BankManagerDto()

                    {

                        Id = reader["Id"].ToString(),

                        Email = reader["Email"].ToString(),

                        FirstName = reader["FirstName"].ToString(),

                        CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),

                        LastName = reader["LastName"].ToString(),

                        PasswordHash = reader["PasswordHash"].ToString(),

                        ApplicationClientType = (ApplicationClientType)Int32.Parse(reader["ApplicationClientType"].ToString()),

                        EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatusType"].ToString())

                    };

                }

                sqlConnection.Close();

            }

            return managerDto;

        }



        public ICollection<BankManagerDto> Read()

        {

            List<BankManagerDto> listBankManagers = new List<BankManagerDto>();

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                string sqlCode = @"SELECT * FROM [dbo].[BankManagers]";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlCode, sqlConnection))

                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())

                    {

                        listBankManagers.Add(new BankManagerDto()

                        {

                            Id = reader["Id"].ToString(),

                            Email = reader["Email"].ToString(),

                            FirstName = reader["FirstName"].ToString(),

                            CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),

                            LastName = reader["LastName"].ToString(),

                            PasswordHash = reader["PasswordHash"].ToString(),

                            ApplicationClientType = (ApplicationClientType)Int32.Parse(reader["ApplicationClientType"].ToString()),

                            EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatusType"].ToString())

                        });

                    }

                }

                sqlConnection.Close();

            }

            return listBankManagers;

        }



        public BankManagerDto ReadByEmail(string email)

        {

            BankManagerDto managerToReturn = null;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                string sqlCode = String.Format(@"SELECT * FROM [dbo].[BankManagers] WHERE Email = '{0}'", email);

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlCode, sqlConnection))

                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();



                    reader.Read();

                    managerToReturn = new BankManagerDto()

                    {

                        Id = reader["Id"].ToString(),

                        Email = reader["Email"].ToString(),

                        FirstName = reader["FirstName"].ToString(),

                        CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),

                        LastName = reader["LastName"].ToString(),

                        PasswordHash = reader["PasswordHash"].ToString(),

                        ApplicationClientType = (ApplicationClientType)Int32.Parse(reader["ApplicationClientType"].ToString()),

                        EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatus"].ToString())

                    };

                }

                sqlConnection.Close();

            }

            return managerToReturn;

        }



        public string Update(BankManagerDto t)

        {

            string res = string.Empty;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string baseInsertQuery = @"UPDATE [dbo].[BankManagers]

                           SET [Email] = '{1}'

                              ,[FirstName] = '{2}'

                              ,[LastName] = '{3}'

                              ,[PasswordHash] = '{4}'

                              ,[CreatedTime] = '{5}'

                              ,[EntityStatus] = {6}

                              ,[ApplicationClientType] = {7}

                            WHERE Id = '{0}'";

                    string realInsertQuery = String.Format(baseInsertQuery,

                         t.Id, t.Email, t.FirstName, t.LastName,

                        t.PasswordHash, t.CreatedTime.ToString()

                        , (int)t.EntityStatus, (int)t.ApplicationClientType);



                    sqlCommand.CommandText = realInsertQuery;

                    sqlCommand.CommandType = CommandType.Text;

                    res = sqlCommand.ExecuteNonQuery().ToString();

                }

                sqlConnection.Close();

            }

            return res;

        }
    }
}
