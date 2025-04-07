public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string tipoPan, string tipoCarne, double precioBase)
        : base(tipoPan, tipoCarne, precioBase)
    {
        // Agregar automáticamente papitas y bebida
        adicionales.Add(("Papitas", 3.00));
        adicionales.Add(("Bebida", 2.50));
    }

    public override void AgregarAdicional(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar más ingredientes a la hamburguesa premium.");
    }
}
