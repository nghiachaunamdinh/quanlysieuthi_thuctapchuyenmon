using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySieuThi.Models.EF;
using QuanLySieuThi.Models.Entities;
using Microsoft.AspNetCore.Http;

namespace QuanLySieuThi.Areas.Administrator.Controllers
{
   

    

    [Area("Administrator")]
    public class HomeController : Controller
    {
        public EShopDBContext db { get; set; }
        public HomeController(EShopDBContext _context)
        {
            this.db = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            NhanVien user = db.NhanViens.SingleOrDefault(x => x.Username == username && x.Pwd == password && x.Allowed == 1);
            if (user != null)
            {
                TempData["MaNV"] = user.MaNV;
                TempData["username"] = user.Username;
                TempData["avatar"] = user.Avatar;
                return RedirectToAction("Index");
              
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu !";
            
            return View();
        }
    }
}