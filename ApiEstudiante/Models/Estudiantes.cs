namespace ApiEstudiante.Models;

public class Estudiantes
{
    public Int32 Id { get; set; }
    public string? Carne { get; set; }
    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }

    public string? Correo_Electronico { get; set; }
    public string? Id_Tipo_Sangre { get; set; }

    public DateTime? Fecha_Nacimiento { get; set; }

}