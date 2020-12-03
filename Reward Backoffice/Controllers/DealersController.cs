﻿using Microsoft.AspNetCore.Mvc;
using Reward_Backoffice.IService;
using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reward_Backoffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealersController : ControllerBase
    {
        IDealerService _dealerService = null;

        public DealersController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }
        // GET: api/<DealerController>
        [HttpGet]
        public IEnumerable<Dealer> GetDealers()
        {
            return _dealerService.GetDealers();
        }

        // GET api/<DealerController>/5
        [HttpGet("{id}")]
        public Dealer Get(int id)
        {
            return _dealerService.GetById(id) ;
        }

        // POST api/<DealerController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] Dealer dealer)
        {
            if (dealer.DealerId == 0) _dealerService.Save(dealer);
            else _dealerService.Update(dealer);
        }


        // DELETE api/<DealerController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {   
            return _dealerService.Delete(id);
        }
    }
}
