using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwoStatesDAL;
using TwoStatesBAL;
using System.Dynamic;

namespace Two_States.Controllers
{
    public class TwoStatesController : Controller
    {
        InterfaceClass Balobj = new InterfaceClass();
        // GET: TwoStates
        public ActionResult Index()
        {
            return View();
        }

        //Result for the search box
        List<string> list = new List<string>();
        public JsonResult AutoComplete(string prefix)
        {

            list.Add("jammu and kashmir");
            list.Add("karnataka");
            list.Add("kerala");
            list.Add("hyderabad");
            list.Add("chennai");
            list.Add("goa");
            var customers = from item in list where item.Contains(prefix) select item;

            return Json(customers);
        }

        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registration(FormCollection form)
        {
            Session["User"] = "Loggedout";
            string a = form["username"];
            string email = form["email"];
            string b = form["password"];
            User_Details user = new User_Details();
            user.Username = a;
            user.Password = b;
            user.Email = email;
            string result = Balobj.Register(user);
            ViewBag.Message = result;

            if (result == "Success") {

                Session["User"] = "Loggedin";
                Session["Userid"] = a;
                return RedirectToAction("Index", "TwoStates");
            }

            
            return View();
        }
        public ActionResult Login()
        {
            Session["User"] = "Loggedout";
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string a = form["username"];
            string b = form["password"];
          
            User_Details user = new User_Details();
            user.Username = a;
            user.Password = b;

            string result = Balobj.Login(user);
            ViewBag.Message = result;

            if (result == "Success")
            {
                Session["User"] = "Loggedin";
                Session["Userid"] = a;
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session["User"] = "Loggedout";
            return RedirectToAction("Index");
        }

        public ActionResult CheckExistingUser([Bind(Prefix = "Username")] string username)

        {

            bool ifUserExist = false;

            try

            {

                ifUserExist = UserExists(username) ? true : false;

                return Json(!ifUserExist, JsonRequestBehavior.AllowGet);

            }

            catch (Exception ex)

            {

                return Json(false, JsonRequestBehavior.AllowGet);

            }




        }

        public bool UserExists(string user)
        {
            return Balobj.IsUserExists(user);
        }
        //public ActionResult tables()
        //{
        //    ViewBag.Message = "Welcome to my demo!";
        //    dynamic mymodel = new ExpandoObject();
        //    mymodel.country = c;
        //    mymodel.Students = GetStudents();
        //    return View(mymodel);
        //}
    }

}