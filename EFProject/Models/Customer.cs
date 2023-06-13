using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFProject.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? PhoneNumber { get; set; } 
        public virtual ICollection<Customer_Movie> Customer_Movies { get; set; }
        =new HashSet<Customer_Movie>();


    }
}
