using EPharma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPharma.Interface
{
    public interface IPlan
    {
        void InsertPlan(Plans plan);

        void UpdatePlan(int id, Plans plan);

        List<Plans> GetPlansAll();

        Plans GetUnique(int id);

    }
}
