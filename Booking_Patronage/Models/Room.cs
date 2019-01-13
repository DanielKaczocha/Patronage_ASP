using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Patronage.Models
{
    public class Room
    {
        public int id { get; set; }
        public string imgUrl { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public int floor { get; set; }
        public int maxOverload { get; set; }
        public bool projector { get; set; }
        public bool wifi { get; set; }
        public string inforamtion { get; set; }
    }
}
