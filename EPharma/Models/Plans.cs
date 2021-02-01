using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPharma.Models
{
    [Table("Plans")]
    public class Plans
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPlan { get; set; }
        public string plan { get; set; }
        public DateTime dtInicioVigencia { get; set; }
        public DateTime dtFinalVigencia { get; set; }
        public string permitePessoaJuridica { get; set; }
        public DateTime dtCadastro { get; set; }

        public List<ClientPlan> ClientPlans { get; set; }
    }
}
