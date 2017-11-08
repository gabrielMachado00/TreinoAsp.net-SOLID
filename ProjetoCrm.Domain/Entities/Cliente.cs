using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Domain.Entities
{
   public  class Cliente
    {

        [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        public string nm_cliente { get; set; }

        public int cnpj { get; set; }

        public int cpf { get; set; }
            
        public int telefone { get; set; }

        public string endereco { get; set; }

        public string estado { get; set; }

        public int cep { get; set; }

        public ICollection<Vendas>ListaVendas { get; set; }
    }
}
