class Program
{
    static void Main()
    {
        var clasica = new Hamburguesa("Pan Blanco", "Res", 5.00);
        clasica.AgregarAdicional("Lechuga", 0.50);
        clasica.AgregarAdicional("Tomate", 0.30);
        clasica.MostrarPrecioTotal();

        var saludable = new HamburguesaSaludable("Pollo", 6.00);
        saludable.AgregarAdicional("Aguacate", 0.80);
        saludable.AgregarAdicional("Espinaca", 0.40);
        saludable.AgregarAdicional("Tomate", 0.30);
        saludable.MostrarPrecioTotal();

        var premium = new HamburguesaPremium("Pan Brioche", "Angus", 8.00);
        premium.AgregarAdicional("Bacon", 1.00);  // No se permite
        premium.MostrarPrecioTotal();
    }
}
