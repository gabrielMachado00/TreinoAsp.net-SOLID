using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.EntityConfig
{
    public class EstoqueConfig:EntityTypeConfiguration<Estoque>
    {

        public EstoqueConfig()
        {
            HasKey(e => e.EstoqueId);

            Property(e => e.qtd_estoque).IsRequired();
        }
    }
}
