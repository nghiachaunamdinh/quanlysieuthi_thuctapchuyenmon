using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLySieuThi.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using QuanLySieuThi.Models.Entities;
using QuanLySieuThi.Models.EF;
using Newtonsoft.Json;

namespace QuanLySieuThi.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
       // private readonly IConfiguration configuration;
        public EShopDBContext Context { get; }
       

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
                return RedirectToAction("Index", "Home");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu !";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.mhbanchay = Context.MatHangs.OrderByDescending(x => x.SoLuongBan).Take(3).ToList();
            ViewBag.mhnew = Context.MatHangs.OrderByDescending(x => x.NgayNhap).Take(6).ToList();
            return View();
        }
        public ActionResult Mathang()
        {
            ViewBag.mh = Context.MatHangs.OrderByDescending(x => x.NgayNhap).Take(100).ToList();
            return View();
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
