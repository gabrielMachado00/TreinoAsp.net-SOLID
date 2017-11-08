using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.EntityConfig
{
   public class FuncionarioConfig:EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(f => f.FuncionarioId);
            Property(f => f.nome).IsRequired().HasMaxLength(150);
            Property(f => f.email).IsRequired();
            Property(f => f.cargo).IsRequired();
            Property(f => f.cpf).IsRequired();
        }
    }
}
