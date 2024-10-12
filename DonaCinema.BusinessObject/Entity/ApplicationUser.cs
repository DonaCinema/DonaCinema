using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaCinema.BusinessObject.Entity
{
    public class ApplicationUser : IdentityUser<string>
    {
        public DateTime? Dob { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? AvatarPath { get; set; }
        public bool isActived { get; set; } = false;
        public ICollection<Payment> Payments { get; set; }
        public ICollection<BookDetail> BookDetails { get; set; }
    }
}
