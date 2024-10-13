public class Transaccion
{
    public List<producto> Productos { get; private set; }
    public decimal TotalPagado { get; private set; }
    public DateTime Fecha { get; private set; }

    public Transaccion(List<producto> productos, decimal totalPagado)
    {
        Productos = productos;
        TotalPagado = totalPagado;
        Fecha = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Fecha: {Fecha}, Total Pagado: {TotalPagado:C}";
    }
}
