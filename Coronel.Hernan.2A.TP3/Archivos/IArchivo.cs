
namespace Archivos
{
    /// <summary>
    /// Interfaz para lectura/escritura de archivos.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IArchivo<T>
    {
        bool guardar(string archivos, T datos);
        bool leer(string archivos,out T datos);
    }
}
