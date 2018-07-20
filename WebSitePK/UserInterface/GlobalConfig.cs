﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using UserInterface.DataAccess;

namespace UserInterface
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public const string db = "SQLite";

        // to web form when saving (see tracker)
        //GlobalConfig.Connection.CreatePerson(p);

        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.SQLServer)
            {
                SqlConnector mssql = new SqlConnector();
                Connection = mssql;
            }
            else if (db == DatabaseType.TextFile)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
            else if (db == DatabaseType.SQLite)
            {
                SqliteConnector sql = new SqliteConnector();
                Connection = sql;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
