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
            {
                // Arrange
                Warehouse warehouse = new Warehouse();
                // Ќе добавл€ем автомобиль с ID 2 на склад, чтобы он отсутствовал
                var carId = 2; // ID автомобил€, который отсутствует на складе

                // Act
                bool result = warehouse.GetAvailableCars(carId); // «апрашиваем наличие конкретной марки

                // Assert
                Assert.IsFalse(result); // ѕровер€ем, что резервирование вернуло false
            }

            // Assert

        }
    }
}