using chernikov;

namespace TestAutosalon
{
    [TestClass]
    public class TWarehouse
    {
        [TestMethod]
        /// REVIEW. a.boikov. 2024/10/26. ћетод назвать так, чтобы пон€ть, что он тестирует с префиксом Test
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
            /// REVIEW. a.boikov. 2014/10/26. Ќужно вносить конкретные марки на склад.
            /// «апрашивать наличие конкретной марки, котора€ есть в наличии
            // Arrange
            var availability = new Availability(2); // 2 автомобил€ в наличии
            var carId = 1;

            // Act
            var isAvailable = availability.ReserveCar(carId);

            // Assert
            Assert.IsTrue(isAvailable);

        }
        [TestMethod]
        public void ReserveCar_WhenCarIsNotAvailable_ReturnsFalse()
        {
            /// REVIEW. a.boikov. 2014/10/26. Ќужно вносить конкретные марки на склад.
            /// «апрашивать наличие конкретной марки, которой нет в наличии
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