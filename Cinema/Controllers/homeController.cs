using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Controllers
{
  public class homeController : Controller
  {
    //
    // GET: /home/

    public ActionResult inicio()
    {
      return View();
    }

		public ActionResult login()
		{
			return View();
		}
	}
}
