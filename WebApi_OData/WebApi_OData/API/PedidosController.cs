using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_OData.Models;

namespace WebApi_OData.API
{
    [EnableQuery]
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly DbClienteContext _context;

        public PedidosController(DbClienteContext context)
        {
            _context = context;
        }

        // GET: api/Pedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PEDIDO>>> GetPedidos()
        {
            return await _context.Pedido.ToListAsync();
        }

        // PUT: api/Pedidos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, PEDIDO pedido)
        {
            if (id != pedido.ID)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PEDIDOExists(id))
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

        // POST: api/Pedidos
        [HttpPost]
        public async Task<ActionResult<PEDIDO>> PostPedido(PEDIDO pedido)
        {
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPEDIDO", new { id = pedido.ID }, pedido);
        }

        // DELETE: api/Pedidos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PEDIDO>> DeletePEDIDO(int id)
        {
            var PEDIDO = await _context.Pedido.FindAsync(id);
            if (PEDIDO == null)
            {
                return NotFound();
            }

            _context.Pedido.Remove(PEDIDO);
            await _context.SaveChangesAsync();

            return PEDIDO;
        }

        private bool PEDIDOExists(int id)
        {
            return _context.Pedido.Any(e => e.ID == id);
        }
    }
}
