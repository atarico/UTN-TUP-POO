namespace Escuela.Interfaces
{
    public interface IListaEditable<T> where T : class
    {
        void Añadir(T entity);
        void Quitar(T entity);
    }
}
