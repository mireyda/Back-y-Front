using Microsoft.EntityFrameworkCore;


namespace ApiEstudiante.Models;


public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options) {
    }

    public DbSet<Estudiantes> TodoItems { get; set; } = null!;
}