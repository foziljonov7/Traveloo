using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Models
{
    public class Human
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public int TicketId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
