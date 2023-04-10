
using BlazorAppExcel.Modelo;
using System.Net.Http.Json;

namespace BlazorAppExcel.Servicio
{
    public class EmpleadoServicio : IEmpleadoServicio
    {
        private HttpClient _httpClient;
        public EmpleadoServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Empleado>> Lista()
        {
            //el servicio api es temporal
            var empleados = await _httpClient.GetFromJsonAsync<List<Empleado>>("https://www.servicetemp110.somee.com/api/Empleado");
            return empleados!;
        }
    }
}
