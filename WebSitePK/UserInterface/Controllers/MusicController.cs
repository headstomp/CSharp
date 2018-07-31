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
            List<MusicModel> songs = new List<MusicModel>();

            songs = SqliteConnector.LoadSongs();

            return View(songs);
        }

        public ActionResult Details( int id)
        {
            MusicModel song = new MusicModel();

            song = SqliteConnector.LoadSongDetails(id).SingleOrDefault(x => x.Id == id);

            return View(song);
        }


        public ViewResult Create()
        {
            MusicModel songs = new MusicModel();
            return View(songs);
        }
    }
}