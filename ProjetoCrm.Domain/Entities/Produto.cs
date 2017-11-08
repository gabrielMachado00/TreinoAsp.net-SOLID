using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Domain.Entities
{
   public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        public string nome { get; set; }

        public Estoque estoque { get; set; }

        public ICollection<Vendas>ListaVendas { get; set; }

        public Vendas venda { get; set; }

        public decimal preco { get; set; }

        public int qtd_estoque { get; set; }

    }
}
