namespace AppEstudiante.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    public class Estudiantes
    {
        [JsonPropertyName("Id")]
        public Int32? Id { get; set; }

        [JsonPropertyName("Carne")]
        [Required(ErrorMessage = "El carné es obligatorio.")]
        [RegularExpression(@"^E[0-9]{3}$", ErrorMessage = "El carné debe seguir el formato E001 hasta E999.")]
        public string? Carne { get; set; }

        [JsonPropertyName("Nombres")]
        [Required(ErrorMessage = "Los nombres son obligatorios.")]
        public string? Nombres { get; set; }

        [JsonPropertyName("Apellidos")]
        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        public string? Apellidos { get; set; }

        [JsonPropertyName("Direccion")]
        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string? Direccion { get; set; }

        [JsonPropertyName("Telefono")]
        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public string? Telefono { get; set; }

        [JsonPropertyName("Correo_Electronico")]
        public string? Correo_Electronico { get; set; }

        [JsonPropertyName("Id_Tipo_Sangre")]
        [Required(ErrorMessage = "El ID de tipo de sangre es obligatorio.")]
        public string? Id_Tipo_Sangre { get; set; }

        [JsonPropertyName("Fecha_Nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime? Fecha_Nacimiento { get; set; }
    }
}
