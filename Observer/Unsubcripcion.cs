public class Unsubcripcion : IDisponible
{
    private readonly List<IObserver<Aplicacion>> observers;
    private readonly List<IObserver<Aplicacion>> observers;

    public UnSubcripcion(List<IObserver<Aplicacion>> observers, IObserver<Aplicacion> observer)
    {
        this.observers = observers;
        this.observer = observer
    }
}