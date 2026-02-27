using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD_BACK.Data;
using CRUD_BACK.Models;

namespace CRUD_BACK.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrudController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CrudController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crud>>> GetAll()
        {
            return await _context.CRUD.ToListAsync();
        }

        // GET
        [HttpGet("{numero_control}")]
        public async Task<ActionResult<Crud>> GetById(string numero_control)
        {
            var registro = await _context.CRUD.FindAsync(numero_control);

            if (registro == null)
                return NotFound();

            return registro;
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Crud>> Create(Crud crud)
        {
            _context.CRUD.Add(crud);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), 
                new { numero_control = crud.numero_control }, crud);
        }

        // PUT
        [HttpPut("{numero_control}")]
        public async Task<IActionResult> Update(string numero_control, Crud crud)
        {
            if (numero_control != crud.numero_control)
                return BadRequest();

            _context.Entry(crud).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE
        [HttpDelete("{numero_control}")]
        public async Task<IActionResult> Delete(string numero_control)
        {
            var registro = await _context.CRUD.FindAsync(numero_control);

            if (registro == null)
                return NotFound();

            _context.CRUD.Remove(registro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}