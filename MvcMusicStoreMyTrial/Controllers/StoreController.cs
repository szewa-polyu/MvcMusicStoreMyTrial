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
        // GET: Store
        public ActionResult Index()
        {
            IList genres = new List<Genre>()
            {
                new Genre { Name = "Disco"},
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };
            return View(genres);
        }

        // GET: Store/Browse
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre
            {
                Name = genre
            };
            return View(genreModel);
        }

        // GET: Store/Details
        public ActionResult Details(int id)
        {
            Album album = new Album
            {
                Title = "Album " + id
            };
            return View(album);
        }
    }
}