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
    public class CurrentSessionDao : IDAO<CurrentSessionDto>, IExtendedCurrentSession
    {
        private SqlConnection sqlConnection = null;
        public string Create(CurrentSessionDto record)
        {
            record.Id = Guid.NewGuid().ToString();
            using(sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                string baseQuery = "INSERT INTO [dbo].[CurrentSessions] " +
                    "([Id], [UserId], [SignInTime], [LastOperationTime], [CreatedTime], [EntityStatus])" +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})";

                string realQuery = String.Format
                    (baseQuery, record.Id, record.UserId, record.SignInTime, 
                    record.LastOperationTime, record.CreatedTime, (int)record.EntityStatus);

                sqlConnection.Open();

                using(SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = realQuery;

                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            return record.Id;
        }

        public string GetCurrentSessionIdByUserId(string userId)
        {
            string idToReturn = null;
            using (SqlConnection sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                string baseQuery = "SELECT * FROM dbo.CurrentSessions WHERE UserId = '{0}'";
                string realQuery = String.Format(baseQuery, userId);
                sqlConnection.Open();
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = realQuery;
                    sqlCommand.CommandType = CommandType.Text;

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        idToReturn = reader["Id"].ToString();
                    }             
                    sqlConnection.Close();
                }
            }
            return idToReturn;
        }
        public CurrentSessionDto Read(string id)
        {
            CurrentSessionDto currentSessionDTOToReturn = null;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string baseSelectQuery = @"SELECT * FROM [dbo].[CurrentSessions] WHERE [Id] = '{0}'";

                    string realSelectQuery = String.Format(baseSelectQuery, id.ToString());



                    sqlCommand.CommandText = realSelectQuery;

                    sqlCommand.CommandType = CommandType.Text;



                    SqlDataReader reader = sqlCommand.ExecuteReader();



                    if (reader.HasRows)

                    {

                        reader.Read();



                        currentSessionDTOToReturn = new CurrentSessionDto()

                        {

                            CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),

                            UserId = reader["UserId"].ToString(),

                            SignInTime = DateTime.Parse(reader["SignInTime"].ToString()),

                            LastOperationTime = DateTime.Parse(reader["LastOperationTime"].ToString()),

                            Id = reader["Id"].ToString(),

                            EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatus"].ToString()),

                        };

                    }

                }

                sqlConnection.Close();

            }

            return currentSessionDTOToReturn;
        }

        public ICollection<CurrentSessionDto> Read()
        {
            ICollection<CurrentSessionDto> sessions = new List<CurrentSessionDto>();
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                string realQuery = "SELECT * FROM dbo.CurrentSessions";              

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = realQuery;

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        sessions.Add(new CurrentSessionDto()
                        {
                            Id = reader["Id"].ToString(),
                            UserId = reader["UserId"].ToString(),
                            SignInTime = DateTime.Parse(reader["SignInTime"].ToString()),
                            LastOperationTime = DateTime.Parse(reader["LastOperationTime"].ToString()),
                            CreatedTime = DateTime.Parse(reader["CreatedTime"].ToString()),
                            EntityStatus = (EntityStatusType)Int32.Parse(reader["EntityStatus"].ToString())
                        });
                    }
                }
                sqlConnection.Close();
            }
            return sessions;
        }

        public void Remove(string id)
        {
            using (sqlConnection = DatabaseConnectionFactory.GetConnection())
            {
                string baseQuery = "DELETE FROM dbo.CurrentSessions WHERE Id='{0}'";
                string realQuery = String.Format(baseQuery, id);

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = realQuery;

                    sqlCommand.ExecuteNonQuery();     
                }
                sqlConnection.Close();
            }
        }

        public string Update(CurrentSessionDto t)
        {
            string result = string.Empty;

            using (sqlConnection = DatabaseConnectionFactory.GetConnection())

            {

                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())

                {

                    string baseInsertQuery = @"UPDATE [dbo].[CurrentSessions] SET" +

                                     ",[UserId] = '{0}'" +

                                     ",[SignInTime] = '{1}'" +

                                     ",[LastOperationTime] = '{2}'" +

                                     ",[CreatedTime] = '{3}'" +

                                     ",[EntityStatus] = {4} " +

                                     "WHERE Id = {5}";

                    string realInsertQuery = String.Format(baseInsertQuery,

                        t.UserId.ToString(),

                        t.SignInTime.ToString(),

                        t.LastOperationTime.ToString()

                        , t.CreatedTime.ToString()

                        , t.EntityStatus.ToString(), t.Id);



                    sqlCommand.CommandText = realInsertQuery;

                    sqlCommand.CommandType = CommandType.Text;



                    result = sqlCommand.ExecuteNonQuery().ToString();

                }

                sqlConnection.Close();

            }

            return result;
        }

        
    }
}
