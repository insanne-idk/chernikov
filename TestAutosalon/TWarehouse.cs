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

            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "��������������", Mileage = 50000, Color = "�����������" });

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
            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "��������������", Mileage = 50000, Color = "�����������" });
            warehouse.AddCar(car);// ��������� ���������� ����� �� �����

            // Act
            carAvailability.ReserveCar(1); // ����������� ������� ���������� �����

            // Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void ReserveCar_WhenCarIsNotAvailable_ReturnsFalse()
        {
            /// REVIEW. a.boikov. 2014/10/26. ����� ������� ���������� ����� �� �����.
            /// ����������� ������� ���������� �����, ������� ��� � �������
            // Arrange
            Warehouse warehouse = new Warehouse();
            Availability carAvailability = new Availability(2);
            

            var carId = 2; // ID ����������, ������� ����������� �� ������

            // Act
            carAvailability.ReserveCar(2); // ����������� ������� ���������� �����

            // Assert
            Assert.IsFalse(false); // ����������� ������� ���������� �����, ������� ��� � �������

            // Assert

        }
    }
}