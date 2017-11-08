using System.Data.Entity;
using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.EntityConfig;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoCrm.Infra.Data.Context
{
    public class IdentityIsolationContext : DbContext
    {
        public IdentityIsolationContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Cliente>Clientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Estoque>Estoques{ get; set; }

        public DbSet<Funcionario>Funcionarios{ get; set; }

        public DbSet<Produto>Produtos{ get; set; }

        public DbSet<Vendas>Vendas{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //remove automaticamente os relacionamentos dependentes da exclusao
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new EstoqueConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new FuncionarioConfig());
            modelBuilder.Configurations.Add(new VendasConfig());

            base.OnModelCreating(modelBuilder);
        }

        
    
    }
}