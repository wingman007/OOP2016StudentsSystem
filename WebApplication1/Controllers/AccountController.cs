using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        public ActionResult Index()
        {
            using (StudentSystemDbContext db = new StudentSystemDbContext())
            {
                return View(db.studentLoginAccount.ToList());
            }
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Student student)
        {
            using (StudentSystemDbContext db = new StudentSystemDbContext())
            {
                var stud = db.studentLoginAccount.Where(u => u.Facuktetnumber == student.Facuktetnumber && u.EGN == student.EGN).FirstOrDefault();
                if (stud != null)
                {
                    Session["Факултетният номер"] = stud.Facuktetnumber.ToString();
                    Session["ЕГН"] = stud.EGN.ToString();
                    Session["Форма на обучение"] = stud.Forms.ToString();
                    Session["Курс"] = stud.Course.ToString();
                    Session["Група"] = stud.Groups.ToString();
                    Session["Инспектор"] = stud.Inspector.ToString();
                    Session["ОКС"] = stud.OKS.ToString();
                    Session["Фамилия"] = stud.LastName.ToString();
                    Session["Е-майл"] = stud.Email.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Faculty Number or EGN wrong...");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["Факултетният номер"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
          Session["Факултетният номер"] = null;
          return RedirectToAction("Home", "Index", "Home");
        }
    }

}