using NUnit.Framework;
using TiendaRegalos;

namespace TiendaRegalos.Tests
{
    [TestFixture]
    public class ProductoTests
    {
        [Test]
        public void CrearProducto_CrearCorrectamente()
        {
            var nombre = "Regalo1";
            var cantidad = 10;
            var precio = 19.99m;

            var producto = new producto(nombre, cantidad, precio);

            Assert.AreEqual(nombre, producto.Nombre);
            Assert.AreEqual(cantidad, producto.Cantidad);
            Assert.AreEqual(precio, producto.Precio);
        }
    }

    [TestFixture]
    public class InventarioProductoTests
    {
        [Test]
        public void AgregarProducto_AgregaCorrectamente()
        {
            var inventario = new inventarioProducto();
            var producto = new producto("Regalo1", 10, 19.99m);

            inventario.AgregarProducto(producto);
            var resultado = inventario.ObtenerProducto("Regalo1");

            Assert.IsNotNull(resultado);
            Assert.AreEqual("Regalo1", resultado.Nombre);
        }
    }
}
