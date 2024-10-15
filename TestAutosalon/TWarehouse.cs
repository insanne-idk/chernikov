using chernikov;

namespace TestAutosalon
{
    [TestClass]
    public class TWarehouse
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Warehouse warehouse = new Warehouse();
            Assert.AreEqual(0, warehouse.GetAvailableCars().Count);

            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "Автоматическая", Mileage = 50000, Color = "Серебристый" });

            // Act
            warehouse.AddCar(car);

            // Assert
            Assert.AreEqual(1, warehouse.GetAvailableCars().Count);
        }
        [TestMethod]
        public void ReserveCar_WhenCarIsAvailable_ReturnsTrue()
        {
            // Arrange
            var availability = new Availability(2); // 2 автомобиля в наличии
            var carId = 1;

            // Act
            var isAvailable = availability.ReserveCar(carId);

            // Assert
            Assert.IsTrue(isAvailable);

        }
        [TestMethod]
        public void ReserveCar_WhenCarIsNotAvailable_ReturnsFalse()
        {
            // Arrange
            var availability = new Availability(0); // 0 автомобилей в наличии
            var carId = 1;

            // Act
            var isAvailable = availability.ReserveCar(carId);

            // Assert
            Assert.IsFalse(isAvailable);
        }

    }
}