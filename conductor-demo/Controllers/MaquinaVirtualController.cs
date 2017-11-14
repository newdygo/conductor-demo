using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using conductor.demo.Models;

namespace conductor_demo.Controllers
{
    public class MaquinaVirtualController : Controller
    {
        private readonly ConductorDemoContext _context;

        public MaquinaVirtualController(ConductorDemoContext context)
        {
            _context = context;
        }

        // GET: MaquinaVirtual
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaquinaVirtual.ToListAsync());
        }

        // GET: MaquinaVirtual/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaVirtual = await _context.MaquinaVirtual
                .SingleOrDefaultAsync(m => m.Id == id);
            if (maquinaVirtual == null)
            {
                return NotFound();
            }

            return View(maquinaVirtual);
        }

        // GET: MaquinaVirtual/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaquinaVirtual/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] MaquinaVirtual maquinaVirtual)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maquinaVirtual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maquinaVirtual);
        }

        // GET: MaquinaVirtual/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaVirtual = await _context.MaquinaVirtual.SingleOrDefaultAsync(m => m.Id == id);
            if (maquinaVirtual == null)
            {
                return NotFound();
            }
            return View(maquinaVirtual);
        }

        // POST: MaquinaVirtual/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] MaquinaVirtual maquinaVirtual)
        {
            if (id != maquinaVirtual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquinaVirtual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquinaVirtualExists(maquinaVirtual.Id))
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
            return View(maquinaVirtual);
        }

        // GET: MaquinaVirtual/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maquinaVirtual = await _context.MaquinaVirtual
                .SingleOrDefaultAsync(m => m.Id == id);
            if (maquinaVirtual == null)
            {
                return NotFound();
            }

            return View(maquinaVirtual);
        }

        // POST: MaquinaVirtual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maquinaVirtual = await _context.MaquinaVirtual.SingleOrDefaultAsync(m => m.Id == id);
            _context.MaquinaVirtual.Remove(maquinaVirtual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaquinaVirtualExists(int id)
        {
            return _context.MaquinaVirtual.Any(e => e.Id == id);
        }
    }
}
