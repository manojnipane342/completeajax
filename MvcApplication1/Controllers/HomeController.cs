using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.edmx;
namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        assignmentEntities dc = new assignmentEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Index(string name, string date, string designation, string qualification, string gender, string relo, string country,string email,string mobile)
        {
            emp tbl = new emp();
            tbl.name = name;
            tbl.dob =  date;
            tbl.desi = designation;
            tbl.qua = qualification;
            tbl.sex = gender;
            tbl.cntid = country;
            tbl.email = email;
            tbl.isrelo = relo;
            tbl.mob = mobile;
            dc.emps.Add(tbl);
            dc.SaveChanges();
            return "employee added";
        }
        [HttpGet]
        public JsonResult getemployees()
        {
            return Json(dc.emps.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult del(int id)
        {
            var p = dc.emps.Find(id);
            dc.emps.Remove(p); 
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public JsonResult editdata(int id)
        {
            var p = (from n in dc.emps where n.id==id select n).ToList();
            return Json(p, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public string edit(int empid,string name, string date, string designation, string qualification, string gender, string relo, string country,string email,string mobile)
        {
            var p = from n in dc.emps where n.id == empid select n;

            foreach (var item in p)
            {
                item.name = name;
                item.dob = date;
                item.desi = designation;
                item.qua = qualification;
                item.sex = gender;
                item.cntid = country;
                item.email = email;
                item.mob = mobile;
                item.isrelo = relo;
            }
            dc.SaveChanges();
            return "edit successfully";
        }
    }
}
