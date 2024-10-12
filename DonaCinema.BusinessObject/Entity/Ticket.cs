using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Ticket : BaseEntity
    {
        public decimal Price { get; set; }
        public Guid SeatId { get; set; }
        public Seat Seat { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Guid BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; }
        public Guid ShowTimeId { get; set; }
        public ShowTime ShowTime { get; set; }

    }
}
