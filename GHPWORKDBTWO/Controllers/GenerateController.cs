using Entity;
using GHPWORKDBTWO.DataBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GHPWORKDBTWO.Controllers
{
    public class GenerateController : Controller
    {
        // GET: Generate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GenerateInfo()
        {
            return View();
        }

        public ActionResult SetPage()
        {
            return View();
        }

        /// <summary>
        /// 获取可生成的表信息
        /// </summary>
        /// <returns></returns>
        public JsonResult GetKGenerate()
        {
            using (var db = DataBase.DBLink.CreateDB())
                try
                {

                    var data = db.Queryable<T_Table>().ToList();

                    return Json(new { data = data, status = 1, msg = "" });

                }
                catch (Exception ex)
                {
                    return Json(new { status = 0, data = "", msg = ex.Message });
                }
        }

        /// <summary>
        /// 获取可生成的表详细信息  根据ID
        /// </summary>
        /// <returns></returns>
        public JsonResult GetTableInfo(string GUID)
        {

            List<Entity.B_UrlClass> Uds = JsonConvert.DeserializeObject<List<Entity.B_UrlClass>>(GUID);

            string[] GUIDArrey = new string[Uds.Count];

            for (int i = 0; i < Uds.Count; i++)
            {

                GUIDArrey[i] = Uds[i].GUID;

            }

            using (var db = DataBase.DBLink.CreateDB())
                try
                {

                    var TableData = db.Queryable<T_Table>().In(it => it.GUID, GUIDArrey).Where(T=>T.IsDeleted==false).ToList();

                    List<T_Table_Info> list = new List<T_Table_Info>();

                    list = db.Queryable<T_Table_Info>().In(T => T.Table_GUID, GUIDArrey).Where(T=>T.IsDeleted==false).ToList();
 
                    return Json(new { data = list,table= TableData, status = 1, msg = "" });

                }
                catch (Exception ex)
                {

                    return Json(new { status = 0, data = "", msg = ex.Message });

                }

        }

        /// <summary>
        /// 开始生成
        /// </summary>
        /// <returns></returns>
        public JsonResult StartGenerate(string Data) {

            using (var db=DBLink.CreateDB())
                try
                {

                   // db.CodeFirst.BackupTable().InitTables(typeof(CodeTable), typeof(CodeTable2));

                    return null;

                }
                catch (Exception ex)
                {

                    throw;
                }

        }


        public void CreateEntityClass(string Data) {
            try
            {




            }
            catch (Exception)
            {

                throw;
            }
        }


        public JsonResult PageInfo()
        {

            try
            {
                return null;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}