using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class T_Table_Info: BaseEntity
    {

        public string FieldName { get; set; }//字段名称

        public string FieldType { get; set; }//字段类型

        public string Explain { get; set; }//说明

        public bool IsPrimarykey { get; set; }//是否删除

        public string Table_GUID { get; set; }//table 表GUID
    }
}
