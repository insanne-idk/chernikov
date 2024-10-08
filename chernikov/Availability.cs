using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chernikov
{
    public class Availability
    {
        public Car Car { get; set; }
        public int Quantity { get; set; }

        public bool IsAvailable()
        {
            return Quantity > 0;

        }

        public void ReserveCar()
        {
            Quantity--;
        }

        public void UnreserveCar()
        {
            Quantity++;
        }
    }
}

