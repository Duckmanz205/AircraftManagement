using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyMayBay.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult TrangChuNgoai()
        {
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhapThanhCong(FormCollection form)
        {
            Session["UserName"] = form["email"];
            return RedirectToAction("TrangChu");
        }
        public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult LichSu()
        {
            return View();
        }
        public ActionResult TimKiem()
        {
            return View();
        }
        public ActionResult ChonCho()
        {
            return View();
        }
        public ActionResult ThanhToan()
        {
            return View();
        }

        public ActionResult CheckInNgoai()
        {
            return View();
        }
        public ActionResult Ve()
        {
            return View();
        }
        public ActionResult Temp()
        {
            return View();
        }

    }
}