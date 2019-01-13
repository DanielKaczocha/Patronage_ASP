using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_Patronage.Models
{
    public class MockRoomRepository : IRoomRepository
    {
        private List<Room> rooms;

        public MockRoomRepository()
        {
            if (rooms == null)
            {
                ReloadRooms();
            }
        }

        private void ReloadRooms()
        {
            rooms = new List<Room>
            {
                new Room
                {
                    id = 1,
                    imgUrl = "/images/huge.png",
                    number = 100,
                    name = "White Room",
                    floor = 0,
                    maxOverload = 75,
                    projector = true,
                    wifi = true,
                    inforamtion = "Pokoj z łatwym dostępem."
                },
                     new Room
                     {
                         id = 2,
                         imgUrl = "/images/small.png",
                         number = 100,
                         name = "Yelow Room",
                         floor = 0,
                         maxOverload = 25,
                         projector = false,
                         wifi = true,
                         inforamtion = "Osłoneczniony pokoj."
                     },
                      new Room
                      {
                          id = 3,
                          imgUrl = "/images/huge.png",
                          number = 120,
                          name = "Orange Room",
                          floor = 0,
                          maxOverload = 75,
                          projector = true,
                          wifi = false,
                          inforamtion = "Energetyczny pokoj."
                      },
                       new Room
                       {
                           id = 4,
                           imgUrl = "/images/small.png",
                           number = 132,
                           name = "Green Room",
                           floor = 0,
                           maxOverload = 25,
                           projector = true,
                           wifi = true,
                           inforamtion = "Odświeżający pokoj."
                       },
                        new Room
                        {
                            id = 5,
                            imgUrl = "/images/small.png",
                            number = 200,
                            name = "Turquoise Room",
                            floor = 0,
                            maxOverload = 10,
                            projector = true,
                            wifi = false,
                            inforamtion = "Mały dyskretny pokoj."
                        },
                     new Room
                     {
                         id = 6,
                         imgUrl = "/images/huge.png",
                         number = 210,
                         name = "Cyan Room",
                         floor = 0,
                         maxOverload = 75,
                         projector = false,
                         wifi = true,
                         inforamtion = "Duzy i spokojny pokoj."
                     },
                     new Room
                     {
                         id = 7,
                         imgUrl = "/images/huge.png",
                         number = 220,
                         name = "Violet Room",
                         floor = 0,
                         maxOverload = 75,
                         projector = true,
                         wifi = false,
                         inforamtion = "Duzy pokoi artystyczny."
                     },
                      new Room
                      {
                          id = 8,
                          imgUrl = "/images/small.png",
                          number = 230,
                          name = "Purple Room",
                          floor = 0,
                          maxOverload = 25,
                          projector = true,
                          wifi = false,
                          inforamtion = "Maly pokoj artystyczny."
                      },
                      new Room
                      {
                          id = 9,
                          imgUrl = "/images/huge.png",
                          number = 300,
                          name = "Blue Room",
                          floor = 0,
                          maxOverload = 75,
                          projector = false,
                          wifi = true,
                          inforamtion = "Duzy pokoj z akwarium."
                      },
                    new Room
                    {
                        id = 10,
                        imgUrl = "/images/medium.png",
                        number = 310,
                        name = "Beige Room",
                        floor = 0,
                        maxOverload = 50,
                        projector = false,
                        wifi = true,
                        inforamtion = "Spokojny pokoj."
                    },
                    new Room
                    {
                        id = 11,
                        imgUrl = "/images/medium.png",
                        number = 320,
                        name = "Lavender Room",
                        floor = 0,
                        maxOverload = 50,
                        projector = false,
                        wifi = true,
                        inforamtion = "Jeden z najbardziej spokojnych pokoi."
                    },
                      new Room
                      {
                          id = 12,
                          imgUrl = "/images/small.png",
                          number = 350,
                          name = "Black Room",
                          floor = 2,
                          maxOverload = 25,
                          projector = true,
                          wifi = true,
                          inforamtion = "Pokoj z planetarium."
                      }

        };
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return rooms;
        }

        public Room GetRoomId(int roomId)
        {
            return rooms.FirstOrDefault(s => s.id == roomId);
        }
    }
}
