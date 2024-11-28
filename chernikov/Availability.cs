namespace chernikov
{
    
    public class Availability
    {
        public Car Car { get; set; }
        public int Quantity { get; set; }

        public Availability(int quantity)
        {
            Quantity = quantity;
        }

        public bool IsAvailable()
        {
            return Quantity > 0;

        }

        public bool ReserveCar(int carId)
        {
            if (Quantity > 0)
            {
                Quantity--;
                return true;
            }
            return false;
        }

        public void UnreserveCar()
        {
            Quantity++;
        }
    }
}

