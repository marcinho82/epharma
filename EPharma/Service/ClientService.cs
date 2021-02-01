using EPharma.Context;
using EPharma.Interface;
using EPharma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Service
{
    public class ClientService : IClient
    {
        private readonly PharmaContext _pharmaContext;

        public ClientService(PharmaContext pharmaContext)
        {
            _pharmaContext = pharmaContext;
        }

        public List<Clients> GetClientsAll()
        {
            return _pharmaContext.Clients.ToList();
        }

        public Clients GetUnique(int id)
        {
            return (Clients)_pharmaContext.Clients.Select(x => x.idCliente == id);
        }

        public void InsertClient(Clients clients)
        {
            _pharmaContext.Clients.Add(clients);
            _pharmaContext.SaveChanges();
        }

        public void UpdateClient(int id, Clients clients)
        {
            _pharmaContext.Clients.Update(clients);
            _pharmaContext.SaveChanges();
        }
    }
}
