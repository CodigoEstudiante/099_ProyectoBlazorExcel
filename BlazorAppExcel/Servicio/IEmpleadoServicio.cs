using BlazorAppExcel.Modelo;
namespace BlazorAppExcel.Servicio
{
    public interface IEmpleadoServicio
    {
        Task<List<Empleado>> Lista();
    }
}
