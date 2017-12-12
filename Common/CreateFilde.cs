using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Common
{
    public class Generate
    {

        System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);
        //"FieldName": "Key",
        //       "FieldType": "varchar(50)",
        //       "Explain": "键",
        //       "IsPrimarykey": false,
        //       "Table_GUID": "160ecf7a-140b-4c01-a9b0-c62a29a1ee65",
        //       "ID": 2,
        //       "IsDeleted": false,
        //       "CreateTime": "/Date(1511794022070)/",
        //       "GUID": "63374f02-c73f-4f03-babc-48977046a149"


        /// <summary>
        /// 生成字段
        /// </summary>
        /// <returns></returns>
        public string CreateFilde(T_Table_Info info)
        {
            try
            {
              

                if (string.IsNullOrEmpty(info.FieldType))
                    throw new Exception(ErrorCommon.CreateErrorString("FieldType不能为空", st.GetFrame(0).GetFileLineNumber()+"", st.GetFrame(0).GetFileName()));

                //  if(EntityBase.GetType())


                //   string FildeTxt = string.Format(" public {0} {1} { get; set; }",);

                return "";


    }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
