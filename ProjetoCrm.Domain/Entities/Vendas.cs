using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Domain.Entities
{
    public class Vendas
    {
        [Key]
        public int Id{ get; set; }

        public ICollection<Produto>ListaProdutos { get; set; }

        public Funcionario funcionario { get; set; }

        public int qtd_venda { get; set; }
        public Cliente cliente { get; set; }
        public DateTime dt_venda { get; set; }

    }
}
