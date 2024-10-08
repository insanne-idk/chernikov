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

