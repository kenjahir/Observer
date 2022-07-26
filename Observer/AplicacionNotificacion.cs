class ApliccionNotificacion
{
    private readonly List<IObserver<Aplicacion>> observers;
    public List<Aplicacion> aplicacion { get; set; }
    public ApliccionNotificacion()
    {
        observers = new();
        aplicacion = new();
    }
    public IDisponible Suscribir(IObserver<Aplicacion> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
            foreach (var item in aplicacion)
            {
                observer.OnNext(item);
            }
        }
    }
}