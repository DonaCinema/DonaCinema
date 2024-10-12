using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class ShowTime : BaseEntity
    {
        public Guid ScreenId { get; set; }
        public Screen Screen { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
