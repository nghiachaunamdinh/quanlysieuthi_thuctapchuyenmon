using Microsoft.AspNetCore.Mvc;
using QuanLySieuThi.Models;
using QuanLySieuThi.Models.EF;
using QuanLySieuThi.Models.Entities;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Korzh.EasyQuery.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace QuanLySieuThi.Controllers
{
    public class HomeController : Controller
    {
        
        public EShopDBContext Context { get; set; }


        public HomeController(EShopDBContext _context)
        {
            this.Context = _context;
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            TempData["username"] = "Chưa đăng nhập";
            KhachHang user = Context.KhachHangs.SingleOrDefault(x => x.Ten == username && x.MaKH == password);
            if (user != null)
            {
                ViewBag.MaNV = user.MaKH;
                TempData["username"] = user.Ten;
                TempData["Anh"] = user.Anh;



                return RedirectToAction("Index", "Home");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu !";
            return View();
        }
        
        public IActionResult Index()
        {

            ViewBag.mhbanchay = Context.MatHangs.OrderByDescending(x => x.SoLuongBan).Take(3).ToList();
            ViewBag.mhnew = Context.MatHangs.OrderByDescending(x => x.NgayNhap).Take(6).ToList();
            var display = Context.MatHangs.ToList();
            return View(display);
        }

        [HttpGet]
        public IActionResult Index(string Empsearch)
        {
            ViewBag.mhbanchay = Context.MatHangs.OrderByDescending(x => x.SoLuongBan).Take(3).ToList();
            ViewBag.mhnew = Context.MatHangs.OrderByDescending(x => x.NgayNhap).Take(6).ToList();
            ViewData["Data"] = Empsearch;
            var emquyre = from x in Context.MatHangs select x;
            if (!string.IsNullOrEmpty(Empsearch))
            {
                emquyre = emquyre.Where(x => x.MaMH.Contains(Empsearch) || x.Ten.Contains(Empsearch));
            }
            ViewBag.mhtimkiem = emquyre.AsNoTracking().ToList();
            return View(emquyre.AsNoTracking().ToList());
        }
        public ActionResult Mathang(int? page)
        {
            // 1. Tham số int? dùng để thể hiện null và kiểu int
            // page có thể có giá trị là null và kiểu int.

            // 2. Nếu page = null thì đặt lại là 1.
            if (page == null) page = 1;

            // 3. Tạo truy vấn, lưu ý phải sắp xếp theo trường nào đó, ví dụ OrderBy
            // theo LinkID mới có thể phân trang.
            var links = (from l in Context.MatHangs
                         select l).OrderBy(x => x.MaMH);

            // 4. Tạo kích thước trang (pageSize) hay là số Link hiển thị trên 1 trang
            int pageSize = 4;

            // 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            // nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            int pageNumber = (page ?? 1);

            // 5. Trả về các Link được phân trang theo kích thước và số trang.
            return View(links.ToPagedList(pageNumber, pageSize));

            //ViewBag.mh = Context.MatHangs.OrderByDescending(x => x.NgayNhap).Take(100).ToList();
            //return View();
        }
        public ActionResult Mathanghot()
        {
            ViewBag.mhbanchay = Context.MatHangs.OrderByDescending(x => x.SoLuongBan).Take(5).ToList();
            return View();
        }
        public ActionResult Dangky()
        {
            return View();
        }
        public ActionResult Detailes(string ma)
        {

            //timf kieen mh co ma la ma
            MatHang mh = Context.MatHangs.SingleOrDefault(x => x.MaMH == ma);
            if (mh == null)
            {
                return Content("Sản phẩm đã hết");
            }
            return View(mh);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
