using System.Reflection.PortableExecutable;

namespace chernikov
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public Characteristics Characteristics { get; set; }

        public Car(int id, string make, string model, int year, double price, Characteristics characteristics)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Characteristics = characteristics;
        }
    }
}
