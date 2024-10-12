using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Payment : BaseEntity
    {
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public Guid BookDetailId { get; set; }
        public BookDetail BookDetail { get; set; }

        public string Status { get; set; }
    }
}
