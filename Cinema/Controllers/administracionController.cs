using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Controllers
{
  public class administracionController : Controller
  {
    //
    // GET: /administracion/

    public ActionResult inicio()
    {
      return View();
    }

		public ActionResult peliculas()
		{
			return View();
		}

		public ActionResult sedes()
		{
			return View();
		}

		public ActionResult carteleras()
		{
			return View();
		}
		public ActionResult reportes()
		{
			return View();
		}
	}
}
