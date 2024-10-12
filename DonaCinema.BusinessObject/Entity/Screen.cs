using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Screen : BaseEntity
    {
        public int SeatingCapacity { get; set; }
        public int Number { get; set; }
        public Guid CinemaId { get; set; }
        public Cinema Cinema { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<ShowTime> ShowTimes { get; set; }
    }
}
