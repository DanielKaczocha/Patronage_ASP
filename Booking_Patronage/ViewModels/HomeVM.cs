using Booking_Patronage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Patronage.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
