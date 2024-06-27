using ExamWeb_VuHoangNam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_VuHoangNam.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var dsPhim = _db.Phims.ToList();
            var tongsoluong = _db.Phims.Sum(x => x.Id);
            var max = _db.Phims.Max(x => x.GiaVe);
            ViewBag.max = max;
            ViewBag.SUM = tongsoluong;
            return View(dsPhim);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã thêm 1 phim thành công";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Update(int id)
        {
            //var book = _db.Books.Find(id);
            var phim = _db.Phims.SingleOrDefault(x => x.Id == id);
            if (phim != null)
                return View(phim);

            return NotFound();
        }
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Đã cập nhật 1 phim thành công";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Delete(int id)
        {
            var product = _db.Phims.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Xử lý xóa sản phẩm
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _db.Phims.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            // xoá hình cũ của sản phẩm
            // xoa san pham khoi CSDL
            _db.Phims.Remove(product);
            _db.SaveChanges();
            TempData["success"] = "Product deleted success";
            //chuyen den action index
            return RedirectToAction("Index");
        }
    }
}
