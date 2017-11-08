using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Domain.Entities
{
   public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }

   
        public ICollection<Produto> ListaProdutos { get; set; }

    public int qtd_estoque { get; set; }
     
}
}
