
using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Helpers;
using GerenciamentoProdutos.UI.ViewModels.ContaViewModel;
using System;
using System.Web.Mvc;
using System.Web.Security;

namespace GerenciamentoProdutos.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        String teste;

        public ContaController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        // GET: Conta
        [HttpGet]
        public ActionResult Login(String ReturnUrl)
        {
            var model = new LoginVM() { ReturnUrl = ReturnUrl };
            if (!String.IsNullOrEmpty(ReturnUrl))
            {
                teste = ReturnUrl;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVM)
        {
            var usuario = _usuarioRepository.GetUser(loginVM.Email);
            if (usuario == null)
            {
                ModelState.AddModelError("Email", "E-mail não licalizado.");
            }
            else
            {
                if(usuario.senha != loginVM.Senha.Encrypt())
                {
                    ModelState.AddModelError("Senha", "Senha incorreta.");
                }
            }
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(loginVM.Email, loginVM.PermanecerLogado);
                if (!String.IsNullOrEmpty(teste))
                {
                    loginVM.ReturnUrl = teste;
                }

                if (!String.IsNullOrEmpty(loginVM.ReturnUrl) && Url.IsLocalUrl(loginVM.ReturnUrl))
                {
                    return Redirect(loginVM.ReturnUrl);
                }

                return RedirectToAction("Index", "Home");
            }
            return View(loginVM);
        }
        [HttpGet]
        public ActionResult Logout(String ReturnUrl)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        protected override void Dispose(bool disposing)
        {
            //_usuarioRepository.Dispose();
        }

    }
}