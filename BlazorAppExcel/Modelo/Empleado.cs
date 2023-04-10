namespace BlazorAppExcel.Modelo
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public decimal Sueldo { get; set; }
        public string FechaContrato { get; set; } = null!;
    }
}
