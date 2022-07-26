public class EspecialistaRH : IObserver<Aplicacion>
{
    private IDisponible cancelacion;
    public string nombre { set; get; }
    public List<Aplicacion> aplicaciones { set; get; }
    public EspecialistaRH(string nombre)
    {
        this.nombre = nombre;
        aplicacions = ();
    }
    public virtual void Suscribir(ApliccionNotificacion proveedor)
    {
        cancelacion = proveedor.Suscribir(this);
    }
    public virtual void UnSubcripcion()
    {
        cancelacion.Dispose();
        aplicacions.Clear();
    }
    public void OnCompleted()
    {
        Console.Writeline($"Hola, {nombre}! no estamos aceptando ninguna apkicacion mas");
    }
    public void OnError(Exception erro)
    {

    }
    public void OnNext(Aplicacion value)
    {
        aplicacions.Add(value);
    }


    public void ListaAplicacion()
    {
        if (aplicacions.Any())
        {
            foreach (var app in aplicacions)
            {
                Console.Writeline($"Hola,{nombre}! {app.NombreAplicacion} acaba de solicitar el trabajo no. {app.IdJob}");
            }
            else
            {
                Console.Writeline($"Hola, {nombre}! Aun no hay aplicaciones");
            }
        }
    }
}