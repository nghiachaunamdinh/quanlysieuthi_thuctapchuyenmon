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
    public class DonViTinhsController : Controller
    {
        private readonly EShopDBContext _context;

        public DonViTinhsController(EShopDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/DonViTinhs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DonViTinhs.ToListAsync());
        }

        // GET: Administrator/DonViTinhs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs
                .FirstOrDefaultAsync(m => m.MaDVT == id);
            if (donViTinh == null)
            {
                return NotFound();
            }

            return View(donViTinh);
        }

        // GET: Administrator/DonViTinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/DonViTinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaDVT,Ten")] DonViTinh donViTinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donViTinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donViTinh);
        }

        // GET: Administrator/DonViTinhs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs.FindAsync(id);
            if (donViTinh == null)
            {
                return NotFound();
            }
            return View(donViTinh);
        }

        // POST: Administrator/DonViTinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaDVT,Ten")] DonViTinh donViTinh)
        {
            if (id != donViTinh.MaDVT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donViTinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonViTinhExists(donViTinh.MaDVT))
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
            return View(donViTinh);
        }

        // GET: Administrator/DonViTinhs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donViTinh = await _context.DonViTinhs
                .FirstOrDefaultAsync(m => m.MaDVT == id);
            if (donViTinh == null)
            {
                return NotFound();
            }

            return View(donViTinh);
        }

        // POST: Administrator/DonViTinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var donViTinh = await _context.DonViTinhs.FindAsync(id);
            _context.DonViTinhs.Remove(donViTinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonViTinhExists(string id)
        {
            return _context.DonViTinhs.Any(e => e.MaDVT == id);
        }
    }
}
