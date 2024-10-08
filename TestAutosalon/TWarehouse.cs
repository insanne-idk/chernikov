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
            /// REVIEW. a.boikov. 2024/10/08. �������� ��������, ��� ������� ������� ����������� �� ������ ���
            Car car = new Car(1, "Toyota", "Corolla", 2015, 15000, new Characteristics { Horsepower = 150, Transmission = "��������������", Mileage = 50000, Color = "�����������" });

            // Act
            warehouse.AddCar(car);

            // Assert
            Assert.AreEqual(1, warehouse.GetAvailableCars().Count);
        }
    }
}