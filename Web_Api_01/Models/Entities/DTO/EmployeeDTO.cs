namespace Web_Api_01.Models.Entities.DTO;

public class EmployeeDTO
{
    public required string Nombre { get; set; }
    public required string Correo { get; set; }
    public string? Telefono { get; set; }
    public decimal Salario { get; set; }
}