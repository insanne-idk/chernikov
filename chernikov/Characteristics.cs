namespace chernikov
{
    public class Characteristics
    {
        public int Horsepower { get; set; }
        public string Transmission { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Мощность: {Horsepower}, Трансмиссия: {Transmission}, Пробег: {Mileage}, Цвет: {Color}";
        }
    }
}


