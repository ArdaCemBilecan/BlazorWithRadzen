using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Plane
    {
        public int Id { get; set; }
        public string PlaneName { get; set; }
        public decimal TicketPrice { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public string Description { get; set; }
    }
}
