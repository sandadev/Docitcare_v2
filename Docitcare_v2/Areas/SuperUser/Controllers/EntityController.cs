using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Docitcare_v2.Core;
using Docitcare_v2.Core.Domain;

namespace Docitcare_v2.Areas.SuperUser.Controllers
{
    public class EntityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EntityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: SuperUser/Entity
        //test the test branch
        public ActionResult Index()
        {
           // _unitOfWork.Entities.GetAll();
            return View();
        }

        // GET: SuperUser/Entity/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperUser/Entity/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperUser/Entity/Create
       //[Authorize(Roles = ("Admin,Editor"))]
        [HttpPost]
        public ActionResult Create(Entity entity)
        {
            try
            {
                // TODO: Add insert logic here
                _unitOfWork.Entities.Add(entity);
                _unitOfWork.Complete();
                //if (entity.EntityId > 0)
                //{ 
                   
                //}
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperUser/Entity/Edit/5
        public ActionResult Edit(int id)
        {
            //var result= _unitOfWork.Entities.Get(id);
            return View();
        }

        // POST: SuperUser/Entity/Edit/5
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

        // GET: SuperUser/Entity/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperUser/Entity/Delete/5
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

        [HttpGet]
        public JsonResult GetEntityList()
        {
            var result = _unitOfWork.Entities.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
