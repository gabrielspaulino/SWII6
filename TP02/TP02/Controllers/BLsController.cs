using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP02.Models;
using TP02.Repository;

namespace TP02.Controllers
{
    public class BLsController : Controller
    {
        private readonly Context _context;

        public BLsController(Context context)
        {
            _context = context;
        }

        // GET: BLs
        public async Task<IActionResult> Index()
        {
              return View(await _context.BL.ToListAsync());
        }

        // GET: BLs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BL == null)
            {
                return NotFound();
            }

            var bL = await _context.BL
                .FirstOrDefaultAsync(m => m.Numero == id);
            if (bL == null)
            {
                return NotFound();
            }

            return View(bL);
        }

        // GET: BLs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BLs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Numero,Consignee,Navio")] BL bL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bL);
        }

        // GET: BLs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BL == null)
            {
                return NotFound();
            }

            var bL = await _context.BL.FindAsync(id);
            if (bL == null)
            {
                return NotFound();
            }
            return View(bL);
        }

        // POST: BLs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Numero,Consignee,Navio")] BL bL)
        {
            if (id != bL.Numero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BLExists(bL.Numero))
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
            return View(bL);
        }

        // GET: BLs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BL == null)
            {
                return NotFound();
            }

            var bL = await _context.BL
                .FirstOrDefaultAsync(m => m.Numero == id);
            if (bL == null)
            {
                return NotFound();
            }

            return View(bL);
        }

        // POST: BLs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BL == null)
            {
                return Problem("Entity set 'Context.BL'  is null.");
            }
            var bL = await _context.BL.FindAsync(id);
            if (bL != null)
            {
                _context.BL.Remove(bL);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BLExists(int id)
        {
          return _context.BL.Any(e => e.Numero == id);
        }
    }
}
