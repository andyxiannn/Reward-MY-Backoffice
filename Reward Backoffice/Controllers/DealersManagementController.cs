using Microsoft.AspNetCore.Mvc;
using Reward_Backoffice.Data;
using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Controllers
{
    public class DealersManagementController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DealersManagementController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Dealer obj)
        {
            if (ModelState.IsValid)
            {
                _db.z3s1o_dealers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult Views(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.z3s1o_dealers.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Views(Dealer obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.z3s1o_dealers.Update(obj);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);

        //}

        //redirect to edit page
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.z3s1o_dealers.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //function to save post when edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Dealer obj)
        {
            if (ModelState.IsValid)
            {
                _db.z3s1o_dealers.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        public IActionResult Delete(int? id)
        {            
            var obj = _db.z3s1o_dealers.Find(id);
            if (obj == null)
            {
                //return Json(new { success = false, message = "Error while delete" });
                return RedirectToAction("Index");
            }

            _db.z3s1o_dealers.Remove(obj);
            _db.SaveChanges();
            return Json(new { success = true, Message = "Success!" }) ;
            //return RedirectToAction("Index");
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePost(int? id)
        //{
        //    var obj = _db.z3s1o_dealers.Find(id);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }

        //    _db.z3s1o_dealers.Remove(obj);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");

        //}
    }
}
