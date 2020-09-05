using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProdutos.Data.ADONET.Repositories;
using GerenciamentoProdutos.Data.EF;
using GerenciamentoProdutos.Data.EF.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace GerenciamentoProdutos.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<GerenciamentoProdutoDataContextEF>();
            container.RegisterType<IProdutoRepository, ProdutoRepositoryEF>();
            container.RegisterType<ITipoProdutoRepository, TipoProdutoRepositoryEF>();
            //container.RegisterType<IUsuarioRepository, UsuarioRepositoryEF>();
            container.RegisterType<IUsuarioRepository, UsuarioRepositoryADO>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}