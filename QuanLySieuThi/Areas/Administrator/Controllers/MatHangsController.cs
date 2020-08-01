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
    public class MatHangsController : Controller
    {
        private readonly EShopDBContext _context;

        public MatHangsController(EShopDBContext context)
        {
            _context = context;
        }

        // GET: Administrator/MatHangs
        public async Task<IActionResult> Index()
        {
            var eShopDBContext = _context.MatHangs.Include(m => m.DonViTinh).Include(m => m.LoaiHang);
            return View(await eShopDBContext.ToListAsync());
        }

        // GET: Administrator/MatHangs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHangs
                .Include(m => m.DonViTinh)
                .Include(m => m.LoaiHang)
                .FirstOrDefaultAsync(m => m.MaMH == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // GET: Administrator/MatHangs/Create
        public IActionResult Create()
        {
            ViewData["MaDVT"] = new SelectList(_context.DonViTinhs, "MaDVT", "MaDVT");
            ViewData["MaLH"] = new SelectList(_context.LoaiHangs, "MaLH", "MaLH");
            return View();
        }

        // POST: Administrator/MatHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaMH,Ten,MaLH,MaDVT,NgaySanXuat,SoLuongNhap,SoLuongBan,GiaBan,GiaMua,VAT,MoTa,NgayNhap,NgayHetHan,HinhMinhHoa")] MatHang matHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDVT"] = new SelectList(_context.DonViTinhs, "MaDVT", "MaDVT", matHang.MaDVT);
            ViewData["MaLH"] = new SelectList(_context.LoaiHangs, "MaLH", "MaLH", matHang.MaLH);
            return View(matHang);
        }

        // GET: Administrator/MatHangs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHangs.FindAsync(id);
            if (matHang == null)
            {
                return NotFound();
            }
            ViewData["MaDVT"] = new SelectList(_context.DonViTinhs, "MaDVT", "MaDVT", matHang.MaDVT);
            ViewData["MaLH"] = new SelectList(_context.LoaiHangs, "MaLH", "MaLH", matHang.MaLH);
            return View(matHang);
        }

        // POST: Administrator/MatHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaMH,Ten,MaLH,MaDVT,NgaySanXuat,SoLuongNhap,SoLuongBan,GiaBan,GiaMua,VAT,MoTa,NgayNhap,NgayHetHan,HinhMinhHoa")] MatHang matHang)
        {
            if (id != matHang.MaMH)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatHangExists(matHang.MaMH))
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
            ViewData["MaDVT"] = new SelectList(_context.DonViTinhs, "MaDVT", "MaDVT", matHang.MaDVT);
            ViewData["MaLH"] = new SelectList(_context.LoaiHangs, "MaLH", "MaLH", matHang.MaLH);
            return View(matHang);
        }

        // GET: Administrator/MatHangs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matHang = await _context.MatHangs
                .Include(m => m.DonViTinh)
                .Include(m => m.LoaiHang)
                .FirstOrDefaultAsync(m => m.MaMH == id);
            if (matHang == null)
            {
                return NotFound();
            }

            return View(matHang);
        }

        // POST: Administrator/MatHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var matHang = await _context.MatHangs.FindAsync(id);
            _context.MatHangs.Remove(matHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatHangExists(string id)
        {
            return _context.MatHangs.Any(e => e.MaMH == id);
        }
    }
}
