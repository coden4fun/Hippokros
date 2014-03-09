using RadSchedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadSchedule.Controllers
{
    public class CalendarController : Controller
    {
        //
        // GET: /Calendar/
        public ActionResult Index()
        {
            List<Projection> docAppointments = new List<Projection>
            {
                new Projection{
                    Title = "Room #4 Kidney",
                    Start = new DateTime(2013,6,13,17,00,00),
                    End= new DateTime(2013,6,13,18,30,00)
                              },
                new Projection{
                    Title = "Room #3 Heart",
                    Start = new DateTime(2013,6,13,17,00,00),
                    End= new DateTime(2013,6,13,18,30,00)
                              },
                new Projection{
                    Title = "Lab Work",
                    Start = new DateTime(2013,6,13,17,00,00),
                    End= new DateTime(2013,6,13,18,30,00)
                              }
            };
            return View(docAppointments);
        }
	}
}