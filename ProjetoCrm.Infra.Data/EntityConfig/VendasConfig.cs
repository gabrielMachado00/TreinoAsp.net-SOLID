using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.EntityConfig
{
    public class VendasConfig: EntityTypeConfiguration<Vendas> {

        public VendasConfig()
        {

            HasKey(v => v.Id);
            Property(v => v.qtd_venda).IsRequired();

            HasRequired(v => v.funcionario).WithMany(v => v.ListaVendas).Map(v => v.MapKey("FuncionarioId"));
            HasRequired(v => v.cliente).WithMany(v => v.ListaVendas).Map(v => v.MapKey("ClienteId"));
        }
    }
}
