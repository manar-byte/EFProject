using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EFProject.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        [StringLength(200)]
        public string CompanyName { get; set; }
        [StringLength(255)]
        public string Country { get; set;}
        public virtual ICollection<Movie> Movies { get; set; }
        =new HashSet<Movie>();
    }
}
