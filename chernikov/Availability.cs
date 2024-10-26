namespace chernikov
{
    /// REVIEW. a.boikov. 2024/10/08. Не вижу смысла в данном классе. <summary>
    /// операции по изененею наличия автомобиля должны производиться в рамках склада (Warehouse)

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

