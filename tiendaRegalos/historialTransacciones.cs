public class HistorialTransacciones
{
    private List<Transaccion> transacciones;

    public HistorialTransacciones()
    {
        transacciones = new List<Transaccion>();
    }

    public void AgregarTransaccion(Transaccion transaccion)
    {
        transacciones.Add(transaccion);
    }

    public void MostrarHistorial()
    {
        if (transacciones.Count == 0)
        {
            Console.WriteLine("No hay transacciones en el historial.");
        }
        else
        {
            Console.WriteLine("Historial de transacciones:");
            foreach (var transaccion in transacciones)
            {
                Console.WriteLine(transaccion.ToString());
            }
        }
    }
}
