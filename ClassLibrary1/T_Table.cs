using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class T_Table:Base.BaseEntity
    {

        public string TableName { get; set; }//表明

        public string TableType { get; set; }//表类型

        public string TableExplain { get; set; }//表说明

    }
}
