using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserInterface.Models
{
    public class MusicModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Year { get; set; }
        public string CoverArt { get; set; }
        public string Alblum { get; set; }
        public int Rank { get; set; }
    }
}