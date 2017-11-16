using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TelerikGridMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<BigCompany> list = new List<BigCompany>();
            using(CompaniesDbEntities dc = new CompaniesDbEntities())
            {
                list = dc.BigCompanies.OrderBy(o => o.Rank).ToList();
            }
            return View(list);
        }

    }
}
