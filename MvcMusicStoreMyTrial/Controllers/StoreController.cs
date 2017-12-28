using MvcMusicStoreMyTrial.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStoreMyTrial.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreEntities storeDB = new MusicStoreEntities();


        // GET: Store
        public ActionResult Index()
        {
            IEnumerable<Genre> genres = storeDB.Genres.ToList();
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            Genre genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);
            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int id)
        {
            Album album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}