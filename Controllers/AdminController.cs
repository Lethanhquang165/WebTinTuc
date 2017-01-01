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
		   public ActionResult TinTuc(int ? page, BangTin tin)
        {
            int pageNum = (page ?? 1);
            int pageSize = 7;
            if (Session["Taikhoanadmin"] == null || Session["Taikhoanadmin"].ToString() == "")
            {
                return RedirectToAction("Login","Admin");
            }
            else
            {
                ViewBag.UN = Session["Username"];
                var ad = (from tt in db.BangTins
                          where tt.MaAdmin == (from admin in db.Admins where admin.AdminID.ToString() == Session["Username"].ToString() select admin.MaAdmin).First()
                          select tt).OrderByDescending(a => a.NgayDang).ToList();
                return View(ad.ToPagedList(pageNum, pageSize));
            }
        }

        public ActionResult Create()
        {
            ViewBag.LoaiTinID = new SelectList(db.LoaiTins.ToList().OrderBy(n => n.TenLoaiTin), "LoaiTinID", "TenLoaiTin");
            ViewBag.AdminID = new SelectList(db.Admins.ToList().OrderBy(n => n.AdminID), "MaAdmin", "AdminID");
            if (Session["Taikhoanadmin"] == null || Session["Taikhoanadmin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            else
                return View();
        }

        [HttpPost]
        [ValidateInput(false)]        
        public ActionResult Create(BangTin tin, HttpPostedFileBase fileupload, FormCollection collection)
        {
            var ad = from admin in db.Admins where admin.AdminID.ToString() == Session["Username"].ToString() select admin.MaAdmin;
            var td = collection["TieuDe"];
            var mt = collection["MoTa"];
            var nd = collection["Noidung"];
            var ng = collection["NgayDang"];
            ViewBag.LoaiTinID = new SelectList(db.LoaiTins.ToList().OrderBy(a => a.TenLoaiTin), "LoaiTinID", "TenLoaiTin");
            if (fileupload == null)
            {
                ViewData["Loi4"] = "Vui lòng chọn hình ảnh cho bảng tin";
            }
            else if (String.IsNullOrEmpty(td))
            {
                ViewData["Loi1"] = "Tiêu đề của bảng tin là gì vậy ?";
            }
            else if (String.IsNullOrEmpty(mt))
            {
                ViewData["Loi2"] = "Viết vài dòng mô tả cho bảng tin đi";
            }
            else if (String.IsNullOrEmpty(nd))
            {
                ViewData["Loi3"] = "Nội dung của bảng tin là gì ?";
            }
            else if (String.IsNullOrEmpty(ng))
            {
                ViewData["Loi5"] = "Ngày đăng của bảng tin này là hôm nay đó";
            }
            else
            {
                if (ModelState.IsValid)
                { 
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/HinhTin"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Message = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    tin.MaAdmin = ad.Single();
                    tin.AnhBiaTin = fileName;
                    db.BangTins.InsertOnSubmit(tin);
                    db.SubmitChanges();
                    return RedirectToAction("TinTuc");
                }
            }
            return this.Create();
        }
 public ActionResult Details(int id)
        {
            BangTin tin = db.BangTins.SingleOrDefault(n => n.BangTinID == id);
            ViewBag.BangTinID = tin.BangTinID;
            if(tin==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else if (Session["Taikhoanadmin"] == null || Session["Taikhoanadmin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            else
                return View(tin);
        }

        public ActionResult Edit(int id)
        {
            BangTin tin = db.BangTins.SingleOrDefault(n => n.BangTinID == id);
            ViewBag.LoaiTinID = new SelectList(db.LoaiTins.ToList().OrderBy(n => n.TenLoaiTin), "LoaiTinID", "TenLoaiTin", tin.LoaiTinID);
            ViewBag.AdminID = new SelectList(db.Admins.ToList().OrderBy(n => n.MaAdmin), "AdminID", "AdminID", tin.MaAdmin);
            if(tin==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            else if (Session["Taikhoanadmin"] == null || Session["Taikhoanadmin"].ToString() == "")
            {
                return RedirectToAction("Login", "Admin");
            }
            else
                return View(tin);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateInput(false)]
        public ActionResult ConfirmOnEdit(BangTin tin, int id, HttpPostedFileBase fileupload, FormCollection collection)
        {
            var tieude = collection["TieuDe"];
            var ngaydang = collection["NgayDang"];
            var mota = collection["MoTa"];
            var noidung = collection["NoiDung"];
            var anhbia = collection["AnhBiaTin"];
            tin = db.BangTins.SingleOrDefault(n => n.BangTinID == id);
            ViewBag.LoaiTinID = new SelectList(db.LoaiTins.ToList().OrderBy(n => n.TenLoaiTin), "LoaiTinID", "TenLoaiTin");
            ViewBag.AdminID = new SelectList(db.Admins.ToList().OrderBy(n => n.MaAdmin), "MaAdmin", "AdminID");
            if (String.IsNullOrEmpty(tieude))
            {
                @ViewData["Loi1"] = "Vui lòng cho biết tiêu đề của bảng tin";
            }
            else if (String.IsNullOrEmpty(ngaydang))
            {
                @ViewData["Loi2"] = "Vui lòng cho biết ngày đăng của bảng tin";
            }
            else if (String.IsNullOrEmpty(noidung))
            {
                @ViewData["Loi3"] = "Vui lòng cho biết nội dung của bảng tin";
            }
            else if (String.IsNullOrEmpty(mota))
            {
                @ViewData["Loi4"] = "Vui lòng cho biết mô tả của bảng tin";
            }
            else if (fileupload == null)
            {
                tin = db.BangTins.SingleOrDefault(n => n.BangTinID == id);
                tin.TieuDe = tieude;
                tin.NgayDang = DateTime.Parse(ngaydang);
                tin.MoTa = mota;
                tin.NoiDung = noidung;
                UpdateModel(tin);
                db.SubmitChanges();
                return RedirectToAction("TinTuc");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/HinhTin"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.Message = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    tin = db.BangTins.SingleOrDefault(n => n.BangTinID == id);
                    tin.TieuDe = tieude;
                    tin.NgayDang = DateTime.Parse(ngaydang);
                    tin.MoTa = mota;
                    tin.NoiDung = noidung;
                    tin.AnhBiaTin = fileName;
                    UpdateModel(tin);
                    db.SubmitChanges();
                    return RedirectToAction("TinTuc");
                }
            }
            return this.Edit(id);
        }

      