using Microsoft.EntityFrameworkCore;
using NinjaNye.SearchExtensions;
using Reward_Backoffice.Data;
using Reward_Backoffice.IService;
using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Service
{
    public class DealerService : IDealerService
    {
        private readonly ApplicationDbContext _context;

        public DealerService(ApplicationDbContext context)
        {
            _context = context;
        }
       
        public Dealer GetById(int DealerId)
        {
            return _context.z3s1o_dealers.SingleOrDefault(x=>x.DealerId == DealerId);
        }

        public List<Dealer> GetDealers()
        {
            return _context.z3s1o_dealers.ToList();
        }

        //public async Task<IEnumerable<Client>> GetClientById(int ClientId)
        //{
        //    IQueryable<Client> query = ApplicationDbContext.Client;

        //    if (ClientId != null)
        //    {
        //        query = query.Where(e => e.client_id == ClientId);
        //    }

        //    return await query.ToListAsync();

        //    //return _context.z3s1o_client.SingleOrDefault(x => x.client_id == ClientId);
        //}

        public List<Client> SearchClient(string searchTerm)
        {

            var result = _context.z3s1o_client.Search(x => x.client_id.ToString(),
                                  x => x.client_name,
                                  x => x.client_code,
                                  x => x.IC,
                                  x=> x.passport)
                          .Containing(searchTerm).ToList();

            return result;
            //return _context.z3s1o_client
            //    .Where(a =>
            //        a.client_id == nameSubstring).ToList();
        }

        public List<Client> GetClients()
        {
            return _context.z3s1o_client.ToList();
        }


        //public string Delete(int dealerId)
        //{
        //    var dealer = _context.z3s1o_Dealers.FirstOrDefault(x=>x.DealerId == dealerId);
        //    if (dealer != null)
        //    {
        //        _context.z3s1o_Dealers.Remove(dealer);
        //        _context.SaveChanges();
        //    }
        //    return "Deleted";
        //}

        //public void Save(Dealer oDealer)
        //{
        //    _context.z3s1o_Dealers.Add(oDealer);
        //    _context.SaveChanges();
        //}

        //public void Update(Dealer oDealer)
        //{
        //    _context.z3s1o_Dealers.Update(oDealer);
        //    _context.SaveChanges();
        //}
    }
}
