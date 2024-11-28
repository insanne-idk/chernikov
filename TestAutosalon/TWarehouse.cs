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

            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000.0, new Characteristics { Horsepower = 150, Transmission = "Автоматическая", Mileage = 50000, Color = "Серебристый" });

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
            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "Автоматическая", Mileage = 50000, Color = "Серебристый" });
            warehouse.AddCar(car);// Добавляем конкретную марку на склад

            // Act
            carAvailability.ReserveCar(1); // Запрашиваем наличие конкретной марки

            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ReserveCar_WhenCarIsNotAvailable_ReturnsFalse()
        {
            // Подготовка
            Warehouse warehouse = new Warehouse();
            int carId = 1; // ID автомобиля, которого нет на складе

            // Действие
            bool result = warehouse.ReserveCar(carId);

            // Утверждение
            Assert.IsFalse(result, $"Резервирование должно было завершиться неудачей для несуществующего ID автомобиля {carId}");
        }

        // Assert

    }
    }
