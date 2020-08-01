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
    public class LoaiHangsController : Controller
    {
        private readonly EShopDBContext _context;

        public LoaiHangsController(EShopDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/LoaiHangs
        public async Task<IActionResult> Index()
        {
            var eShopDBContext = _context.LoaiHangs.Include(l => l.ChungLoai);
            return View(await eShopDBContext.ToListAsync());
        }

        // GET: Administrator/LoaiHangs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiHang = await _context.LoaiHangs
                .Include(l => l.ChungLoai)
                .FirstOrDefaultAsync(m => m.MaLH == id);
            if (loaiHang == null)
            {
                return NotFound();
            }

            return View(loaiHang);
        }

        // GET: Administrator/LoaiHangs/Create
        public IActionResult Create()
        {
            ViewData["MaCL"] = new SelectList(_context.ChungLoais, "MaCL", "MaCL");
            return View();
        }

        // POST: Administrator/LoaiHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLH,Ten,MaCL")] LoaiHang loaiHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaCL"] = new SelectList(_context.ChungLoais, "MaCL", "MaCL", loaiHang.MaCL);
            return View(loaiHang);
        }

        // GET: Administrator/LoaiHangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiHang = await _context.LoaiHangs.FindAsync(id);
            if (loaiHang == null)
            {
                return NotFound();
            }
            ViewData["MaCL"] = new SelectList(_context.ChungLoais, "MaCL", "MaCL", loaiHang.MaCL);
            return View(loaiHang);
        }

        // POST: Administrator/LoaiHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaLH,Ten,MaCL")] LoaiHang loaiHang)
        {
            if (id != loaiHang.MaLH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiHangExists(loaiHang.MaLH))
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
            ViewData["MaCL"] = new SelectList(_context.ChungLoais, "MaCL", "MaCL", loaiHang.MaCL);
            return View(loaiHang);
        }

        // GET: Administrator/LoaiHangs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiHang = await _context.LoaiHangs
                .Include(l => l.ChungLoai)
                .FirstOrDefaultAsync(m => m.MaLH == id);
            if (loaiHang == null)
            {
                return NotFound();
            }

            return View(loaiHang);
        }

        // POST: Administrator/LoaiHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loaiHang = await _context.LoaiHangs.FindAsync(id);
            _context.LoaiHangs.Remove(loaiHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiHangExists(string id)
        {
            return _context.LoaiHangs.Any(e => e.MaLH == id);
        }
    }
}
