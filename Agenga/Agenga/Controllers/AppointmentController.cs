﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenga.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult addAppointment()
        {
            return View();
        }
    }
}