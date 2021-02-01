using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPharma.Models
{
    [Table("ClientPlan")]
    public class ClientPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliPlan { get; set; }
        public int idCliente { get; set; }
        public int idPlan { get; set; }
    }
}
