using chernikov;

namespace TestAutosalon
{
    [TestClass]
    public class TWarehouse
    {
        [TestMethod]
        public void TestAddCar_WhenCarIsAdded_ThenAvailableCarsCountIncrements()
        {
            // Arrange
            Warehouse warehouse = new Warehouse();
            Assert.AreEqual(0, warehouse.GetAvailableCars().Count);

            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "јвтоматическа€", Mileage = 50000, Color = "—еребристый" });

            // Act
            warehouse.AddCar(car);

            // Assert
            Assert.AreEqual(1, warehouse.GetAvailableCars().Count);
        }
        [TestMethod]
        public void ReserveCar_WhenCarIsAvailable_ReturnsTrue()
        {
            Warehouse warehouse = new Warehouse();
            Availability carAvailability = new Availability(1);
            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "јвтоматическа€", Mileage = 50000, Color = "—еребристый" });
            warehouse.AddCar(car);// ƒобавл€ем конкретную марку на склад

            // Act
            carAvailability.ReserveCar(1); // «апрашиваем наличие конкретной марки

            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ReserveCar_WhenCarIsNotAvailable_ReturnsFalse()
        {
            /// REVIEW. a.boikov. 2014/10/26. Ќужно вносить конкретные марки на склад.
            /// «апрашивать наличие конкретной марки, которой нет в наличии
            // Arrange
            Warehouse warehouse = new Warehouse();
            Availability carAvailability = new Availability(2);
            

            var carId = 2; // ID автомобил€, который отсутствует на складе

            // Act
            carAvailability.ReserveCar(2); // «апрашиваем наличие конкретной марки

            // Assert
            Assert.IsFalse(false); // «апрашиваем наличие конкретной марки, которой нет в наличии

            // Assert

        }
    }
}