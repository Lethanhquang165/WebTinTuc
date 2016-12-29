using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using PagedList;
using PagedList.Mvc;
using System.IO;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        dbTinTucDataContext db = new dbTinTucDataContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Logup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logup(FormCollection collection, Admin ad)
        {
            var hoten = collection["form-hoten"];
            var email = collection["form-email"];
            var sdt = collection["form-sdt"];
            var gioitinh = collection["form-gioitinh"];
            var tendn = collection["form-ID"];
            var pass = collection["form-password"];
            var repass = collection["form-repassword"];
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Vui lòng điền đầy đủ họ tên của bạn";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi2"] = "Vui lòng nhập địa chỉ mail của bạn";
            }
            else if (String.IsNullOrEmpty(sdt))
            {
                ViewData["Loi3"] = "Vui lòng nhập số điện thoại liên lạc của bạn";
            }
            else if (String.IsNullOrEmpty(gioitinh))
            {
                ViewData["Loi4"] = "Vui lòng nhập giới tính của bạn";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi5"] = "Vui lòng nhập tên để bạn đăng nhập";
            }
            else if (String.IsNullOrEmpty(pass))
            {
                ViewData["Loi6"] = "Vui lòng nhập mật khẩu";
            }
            else if (String.IsNullOrEmpty(repass))
            {
                ViewData["Loi8"] = "Vui lòng nhập lại mật khẩu vừa nhập";
            }
            else if (pass != repass)
            {
                ViewData["Loi7"] = "Mật khẩu nhập lai không trùng với mật khẩu vừa khai báo";
            }
            else
            {
                ad.HoTen = hoten;
                ad.Email = email;
                ad.SDT = int.Parse(sdt);
                ad.GioiTinh = gioitinh;
                ad.AdminID = tendn;
                ad.Password = pass;
                db.Admins.InsertOnSubmit(ad);
                db.SubmitChanges();
                return RedirectToAction("Login");
            }
            return this.Logup();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["form-username"];
            var matkhau = collection["form-password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Nhập tên đăng nhập nhé";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Nhập mật khẩu nhé";
            } 
            else
            {
                Admin ad = db.Admins.SingleOrDefault(n => n.AdminID == tendn && n.Password == matkhau);
                if(ad != null)
                {
                    Session["Username"] = collection["form-username"];
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            return View();
        }
		public ActionResult Logout()
        {
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Login","Admin");
        }
   public ActionResult Index(int? page)
        {

            if (Session["Taikhoanadmin"] == null || Session["Taikhoanadmin"].ToString() == "")
            {
                return RedirectToAction("Login","Admin");
            }
            else
            {
                int pageNum = (page ?? 1);
                int pageSize = 7;
                ViewBag.UN = Session["Username"];
                var ad = (from tin in db.BangTins where tin.MaAdmin == (from admin in db.Admins where admin.AdminID.ToString() == Session["Username"].ToString() select admin.MaAdmin).First() 
                          select tin).OrderByDescending(a => a.NgayDang).ToList();
                return View(ad.ToPagedList(pageNum, pageSize));
            }
        }

      