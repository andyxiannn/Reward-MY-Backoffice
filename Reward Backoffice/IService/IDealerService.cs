using Reward_Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.IService
{
    public interface IDealerService
    {
        List<Dealer> GetDealers();

        Dealer GetById(int dealerId);
        void Save(Dealer oDealer);
        void Update(Dealer oDealer);
        string Delete(int dealerId);
    }
}
