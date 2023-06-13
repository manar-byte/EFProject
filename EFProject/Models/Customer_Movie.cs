using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Customer_Movie
    {
        public int CustomerId { get; set; }
        public int MovieId { get; set; }
        public DateTime? Date_Rented { get; } = DateTime.Now;
        public DateTime? Due_Date { get; } =new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day+10);
        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
