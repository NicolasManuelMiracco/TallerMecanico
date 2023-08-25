namespace CapaLogica
{
    /// <summary>
    /// Interfaz que expone los metodos de registro y eliminacion de observers, asi como para la notificacion de los cambios de estado.
    /// </summary>
    public interface ISubject
    {
        void RegistrarObserver(IObserver o);
        void EliminarObserver(IObserver o);
        void NotificarObservers();
    }
}
