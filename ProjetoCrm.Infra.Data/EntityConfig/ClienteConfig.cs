using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.EntityConfig
{
    public class ClienteConfig:EntityTypeConfiguration<Cliente>
    {

        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            Property(c => c.nm_cliente).IsRequired().HasMaxLength(150);
            Property(c => c.endereco).IsRequired();
            Property(c => c.cpf);
            Property(c => c.cnpj);
            Property(c => c.cep).IsRequired();
            Property(c => c.estado).IsRequired();
            Property(c => c.telefone).IsRequired();



           




    }
    }
}
