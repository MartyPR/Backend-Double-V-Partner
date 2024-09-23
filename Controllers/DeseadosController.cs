using Challenge_Double_V_Partners.Data;
using Challenge_Double_V_Partners.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Double_V_Partners.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeseadosController : ControllerBase
    {
        private readonly TiendaContext _context;

        public DeseadosController(TiendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddProductoDeseado(int productoId, int userId)
        {
            var producto = await _context.Productos.FindAsync(productoId);
            if (producto == null) return NotFound();

            var productoDeseado = new ProductoDeseado { ProductoId = productoId, UserId = userId };
            _context.ProductosDeseados.Add(productoDeseado);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveProductoDeseado(int id)
        {
            var productoDeseado = await _context.ProductosDeseados.FindAsync(id);
            if (productoDeseado == null) return NotFound();

            _context.ProductosDeseados.Remove(productoDeseado);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<ProductoDeseado>>> GetProductosDeseados(int userId)
        {
            var productosDeseados = await _context.ProductosDeseados
                .Where(pd => pd.UserId == userId)
                .Include(pd => pd.Producto)
                .ToListAsync();
            return Ok(productosDeseados);
        }
    }
}
