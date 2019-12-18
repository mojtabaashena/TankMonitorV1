using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TankMonitorV1.Models;

namespace TankMonitorV1.Controllers
{
    public class tblValuesController : Controller
    {
        private readonly DatabaseContext _context;

        public tblValuesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: tblValues
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblValues.ToListAsync());
        }

        // GET: tblValues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblValues = await _context.tblValues
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblValues == null)
            {
                return NotFound();
            }

            return View(tblValues);
        }

        // GET: tblValues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tblValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fldValParent,fldValCode,fldValName,fldValData,fldValDescrip,fldValEnable")] tblValues tblValues)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblValues);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblValues);
        }

        // GET: tblValues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblValues = await _context.tblValues.FindAsync(id);
            if (tblValues == null)
            {
                return NotFound();
            }
            return View(tblValues);
        }

        // POST: tblValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fldValParent,fldValCode,fldValName,fldValData,fldValDescrip,fldValEnable")] tblValues tblValues)
        {
            if (id != tblValues.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblValues);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblValuesExists(tblValues.Id))
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
            return View(tblValues);
        }

        // GET: tblValues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblValues = await _context.tblValues
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblValues == null)
            {
                return NotFound();
            }

            return View(tblValues);
        }

        // POST: tblValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblValues = await _context.tblValues.FindAsync(id);
            _context.tblValues.Remove(tblValues);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblValuesExists(int id)
        {
            return _context.tblValues.Any(e => e.Id == id);
        }
    }
}
