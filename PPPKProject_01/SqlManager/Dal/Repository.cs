using SqlManager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlManager.Dal
{
    class Repository : IRepository
    {
        private string cs;
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";

        private const string SelectDatabases = "SELECT name as Name FROM sys.databases";
        private const string SelectTables = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.TABLES";
        private const string SelectViews = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.VIEWS";
        private const string SelectProcedures = "SELECT SPECIFIC_NAME as Name, ROUTINE_DEFINITION as Definition FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";
        private const string SelectColumns = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'";
        private const string SelectProcedureParameters = "SELECT PARAMETER_NAME as Name, PARAMETER_MODE as Mode, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='{1}'";
        private const string SelectQuery = "SELECT * FROM {0}.{1}.{2}";
        private const string SelectRowCount = "SELECT @@ROWCOUNT";

        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Database
                            {
                                Name = reader[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<DBEntity> GetEntities(Database database, DBEntityType entityType)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    switch (entityType)
                    {
                        case DBEntityType.Table:
                            cmd.CommandText = string.Format(SelectTables, database.Name);
                            cmd.CommandType = System.Data.CommandType.Text;
                            break;
                        case DBEntityType.View:
                            cmd.CommandText = string.Format(SelectViews, database.Name);
                            cmd.CommandType = System.Data.CommandType.Text;
                            break;
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new DBEntity
                            {
                                Name = reader[nameof(DBEntity.Name)].ToString(),
                                Schema = reader[nameof(DBEntity.Schema)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Column> GetColumns(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectColumns, dBEntity.Database.Name, dBEntity.Name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Column
                            {
                                Name = reader[nameof(Column.Name)].ToString(),
                                DataType = reader[nameof(Column.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Procedure> GetProcedures(Database database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedures, database.Name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Procedure
                            {
                                Name = reader[nameof(Procedure.Name)].ToString(),
                                Definition = reader[nameof(Procedure.Definition)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Params> GetParameters(Procedure procedure)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedureParameters, procedure.Database.Name, procedure.Name);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Params
                            {
                                Name = reader[nameof(Params.Name)].ToString(),
                                Mode = reader[nameof(Params.Mode)].ToString(),
                                DataType = reader[nameof(Params.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }
        public DataSet CreateDataSet(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(SelectQuery, dBEntity.Database, dBEntity.Schema, dBEntity.Name), con);
                DataSet ds = new DataSet(dBEntity.Name);
                adapter.Fill(ds);
                ds.Tables[0].TableName = dBEntity.Name;
                return ds;
            }
        }

        public DataSet ExecuteQuery(string text)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(string.Format("{0}\n{1}",text,SelectRowCount), con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
