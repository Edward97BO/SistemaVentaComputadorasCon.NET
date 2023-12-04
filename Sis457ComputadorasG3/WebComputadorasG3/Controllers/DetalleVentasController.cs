using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebComputadorasG3.Models;

namespace WebComputadorasG3.Controllers
{
    public class DetalleVentasController : Controller
    {
        private readonly LabComputadorasG3Context _context;

        public DetalleVentasController(LabComputadorasG3Context context)
        {
            _context = context;
        }

        // GET: DetalleVentas
        public async Task<IActionResult> Index()
        {
            var labComputadorasG3Context = _context.DetalleVenta.Include(d => d.IdArticuloNavigation).Include(d => d.IdVenta1).Include(d => d.IdVentaNavigation);
            return View(await labComputadorasG3Context.ToListAsync());
        }

        // GET: DetalleVentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta
                .Include(d => d.IdArticuloNavigation)
                .Include(d => d.IdVenta1)
                .Include(d => d.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleVentum == null)
            {
                return NotFound();
            }

            return View(detalleVentum);
        }

        // GET: DetalleVentas/Create
        public IActionResult Create()
        {
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "Id", "Nombre");
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "NumComprobante");
            ViewData["IdVenta"] = new SelectList(_context.Personas, "Id", "Id");
            return View();
        }

        // POST: DetalleVentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdVenta,IdArticulo,Cantidad,Precio,Descuento")] DetalleVentum detalleVentum)
        {
            if (ModelState.IsValid)
            {
                var articulo = new Articulo();
                detalleVentum.UsuarioRegistro = "Edward";
                detalleVentum.FechaRegistro = DateTime.Now;
                detalleVentum.Estado = 1;
                if (detalleVentum.Descuento == 0)
                {
                    detalleVentum.Precio = detalleVentum.Cantidad * articulo.PrecioVenta;
                }
                else
                {
                    detalleVentum.Precio = (detalleVentum.Cantidad * articulo.PrecioVenta) * (detalleVentum.Descuento/100);
                }
                _context.Add(detalleVentum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "Id", "Id", detalleVentum.IdArticulo);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", detalleVentum.IdVenta);
            ViewData["IdVenta"] = new SelectList(_context.Personas, "Id", "Id", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // GET: DetalleVentas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta.FindAsync(id);
            if (detalleVentum == null)
            {
                return NotFound();
            }
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "Id", "Nombre", detalleVentum.IdArticulo);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "NumComprobante", detalleVentum.IdVenta);
            ViewData["IdVenta"] = new SelectList(_context.Personas, "Id", "Nombre", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // POST: DetalleVentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdVenta,IdArticulo,Cantidad,Precio,Descuento")] DetalleVentum detalleVentum)
        {
            if (id != detalleVentum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var articulo = new Articulo();
                    detalleVentum.UsuarioRegistro = "Edward";
                    detalleVentum.FechaRegistro = DateTime.Now;
                    detalleVentum.Estado = 1;
                    if (detalleVentum.Descuento == 0)
                    {
                        detalleVentum.Precio = detalleVentum.Cantidad * articulo.PrecioVenta;
                    }
                    else
                    {
                        detalleVentum.Precio = (detalleVentum.Cantidad * articulo.PrecioVenta) * (detalleVentum.Descuento / 100);
                    }
                    _context.Update(detalleVentum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleVentumExists(detalleVentum.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArticulo"] = new SelectList(_context.Articulos, "Id", "Id", detalleVentum.IdArticulo);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", detalleVentum.IdVenta);
            ViewData["IdVenta"] = new SelectList(_context.Personas, "Id", "Id", detalleVentum.IdVenta);
            return View(detalleVentum);
        }

        // GET: DetalleVentas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVentum = await _context.DetalleVenta
                .Include(d => d.IdArticuloNavigation)
                .Include(d => d.IdVenta1)
                .Include(d => d.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleVentum == null)
            {
                return NotFound();
            }

            return View(detalleVentum);
        }

        // POST: DetalleVentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DetalleVenta == null)
            {
                return Problem("Entity set 'LabComputadorasG3Context.DetalleVenta'  is null.");
            }
            var detalleVentum = await _context.DetalleVenta.FindAsync(id);
            if (detalleVentum != null)
            {
                _context.DetalleVenta.Remove(detalleVentum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleVentumExists(int id)
        {
          return (_context.DetalleVenta?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
