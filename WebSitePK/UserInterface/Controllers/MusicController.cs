using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterface.DataAccess;
using UserInterface.Models;

namespace UserInterface.Controllers
{

    public class MusicController : Controller
    {
        public ActionResult Index()
        {
            List<MusicModel> song = new List<MusicModel>();

            song = SqliteConnector.LoadSong();

            return View(song);
        }
    }
}