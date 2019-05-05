using System;
using Microsoft.AspNetCore.Mvc;

namespace StudentApplication.Controllers
{
    //estend controller class
    public class DataController : Controller
    {
       public ActionResult ViewAll()
        {
            return View();
        }
    }
}
