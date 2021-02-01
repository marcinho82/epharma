using EPharma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Interface
{
    public interface IClient
    {
        void InsertClient(Clients clients);

        void UpdateClient(int id,Clients clients);

        List<Clients> GetClientsAll();

        Clients GetUnique(int id);

    }
}
