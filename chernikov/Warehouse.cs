using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chernikov
{
    public class Warehouse
    {
        private List<Car> _cars;

        public Warehouse()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            _cars.Remove(car);
        }

        public List<Car> GetAvailableCars()
        {
            return _cars;
        }
    }
}

