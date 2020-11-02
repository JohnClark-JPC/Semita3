using Microsoft.AspNetCore.Mvc;
using Semita3.Data;
using Semita3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semita3.Controllers
{
    public class ProjectTicketsController : Controller
    {
        public ActionResult GetProjectVMTicketVM()
        {
            var model = new ProjectTicketViewModel();
            return View(model);
        }
    }
}
