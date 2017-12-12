using GHPWORKDBTWO.DataBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;

namespace GHPWORKDBTWO.Controllers
{
    public class SQLSERVERTABLEController : Controller
    {
        // GET: SQLSERVERTABLE
        public ActionResult List()
        {
            return View();
        }


        public ActionResult Add()
        {

            return View();
        }
 
        public JsonResult AddTable(string Table, string Info)
        {
            using (var db = DBLink.CreateDB())
                try
                {

                    string GUID = Guid.NewGuid().ToString();

                    var table = JsonConvert.DeserializeObject<T_Table>(Table);

                    table.GUID = GUID;

                    var LInfo = JsonConvert.DeserializeObject<List<T_Table_Info>>(Info);

                    foreach (var item in LInfo)
                    {

                        item.Table_GUID = GUID;

                    }

                    db.Ado.BeginTran();

                    db.Insertable<T_Table>(table).ExecuteCommand();

                    db.Insertable<T_Table_Info>(LInfo).ExecuteCommand();

                    db.Ado.CommitTran();

                    return Json(new { status = 1, data = "", msg = "" });

                }
                catch (Exception ex)
                {

                    return Json(new { status = 0, data = "", msg =ex.Message });

                }
        }

    }
}