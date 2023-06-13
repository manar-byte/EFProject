using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EFProject.Models
{
    public class Movie
    {
        public  int MovieId { get; set; }
        public int ProducerId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public int? Duration { get; set; }
        public char? Rating { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<Customer_Movie> Customer_Movies { get; set; }
        = new HashSet<Customer_Movie>();
    }
}
