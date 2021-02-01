using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPharma.Models
{
    [Table("Clients")]
    public class Clients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }
        public string nome { get; set; }
        public string cpfCnpj { get; set; }
        public string rg { get; set; }
        public DateTime dtNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime dtCadastro { get; set; }
        public List<ClientPlan> ClientPlans { get; set; }

    }
}
