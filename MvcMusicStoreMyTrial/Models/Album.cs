using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStoreMyTrial.Models
{
    public class Album
    {
        [Display(Name = "Album ID")]
        public int AlbumId { get; set; }

        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }

        [Display(Name = "Artist ID")]
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Album Art URL")]
        public string AlbumArtUrl { get; set; }

        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}