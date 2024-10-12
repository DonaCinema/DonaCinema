using PRN231.ExploreNow.BusinessObject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class Cinema : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfScreen {  get; set; }
        public ICollection<Screen> Screens { get; set; }
    }
}
