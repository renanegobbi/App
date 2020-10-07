using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_OData.Models;

namespace WebApi_OData.API
{

        [EnableQuery]
        [Route("api/[controller]")]
        [ApiController]
        public class ProdutosController : ControllerBase
        {
            private readonly DbClienteContext _context;

            public ProdutosController(DbClienteContext context)
            {
                _context = context;
            }

            // GET: api/Produtos
            [HttpGet]
            public async Task<ActionResult<IEnumerable<PRODUTO>>> GetProdutos()
            {
                return await _context.Produto.ToListAsync();
            }

            // GET: api/Produtos/5
            [HttpGet("{id}")]
            public async Task<ActionResult<PRODUTO>> GetProduto(int id)
            {
                var Produto = await _context.Produto.FindAsync(id);

                if (Produto == null)
                {
                    return NotFound();
                }

                return Produto;
            }

            // PUT: api/Produtos/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutProduto(int id, PRODUTO Produto)
            {
                if (id != Produto.ID)
                {
                    return BadRequest();
                }

                _context.Entry(Produto).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(id))
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

            // POST: api/Produtos
            [HttpPost]
            public async Task<ActionResult<PRODUTO>> PostProduto(PRODUTO Produto)
            {
                _context.Produto.Add(Produto);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetProduto", new { id = Produto.ID }, Produto);
            }

            // DELETE: api/Produtos/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<PRODUTO>> DeleteProduto(int id)
            {
                var Produto = await _context.Produto.FindAsync(id);
                if (Produto == null)
                {
                    return NotFound();
                }

                _context.Produto.Remove(Produto);
                await _context.SaveChangesAsync();

                return Produto;
            }

            private bool ProdutoExists(int id)
            {
                return _context.Produto.Any(e => e.ID == id);
            }

        }
}
