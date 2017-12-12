using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Base
{
  public  class BaseEntity
    {

        public BaseEntity() {
            CreateTime = DateTime.Now;
            GUID = Guid.NewGuid().ToString();
        }

        public int ID { get; set; }

        public bool IsDeleted { get; set; }//是否删除

        public DateTime CreateTime { get; set; }//创建时间

        public string GUID { get; set; }

    }
}
