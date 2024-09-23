using Challenge_Double_V_Partners.Data;
using Challenge_Double_V_Partners.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace Challenge_Double_V_Partners.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly TiendaContext _context;

        public CategoriasController(TiendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return await _context.Categorias.Include(c => c.Productos).ToListAsync();
        }
    }
}
