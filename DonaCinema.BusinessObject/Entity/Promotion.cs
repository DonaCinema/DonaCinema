using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Promotion : BaseEntity
    {
        public decimal DiscountPercentage { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
