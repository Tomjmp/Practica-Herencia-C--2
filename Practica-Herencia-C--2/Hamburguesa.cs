public class Hamburguesa
{
    protected string tipoPan;
    protected string tipoCarne;
    protected double precioBase;
    protected List<(string nombre, double precio)> adicionales;

    public Hamburguesa(string tipoPan, string tipoCarne, double precioBase)
    {
        this.tipoPan = tipoPan;
        this.tipoCarne = tipoCarne;
        this.precioBase = precioBase;
        this.adicionales = new List<(string, double)>();
    }

    public virtual void AgregarAdicional(string nombre, double precio)
    {
        if (adicionales.Count < 4)
        {
            adicionales.Add((nombre, precio));
        }
        else
        {
            Console.WriteLine("Solo puedes agregar hasta 4 ingredientes adicionales.");
        }
    }

    public virtual void MostrarPrecioTotal()
    {
        Console.WriteLine($"Hamburguesa ({tipoPan}, {tipoCarne}) - Base: {precioBase:C2}");
        double total = precioBase;
        foreach (var adicional in adicionales)
        {
            Console.WriteLine($"Adicional: {adicional.nombre} - {adicional.precio:C2}");
            total += adicional.precio;
        }
        Console.WriteLine($"Total: {total:C2}\n");
    }
}
