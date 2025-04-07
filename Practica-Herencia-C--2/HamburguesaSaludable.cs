public class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string tipoCarne, double precioBase)
        : base("Pan Integral", tipoCarne, precioBase) { }

    public override void AgregarAdicional(string nombre, double precio)
    {
        if (adicionales.Count < 6)
        {
            adicionales.Add((nombre, precio));
        }
        else
        {
            Console.WriteLine("Solo puedes agregar hasta 6 ingredientes en la hamburguesa saludable.");
        }
    }
}
