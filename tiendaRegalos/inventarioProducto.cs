using System;
using System.Collections.Generic;

public class inventarioProducto
{
    private List<producto> productos;

    public inventarioProducto()
    {
        productos = new List<producto>();
    }

    public void AgregarProducto(producto producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Producto '{producto.Nombre}' agregado.");
    }

    public void EliminarProducto(string nombre)
    {
        producto producto = productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (producto != null)
        {
            productos.Remove(producto);
            Console.WriteLine($"Producto '{nombre}' eliminado.");
        }
        else
        {
            Console.WriteLine($"Producto '{nombre}' no encontrado.");
        }
    }

    public void ActualizarProducto(string nombre, int cantidad)
    {
        producto producto = productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (producto != null)
        {
            producto.Cantidad = cantidad;
            Console.WriteLine($"Cantidad de '{nombre}' actualizada a {cantidad}.");
        }
        else
        {
            Console.WriteLine($"Producto '{nombre}' no encontrado.");
        }
    }

    public void MostrarProductos()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos en el inventario.");
        }
        else
        {
            Console.WriteLine("Productos disponibles en el inventario:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }
    }

    public producto ObtenerProducto(string nombre)
    {
        return productos.Find(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }
}

public class producto
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    public producto(string nombre, int cantidad, decimal precio)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Cantidad: {Cantidad}, Precio: {Precio:C}";
    }
}

public class Program
{
    public static void Main()
    {
        inventarioProducto inventario = new inventarioProducto();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Menú de Inventario ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Actualizar cantidad de producto");
            Console.WriteLine("4. Mostrar productos");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del producto: ");
                    string nombreAgregar = Console.ReadLine();
                    Console.Write("Cantidad del producto: ");
                    int cantidadAgregar = int.Parse(Console.ReadLine());
                    Console.Write("Precio del producto: ");
                    decimal precioAgregar = decimal.Parse(Console.ReadLine());
                    producto nuevoProducto = new producto(nombreAgregar, cantidadAgregar, precioAgregar);
                    inventario.AgregarProducto(nuevoProducto);
                    break;

                case "2":
                    Console.Write("Nombre del producto a eliminar: ");
                    string nombreEliminar = Console.ReadLine();
                    inventario.EliminarProducto(nombreEliminar);
                    break;

                case "3":
                    Console.Write("Nombre del producto a actualizar: ");
                    string nombreActualizar = Console.ReadLine();
                    Console.Write("Nueva cantidad: ");
                    int nuevaCantidad = int.Parse(Console.ReadLine());
                    inventario.ActualizarProducto(nombreActualizar, nuevaCantidad);
                    break;

                case "4":
                    inventario.MostrarProductos();
                    break;

                case "5":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }
}
