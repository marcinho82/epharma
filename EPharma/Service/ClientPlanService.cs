using EPharma.Context;
using EPharma.Interface;
using EPharma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Service
{
    public class ClientPlanService : IClientPlan
    {
        private readonly PharmaContext _pharmaContext;

        public ClientPlanService(PharmaContext pharmaContext)
        {
            _pharmaContext = pharmaContext;
        }

        public void Insert(ClientPlan clientPlan )
        {
            throw new NotImplementedException();
        }

        public void Update(int id, ClientPlan clientPlan)
        {
            throw new NotImplementedException();
        }
    }
}
