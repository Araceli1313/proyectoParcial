using System;
using System.Collections.Generic;

public class CarritoCompra
{
    private List<producto> productos;
    private const decimal Impuesto = 0.12m;

    public CarritoCompra()
    {
        productos = new List<producto>();
    }

    public void AgregarProducto(producto producto)
    {
        productos.Add(producto);
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var producto in productos)
        {
            total += producto.Precio * producto.Cantidad;
        }
        return total + (total * Impuesto);
    }

    public void MostrarCarrito()
    {
        Console.WriteLine("Productos en el carrito:");
        foreach (var producto in productos)
        {
            Console.WriteLine($"{producto.Nombre} - Cantidad: {producto.Cantidad} - Precio: {producto.Precio:C}");
        }
        Console.WriteLine($"Total (con impuesto): {CalcularTotal():C}");
    }
}
