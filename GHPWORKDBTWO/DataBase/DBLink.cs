using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GHPWORKDBTWO.DataBase
{
    public class DBLink
    {

        public static SqlSugarClient CreateDB()
        {

            DbType Type = DbType.SqlServer;

            switch (ConfigHelper.DBType)
            {

                case "MYSQL":
                    Type = DbType.MySql;
                    break;
                case "ORACLE":
                    Type = DbType.Oracle;
                    break;
                case "SQLSERVER":
                default:
                    break;
            }

            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigHelper.DBOneConnString,

                DbType = Type, //必填
                IsAutoCloseConnection = true //默认false
            });

            return db;

        }


        public static SqlSugarClient CreateDB(string ConnString,string DBType)
        {

            DbType Type = DbType.SqlServer;

            switch (DBType)
            {

                case "MYSQL":
                    Type = DbType.MySql;
                    break;
                case "ORACLE":
                    Type = DbType.Oracle;
                    break;
                case "SQLSERVER":
                default:
                    break;
            }

            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConnString,

                DbType = Type, //必填
                IsAutoCloseConnection = true //默认false
            });

            return db;

        }
    }
}