using Entidades;
using Entidades.SQL;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcularMontoAPagar()
        {
            //ARRANGE
            Mesa mesa1 = new Mesa(1);
            Producto producto1 = new Producto("Pizza", 2300, 2);
            Producto producto2 = new Producto("Coca", 700, 2);
            mesa1.ListaPedidos.Add(producto1);
            mesa1.ListaPedidos.Add(producto2);

            //ACT
            mesa1.CalcularMontoAPagar();

            //ASSERT
            Assert.AreEqual(3000, mesa1.CalcularMontoAPagar());

        }

        [TestMethod]
        public void TestCalcularMontoAPagar0()
        {
            //ARRANGE
            Mesa mesa1 = new Mesa(1);
           
            Producto producto1 = new Producto("Pizza", 2300, 2);
            Producto producto2 = new Producto("Coca", 700, 2);

            //ACT
            mesa1.CalcularMontoAPagar();

            //ASSERT
            Assert.AreEqual(0, mesa1.CalcularMontoAPagar());

        }

        [TestMethod]
        public void TestCalcularMontoAPagar0OtraMesa()
        {
            //ARRANGE
            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);

            Producto producto1 = new Producto("Pizza", 2300, 2);
            Producto producto2 = new Producto("Coca", 700, 2);

            mesa2.ListaPedidos.Add(producto1);
            mesa2.ListaPedidos.Add(producto2);

            //ACT
            mesa1.CalcularMontoAPagar();

            //ASSERT
            Assert.AreEqual(0, mesa1.CalcularMontoAPagar());


        }       
        

    }
}