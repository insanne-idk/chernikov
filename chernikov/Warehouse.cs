using chernikov;

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
        return _cars.Where(c => !c.IsReserved).ToList(); //Возвращаем только незарезервированные машины
    }

    public bool ReserveCar(int carId)
    {
        Car carToReserve = _cars.FirstOrDefault(c => c.Id == carId && !c.IsReserved);
        if (carToReserve != null)
        {
            carToReserve.IsReserved = true;
            return true;
        }
        return false;
    }

    public bool IsCarAvailable(int carId)
    {
        return _cars.Any(c => c.Id == carId && !c.IsReserved);
    }


}
