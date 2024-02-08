using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using DataAccessLayer;

namespace DoctorsList.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctors obj;
        private readonly string tableconnect;
        public DoctorController(IDoctors Obj,IConfiguration service)
        {
            obj = Obj;
            tableconnect = service.GetConnectionString("DbConnection");
        }
        // GET: DoctorController
        public ActionResult Index()
        {
            var getall = obj.Getall();
            return View("List", getall);
           
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(long id)
        {
            var getIDdetails = obj.GetById(id);
            return View ("Details", getIDdetails);
        }

        // GET: DoctorController/Create
        public ActionResult Create(long?id)
        {
            if (id.HasValue)
            {

                var Doctors = obj.GetById(id.Value);

                return View("Update", Doctors);
            }
            else
            {
                return View("Create", new Doctor());
            }
        }

        // POST: DoctorController/Create
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Creates(Doctor details)
        {
            try
            {
                if (details.DoctorID == 0)
                {
                    obj.Insert(details);
                }
                else
                {
                    obj.Update(details, details.DoctorID);
                }

                return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Deletes(long id)
        {
            try
            {
                obj.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
