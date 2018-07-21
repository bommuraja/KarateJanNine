using _1.DL_Context;
using _2.RepositoryLayer;
using BL_Karate;
using BL_Karate.DomainEntityMapper;
using KarateJanNine.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KarateJanNine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Settings()
        {

            return View();
        }
        public ActionResult PhotoGallery()
        {
            KarateDBContext context = new KarateDBContext();
            KarateRepository karateRepository = new KarateRepository(context);
            MapDomainEntity mapDomainEntity = new MapDomainEntity();
            BusinessLayer businessLayer = new BusinessLayer(karateRepository, mapDomainEntity);
            PhotoDetailsVM PhotoDetailsVM = new PhotoDetailsVM(businessLayer);
            var details = PhotoDetailsVM.GetPhotoDetailsVM();
            return View();
        }

        public ActionResult PhotoGalleryGridSettings()
        {
            KarateDBContext context = new KarateDBContext();
            KarateRepository karateRepository = new KarateRepository(context);
            MapDomainEntity mapDomainEntity = new MapDomainEntity();
            BusinessLayer businessLayer = new BusinessLayer(karateRepository, mapDomainEntity);
            PhotoDetailsVM PhotoDetailsVM = new PhotoDetailsVM(businessLayer);
            var details = PhotoDetailsVM.GetPhotoDetailsVM();
            return View(details);
        }

        public ActionResult GetPhotoGalleryGridSettings()
        {
            KarateDBContext context = new KarateDBContext();
            KarateRepository karateRepository = new KarateRepository(context);
            MapDomainEntity mapDomainEntity = new MapDomainEntity();
            BusinessLayer businessLayer = new BusinessLayer(karateRepository, mapDomainEntity);
            PhotoDetailsVM PhotoDetailsVM = new PhotoDetailsVM(businessLayer);
            var details = PhotoDetailsVM.GetPhotoDetailsVM();
            return Json(details, JsonRequestBehavior.AllowGet);
        }
      

        public ActionResult GridSettings() 
        {
            KarateDBContext context = new KarateDBContext();
            KarateRepository karateRepository = new KarateRepository(context);
            MapDomainEntity mapDomainEntity = new MapDomainEntity();
            BusinessLayer businessLayer = new BusinessLayer(karateRepository, mapDomainEntity);
            PhotoDetailsVM PhotoDetailsVM = new PhotoDetailsVM(businessLayer);
            var details = PhotoDetailsVM.GetPhotoDetailsVM();
            return View("Settings");
        }

    }
}
