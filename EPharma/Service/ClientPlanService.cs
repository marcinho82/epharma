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
            Error erro = new Error();
            Clients clients = (Clients)_pharmaContext.Clients.Select(x => x.idCliente == clientPlan.idCliente);
            Plans plan = (Plans)_pharmaContext.Plans.Select(x => x.idPlan == clientPlan.idPlan);
            if (plan.dtFinalVigencia < clients.dtCadastro)
            {

                erro.erro = "Não é permitido o relacionamento com um plano com vigência final menor que a data de vinculo";
                erro.status = false;
                
            }
            else if(plan.permitePessoaJuridica == "N" && clients.cpfCnpj.Length <= 14)
            {
                erro.erro = "Não é permitido pessoa jurídica para o plano escolhido";
                erro.status = false;
            }
            else
            {
                _pharmaContext.ClientPlans.Add(clientPlan);
                _pharmaContext.SaveChanges();
            }
        }
       
    }
}
