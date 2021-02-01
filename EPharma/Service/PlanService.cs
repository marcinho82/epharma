using EPharma.Context;
using EPharma.Interface;
using EPharma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Service
{
    public class PlanService : IPlan
    {
        private readonly PharmaContext _pharmaContext;

        public PlanService(PharmaContext pharmaContext)
        {
            _pharmaContext = pharmaContext;
        }

        public List<Plans> GetPlansAll()
        {
            return _pharmaContext.Plans.ToList();
        }

        public Plans GetUnique(int id)
        {
            return (Plans)_pharmaContext.Plans.Select(x => x.idPlan == id);
        }

        public void InsertPlan(Plans plan)
        {
            _pharmaContext.Plans.Add(plan);
            _pharmaContext.SaveChanges();
        }

        public void UpdatePlan(int id, Plans plan)
        {
            _pharmaContext.Plans.Update(plan);
            _pharmaContext.SaveChanges();
        }
    }
}
