using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLySieuThi.Models.EF;
using QuanLySieuThi.Models.Entities;

namespace QuanLySieuThi.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class ChungLoaisController : Controller
    {
        private readonly EShopDBContext _context;

        public ChungLoaisController(EShopDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/ChungLoais
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChungLoais.ToListAsync());
        }

        // GET: Administrator/ChungLoais/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chungLoai = await _context.ChungLoais
                .FirstOrDefaultAsync(m => m.MaCL == id);
            if (chungLoai == null)
            {
                return NotFound();
            }

            return View(chungLoai);
        }

        // GET: Administrator/ChungLoais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/ChungLoais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaCL,Ten")] ChungLoai chungLoai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chungLoai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chungLoai);
        }

        // GET: Administrator/ChungLoais/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chungLoai = await _context.ChungLoais.FindAsync(id);
            if (chungLoai == null)
            {
                return NotFound();
            }
            return View(chungLoai);
        }

        // POST: Administrator/ChungLoais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaCL,Ten")] ChungLoai chungLoai)
        {
            if (id != chungLoai.MaCL)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chungLoai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChungLoaiExists(chungLoai.MaCL))
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
            return View(chungLoai);
        }

        // GET: Administrator/ChungLoais/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chungLoai = await _context.ChungLoais
                .FirstOrDefaultAsync(m => m.MaCL == id);
            if (chungLoai == null)
            {
                return NotFound();
            }

            return View(chungLoai);
        }

        // POST: Administrator/ChungLoais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chungLoai = await _context.ChungLoais.FindAsync(id);
            _context.ChungLoais.Remove(chungLoai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChungLoaiExists(string id)
        {
            return _context.ChungLoais.Any(e => e.MaCL == id);
        }
    }
}
