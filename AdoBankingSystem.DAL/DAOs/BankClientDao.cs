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
    public class BankClientDao : IDAO<BankClientDto>
    {
        private SqlConnection sqlConnection = null;

        public string Create(BankClientDto record)
        {
            using(sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                SqlParameter idParameter = new SqlParameter("@Id", SqlDbType.VarChar);
                SqlParameter firstNameParameter = new SqlParameter("@FirstName", SqlDbType.VarChar);
                SqlParameter lastNameParameter = new SqlParameter("@LastName", SqlDbType.VarChar);
                SqlParameter emailParameter = new SqlParameter("@Email", SqlDbType.VarChar);
                SqlParameter passwordHashParameter = new SqlParameter("@PasswordHash", SqlDbType.VarChar);
                SqlParameter createdTimeParameter = new SqlParameter("@CreatedTime", SqlDbType.DateTime);
                SqlParameter entityStatusParameter = new SqlParameter("@EntityStatus", SqlDbType.Int);

                idParameter.Value = record.Id;
                firstNameParameter.Value = record.FirstName;
                lastNameParameter.Value = record.LastName;
                emailParameter.Value = record.Email;
                passwordHashParameter.Value = record.PasswordHash;
                createdTimeParameter.Value = record.CreatedTime;
                entityStatusParameter.Value = record.EntityStatus;

                sqlConnection.Open();
                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "CreateNewBankClient";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(idParameter);
                    sqlCommand.Parameters.Add(firstNameParameter);
                    sqlCommand.Parameters.Add(lastNameParameter);
                    sqlCommand.Parameters.Add(emailParameter);
                    sqlCommand.Parameters.Add(passwordHashParameter);
                    sqlCommand.Parameters.Add(createdTimeParameter);
                    sqlCommand.Parameters.Add(entityStatusParameter);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    return record.Id;
                }
            }
        }

        public BankClientDto Read(string id)
        {
            BankClientDto clientDto = null;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                string sqlCode = String.Format(@"SELECT * FROM [dbo].[BankClients] WHERE Id = '{0}'", id.ToString());

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlCode, sqlConnection))

                {

                    SqlDataReader reader = sqlCommand.ExecuteReader();



                    reader.Read();



                    clientDto = new BankClientDto()

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

            return clientDto;
        }

        public ICollection<BankClientDto> Read()
        {
            ICollection<BankClientDto> users = new List<BankClientDto>();
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                string realQuery = "SELECT * FROM dbo.BankClients";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = realQuery;

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        users.Add(new BankClientDto()
                        {
                            Id = reader["Id"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),
                            EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatus"].ToString())
                        });
                    }
                }
                sqlConnection.Close();
            }
            return users;
        }

        public void Remove(string id)
        {
            using(sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string realInsertQuery = String.Format(@"DELETE FROM [dbo].[BankClients] WHERE Id = '{0}'", id.ToString());

                    sqlCommand.CommandText = realInsertQuery;

                    sqlCommand.CommandType = CommandType.Text;



                    int result = sqlCommand.ExecuteNonQuery();

                    Console.WriteLine(result);

                }

                sqlConnection.Close();

            }
        }

        public string Update(BankClientDto t)
        {
            string res = string.Empty;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string baseInsertQuery = @"UPDATE [dbo].[BankClients]

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
