using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Models.Request
{
    public class MovieRequestModel
    {
        public string Cast { get; set; }
        public string Language { get; set; }
        public string AgeRating { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }
    }
}
