using Microsoft.AspNetCore.Mvc;
using NinjaNye.SearchExtensions;
using Reward_Backoffice.Data;
using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Views(int? id)
        {

            dynamic obj = new ExpandoObject();

            obj.searchclient = _db.z3s1o_client.Where(x => x.client_id.Equals(id)).Join(_db.z3s1o_branch,
                                                    x => x.branch_id,
                                                    b => b.branch_id,
                                                    (x, b) => new {
                                                        client_name = x.client_name,
                                                        IC = x.IC,
                                                        birthday = x.birthday,
                                                        client_code = x.client_code,
                                                        client_type = x.client_type,
                                                        passport = x.passport,
                                                        email = x.email,
                                                        status = x.status,
                                                        date_added = x.date_added,
                                                        branch_name = b.name
                                                    }).ToList();
           

            return View(obj);


            //if (id == null || id == 0)
            //{
            //    return NotFound();
            //}

            //var obj = _db.z3s1o_client.Find(id);

            //if (obj == null)  
            //{
            //    return NotFound();
            //}
            //var obj = _db.z3s1o_client
            //    .Where(a =>
            //       a.client_id == id);

            //return View(obj);
            //var result = _db.z3s1o_client.Search(x => x.client_id.ToString(),
            //                      x => x.client_name,
            //                      x => x.client_code,
            //                      x => x.IC,
            //                      x => x.passport)
            //              .Containing(id.ToString()).ToList();


            //var obj = (from c in _db.z3s1o_client
            //           join b in _db.z3s1o_branch
            //           on c.branch_id equals b.branch_id
            //           where c.client_id == id
            //           select new { c.client_name, b.name }).FirstOrDefault();
            // obj.client = _db.z3s1o_client.ToList();
            //obj.branch = _db.z3s1o_branch.ToList();




            //var obj = (from c in client
            //           where c.client_id == id
            //           select new { c.client_name }).FirstOrDefault();

            //var obj = ( from c in _db.z3s1o_client
            //            join b in _db.z3s1o_branch
            //            on c.branch_id equals b.branch_id
            //            where c.client_id == id
            //            select new{c.client_name, b.name }).FirstOrDefault();

            //var obj = _db.z3s1o_client.Where(x => x.client_id == id).Join(_db.z3s1o_branch,
            //            x => x.branch_id,
            //            b => b.branch_id,
            //            (x, b) => new  // result selector
            //            {
            //                client_name = x.client_name,
            //                branch_name = b.name
            //            }
            //    ).FirstOrDefault();
        }
    }
}
