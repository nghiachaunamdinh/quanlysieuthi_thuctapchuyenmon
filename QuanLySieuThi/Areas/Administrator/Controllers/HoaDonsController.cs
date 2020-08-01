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
    public class HoaDonsController : Controller
    {
        private readonly EShopDBContext _context;

        public HoaDonsController(EShopDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/HoaDons
        public async Task<IActionResult> Index()
        {
            var eShopDBContext = _context.HoaDons.Include(h => h.KhachHang).Include(h => h.NhanVien);
            return View(await eShopDBContext.ToListAsync());
        }

        // GET: Administrator/HoaDons/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: Administrator/HoaDons/Create
        public IActionResult Create()
        {
            ViewData["MaKH"] = new SelectList(_context.KhachHangs, "MaKH", "MaKH");
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "MaNV");
            return View();
        }

        // POST: Administrator/HoaDons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,ThoiDiemLap,TongTienPhaiTra,MucGiam,MaNV,MaKH,DiemThuong")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKH"] = new SelectList(_context.KhachHangs, "MaKH", "MaKH", hoaDon.MaKH);
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "MaNV", hoaDon.MaNV);
            return View(hoaDon);
        }

        // GET: Administrator/HoaDons/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaKH"] = new SelectList(_context.KhachHangs, "MaKH", "MaKH", hoaDon.MaKH);
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "MaNV", hoaDon.MaNV);
            return View(hoaDon);
        }

        // POST: Administrator/HoaDons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHD,ThoiDiemLap,TongTienPhaiTra,MucGiam,MaNV,MaKH,DiemThuong")] HoaDon hoaDon)
        {
            if (id != hoaDon.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.MaHD))
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
            ViewData["MaKH"] = new SelectList(_context.KhachHangs, "MaKH", "MaKH", hoaDon.MaKH);
            ViewData["MaNV"] = new SelectList(_context.NhanViens, "MaNV", "MaNV", hoaDon.MaNV);
            return View(hoaDon);
        }

        // GET: Administrator/HoaDons/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: Administrator/HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hoaDon = await _context.HoaDons.FindAsync(id);
            _context.HoaDons.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(string id)
        {
            return _context.HoaDons.Any(e => e.MaHD == id);
        }
    }
}
