using SqlManager.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace SqlManager.Dal
{
    interface IRepository
    {
        DataSet CreateDataSet(DBEntity dBEntity);
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetEntities(Database database, DBEntityType entityType);
        IEnumerable<Params> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
        DataSet ExecuteQuery(string cmd);
    }
}