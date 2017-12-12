using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class EntityBase
    {

        static public string _String = "string";

        static public string _Int = "int";

        static public string _Double = "double";

        static public string _Bool = "bool";

        static public string _Boolean = "Boolean";

        static string[] StringArrey = new string[] { "varchar", "nvarchar", "char", "nchar","string"};

        static string[] IntArrey = new string[] {"int"};

        static string[] DoubleArrey = new string[] { "double","decimal", "float" };

        static string[] BoolArrey = new string[] { "bool", "bit"};

        static string[] BooleanArrey = new string[] { "boolean" };

        public static string GetEntityFildeType(string Type) {

            if (Type.Contains("("))
                if (Type.Contains(")")) {

                }




            if (Array.IndexOf(StringArrey, Type) > -1) 
                return _String;

            if (Array.IndexOf(IntArrey, Type) > -1)
                return _Int;

            if (Array.IndexOf(DoubleArrey, Type) > -1)
                return _Double;
          
            if (Array.IndexOf(BoolArrey, Type) > -1)
                return _Bool;

            if (Array.IndexOf(BooleanArrey, Type) > -1)
                return _Boolean;

            return "";

        }
 
    }
}
