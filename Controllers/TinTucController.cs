using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using PagedList;
using PagedList.Mvc;
using System.Xml;
using System.ServiceModel.Syndication;

namespace WebApplication1.Controllers
{
    public class TinTucController : Controller
    {
        dbTinTucDataContext data = new dbTinTucDataContext();
        // GET: TinTuc
        public ActionResult Index()
        {
            var tinmoi = Laytinmoi(10);
            return View(tinmoi);
        }             
           
        public ActionResult Banner()
        {
            var qc = (from qcao in data.QuangCaos
                      where qcao.ViTri == 1
                      select qcao).OrderBy(a => a.QuangCaoID).Take(1).ToList();
            return PartialView(qc.Single());
        }
        public ActionResult Bannerleft()
        {
            var qc = (from qcao in data.QuangCaos
                      where qcao.ViTri == 3
                      select qcao).OrderBy(a => a.QuangCaoID).Take(1).ToList();
            return PartialView(qc.Single());
        }
        public ActionResult Bannerright()
        {
            var qc = (from qcao in data.QuangCaos
                      where qcao.ViTri == 4
                      select qcao).OrderBy(a => a.QuangCaoID).Take(1).ToList();
            return PartialView(qc.Single());
        }

        public ActionResult HinhAnh()
        {
            var hinh = (from ha in data.HinhAnhs
                        select ha).OrderByDescending(a => a.HinhAnhID).Take(6).ToList();
            return PartialView(hinh);
        }
        public ActionResult Category()
        {
            var theloai = from tl in data.LoaiTins select tl;
            return PartialView(theloai);
        }
        public ActionResult Chitiettin(int id)
        {
            var ngay = from s in data.BangTins where s.BangTinID == id select s.NgayDang.ToLongDateString();
            ViewBag.NgayDang = ngay.First();
            var tin = from s in data.BangTins
                      where s.BangTinID == id
                      select s;
            return View(tin.Single());
        }
     

      }
}