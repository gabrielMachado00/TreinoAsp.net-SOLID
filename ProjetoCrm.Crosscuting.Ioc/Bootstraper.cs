using ProjetoCrm.Domain.Interface.Repository;
using ProjetoCrm.Infra.CrossCutting.Identity.Configuration;
using ProjetoCrm.Infra.CrossCutting.Identity.Context;
using ProjetoCrm.Infra.CrossCutting.Identity.Model;
using EP.IdentityIsolation.Infra.Data.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using ProjetoCrm.Infra.Data.Interface;
using ProjetoCrm.Infra.Data.Repository;
using ProjetoCrm.Infra.Data.IServiceBase;
using ProjetoCrm.Infra.Data.ServiceBase;
using ProjetoCrm.Infra.Data.Context;

namespace EP.IdentityIsolation.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {

 
            container.Register<ApplicationDbContext>(Lifestyle.Scoped);
            container.Register<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.Register<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.Register<ApplicationRoleManager>(Lifestyle.Scoped);
            container.Register<ApplicationUserManager>(Lifestyle.Scoped);
            container.Register<ApplicationSignInManager>(Lifestyle.Scoped);


            container.Register<IdentityIsolationContext>(Lifestyle.Scoped);
            container.Register(typeof(IRepositorioBase<>),typeof(RepositorioBase<>),Lifestyle.Scoped);
            container.Register<IClienteRepositorio, ClienteRepositorio>(Lifestyle.Scoped);         
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IEstoqueRepositorio, EstoqueRepositorio>(Lifestyle.Scoped);
            container.Register<IFuncionarioRepositorio, FuncionarioRepositorio>(Lifestyle.Scoped);
            container.Register<IProdutoRepositorio, ProdutoRepositorio>();
            container.Register<IVendasRepositorio, VendasRepositorio>();

            container.Register(typeof(IRepositorioService<>), typeof(RepositorioService<>),Lifestyle.Scoped);
            container.Register<IClienteService, ClienteService>();
            container.Register<IEstoqueService, EstoqueService>();
            container.Register<IFuncionarioService, FuncionarioService>();
            container.Register<IProdutoService, ProdutoService>();
            container.Register<IVendasService, VendasService>();

            



        } 


    }
}