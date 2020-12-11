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

        List<Client> GetClients();
        List<Client> SearchClient(string searchTerm);
        //Task<IEnumerable<Client>> GetClientById(int clientId);
        //Task<IEnumerable<Client>> Search(int clientId); 

        //void Save(Dealer oDealer);
        //void Update(Dealer oDealer);
        //string Delete(int dealerId);
    }
}
