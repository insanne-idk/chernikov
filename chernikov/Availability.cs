namespace chernikov
{
    /// REVIEW. a.boikov. 2024/10/08. Не вижу смысла в данном классе. <summary>
    /// операции по изененею наличия автомобиля должны производиться в рамках склада (Warehouse)

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

