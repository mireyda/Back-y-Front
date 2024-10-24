using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiEstudiante.Models;

namespace ApiEstudiante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly Conexiones _context;

        public EstudiantesController(Conexiones context)
        {
            _context = context;
        }

        // GET: api/Estudiantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiantes>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/Estudiantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiantes>> GetEstudiantes(int id)
        {
            var estudiantes = await _context.TodoItems.FindAsync(id);

            if (estudiantes == null)
            {
                return NotFound();
            }

            return estudiantes;
        }

        // PUT: api/Estudiantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudiantes(int id, Estudiantes estudiantes)
        {
            if (id != estudiantes.Id)
            {
                return BadRequest();
            }

            _context.Entry(estudiantes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudiantesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Estudiantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estudiantes>> PostEstudiantes(Estudiantes estudiantes)
        {
            _context.TodoItems.Add(estudiantes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstudiantes", new { id = estudiantes.Id }, estudiantes);
        }

        // DELETE: api/Estudiantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudiantes(int id)
        {
            var estudiantes = await _context.TodoItems.FindAsync(id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(estudiantes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstudiantesExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
