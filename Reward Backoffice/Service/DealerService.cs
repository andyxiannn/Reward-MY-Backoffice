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
        public string Delete(int dealerId)
        {
            var dealer = _context.z3s1o_Dealers.FirstOrDefault(x=>x.DealerId == dealerId);
            if (dealer != null)
            {
                _context.z3s1o_Dealers.Remove(dealer);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public Dealer GetById(int DealerId)
        {
            return _context.z3s1o_Dealers.SingleOrDefault(x=>x.DealerId == DealerId);
        }

        public List<Dealer> GetDealers()
        {
            return _context.z3s1o_Dealers.ToList();
        }

        public void Save(Dealer oDealer)
        {
            _context.z3s1o_Dealers.Add(oDealer);
            _context.SaveChanges();
        }

        public void Update(Dealer oDealer)
        {
            _context.z3s1o_Dealers.Update(oDealer);
            _context.SaveChanges();
        }
    }
}
