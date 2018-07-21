
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KarateJanNine.ViewModels;
using BL_Karate;
using _2.RepositoryLayer;
using BL_Karate.DomainEntityMapper;
using _1.DL_Context;

namespace KarateJanNine.Controllers
{
    public class PhotoGalleryController : Controller
    {
        //
        // GET: /PhotoGallery/ 
        public ActionResult Index()
        {
            KarateDBContext context = new KarateDBContext();
            KarateRepository karateRepository = new KarateRepository(context);
            MapDomainEntity mapDomainEntity = new MapDomainEntity();
            BusinessLayer businessLayer = new BusinessLayer(karateRepository, mapDomainEntity);
            PhotoDetailsVM PhotoDetailsVM = new PhotoDetailsVM(businessLayer);
            var details = PhotoDetailsVM.GetPhotoDetailsVM();
            return View();
        }

        //
        // GET: /PhotoGallery/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PhotoGallery/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PhotoGallery/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PhotoGallery/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PhotoGallery/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PhotoGallery/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PhotoGallery/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetAddPhotoGalleryView()
        {
            return PartialView("_addPhotoGallery");
        }
    }
}
