using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaboBoat.DataAcces.Entities
{
   public class Boat
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Model { get; set; }
        public string LicencePlate { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }
        public int Price { get; set; }

    }
}
