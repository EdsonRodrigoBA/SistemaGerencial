using GerenciamentoProduto.Domain.Contracts.Repositories;

using GerenciamentoProdutos.Data.EF.Repositories;
using GerenciamentoProdutos.UI.ViewModels.ProdutoViewModel;
using System.Web.Mvc;

namespace GerenciamentoProdutos.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {

        private readonly IProdutoRepository _produtoRepository;

        private readonly ITipoProdutoRepository _tipoProdutoRepository;

        public ProdutosController(IProdutoRepository produtoRepository, ITipoProdutoRepository tipoProdutoRepository)
        {
            _produtoRepository = produtoRepository;
            _tipoProdutoRepository = tipoProdutoRepository;
        }
     
        public ViewResult Index()
        {

            var produtos = _produtoRepository.Get().ToProdutoIndexVMs();


            return View(produtos);
        }
        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            ProdutoAddEditVM produto = new ProdutoAddEditVM();
            if (id != null)
            {
                produto = _produtoRepository.Get((int)id).ToProdutoAddEditVM();
            }
            var tipos = _tipoProdutoRepository.Get();
            ViewBag.tipos = tipos;
            return View(produto);
        }

     


        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoAddEditVM)
        {
            var produto = produtoAddEditVM.ToProduto();
            //produto.dtCadastro = DateTime.Now;
            if (ModelState.IsValid)
            {


                if (produto.Id == 0)
                {
                    _produtoRepository.Add(produto);
                }
                else
                {
                    _produtoRepository.Edit(produto);
                }


                return RedirectToAction("Index", "Produtos");
            }
            var tipos = _tipoProdutoRepository.Get();
            ViewBag.tipos = tipos;
            return View(produto);
        }

        public ActionResult DelProdu(int Id)
        {
            var produtos = _produtoRepository.Get((int)Id);
            if (produtos == null)
            {
                return HttpNotFound();
            }
            _produtoRepository.Delete(produtos);


            return null;
        }

        protected override void Dispose(bool disposing)
        {
            //_produtoRepository.Dispose();
            //_tipoProdutoRepository.Dispose();
        }
    }
}
