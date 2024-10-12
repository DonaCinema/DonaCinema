using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DonaCinema.BusinessObject.Entity
{
    public class Seat : BaseEntity
    {
        public string SeatNumber { get; set; }
        public string SeatType { get; set; }
        public Guid ScreenId { get; set; }
        public Screen Screen { get; set; }
    }
}
