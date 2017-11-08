using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Domain.Entities
{
    public class Funcionario
    {

        [Key]
        public int FuncionarioId{ get; set; }

        public string nome { get; set; }

        public string cargo { get; set; }

        public int cpf { get; set; }

        public string email { get; set; }

        public DateTime dt_admissao { get; set; }

        public ICollection<Vendas> ListaVendas{ get; set; }

        public DateTime dt_demissao { get; set; }

      
    }
}
