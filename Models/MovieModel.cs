using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSite.Models
{
    public class MovieModel
    {
        public string title { get; set; }
        public string category { get; set; }
        public string year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent_to { get; set; }
        public string notes { get; set; }

    }
}
