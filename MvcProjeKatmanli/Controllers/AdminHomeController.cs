using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcProjeKatmanli.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        // 1) Toplam kategori sayısı ++
        //2) Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
        //3) Yazar adında 'a' harfi geçen yazar sayısı ++
        //4) En fazla başlığa sahip kategori adı 
        //5) Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
        public ActionResult Index()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryDal());
           
            WriterManager wm = new WriterManager(new EfWriterDal());

            int categorycount = cm.GetList().Count;
            int writercount = wm.GetList().Count(x => x.WriterName.Contains("a"));

            ViewBag.Writer = writercount;
        
            ViewBag.Message = categorycount;

            return View();
        }
    }
}