using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.EntityConfig
{
    public class ProdutoConfig:EntityTypeConfiguration<Produto>
    {

        public ProdutoConfig()
        {
            HasKey(p => p.ProdutoId);
            Property(p => p.nome).IsRequired().HasMaxLength(150);
            Property(p => p.preco).IsRequired();
            Property(p => p.preco).IsRequired();


            HasRequired(p => p.estoque).WithMany(p => p.ListaProdutos).Map(p => p.MapKey("EstoqueId"));

            HasMany(p => p.ListaVendas).WithMany(p => p.ListaProdutos).Map(p =>
            {
                p.MapLeftKey("ProdutoId");
                p.MapRightKey("VendaId");
                p.ToTable("ProdutoVenda");


            });
            
            }

    }
}
