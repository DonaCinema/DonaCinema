using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Movie : BaseEntity
    {
        public Guid? PromotionId { get; set; }
        public Promotion? Promotion { get; set; }

        public string Cast {  get; set; }
        public string Language {  get; set; }
        public string AgeRating { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Duration { get; set; }
        public string Country { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }
        public ICollection<ShowTime> ShowTimes { get; set; }
    }
}
