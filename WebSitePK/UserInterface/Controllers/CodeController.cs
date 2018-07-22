using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterface.DataAccess;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class CodeController : Controller
    {
        public ActionResult Index()
        {
            List<CodeModel> program = new List<CodeModel>();

            program = SqliteConnector.LoadProgram();

            return View(program);
        }

        
    }

    
}