using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking_Patronage.Models;
using Booking_Patronage.ViewModels;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Booking_Patronage.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public HomeController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {


            var rooms = _roomRepository.GetAllRooms().OrderBy(s => s.id);

            var homeVM = new HomeVM()
            {
                Tytul = "Rezerwacja sal",
                Rooms = rooms.ToList()
            };

            return View(homeVM);
        }

    }
}
