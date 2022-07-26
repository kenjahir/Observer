class Program
{
    static void Main(string[] args)
    {
        var observer1 = new EspecialistaRh("Marco");
        var observer2 = new EspecialistaRh("Maria");

        var proveedor = new ApliccionNotificacion();
        observer1.Suscribir(proveedor);
        observer2.Suscribir(proveedor);

        proveedor.AddAplicaciones(new(1, "Contador"));
        proveedor.AddAplicaciones(new(2, "Cantante"));

        observer1.ListaAplicacion();
        observer2.ListaAplicacion();

        observer2.UnSubcripcion();

        Console.Writeline();
        Console.Writeline($"{observer2.nombre} se ha eliminAdo su subscripcion");
        Console.Writeline();

        proveedor.AddAplicaciones(new(3, "Sistemas"));

        observer1.ListaAplicacion();
        observer2.ListaAplicacion();

        proveedor.CerrarAplicacion();
    }

}