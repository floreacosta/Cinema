﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cinema.Controllers
{
  public class peliculasController : Controller
  {
    //
    // GET: /peliculas/

    public ActionResult reserva()
    {
      return View();
    }

  }
}
