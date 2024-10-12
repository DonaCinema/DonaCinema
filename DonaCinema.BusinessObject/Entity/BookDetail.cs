using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class BookDetail : BaseEntity
    { 
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public decimal TotalPrice { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
    }
}
