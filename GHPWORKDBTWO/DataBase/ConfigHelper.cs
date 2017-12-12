using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GHPWORKDBTWO.DataBase
{
    public static class ConfigHelper
    {

        public static string DBOneConnString = ConfigurationManager.AppSettings["DBOneConnString"].ToString();


        public static string DBType = ConfigurationManager.AppSettings["DBType"].ToString();


    }
}