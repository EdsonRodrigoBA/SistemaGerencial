using System;

using System.ComponentModel.DataAnnotations;


namespace GerenciamentoProdutos.UI.ViewModels.ContaViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        [StringLength(40, ErrorMessage = "Limite de caracteres excedidos")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "E-mail inválido")]
        public String Email { get; set; }


        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        [StringLength(40, ErrorMessage = "Limite da senha é 40 caracteres.")]
        public String Senha { get; set; }


        public bool PermanecerLogado { get; set; }

        public String ReturnUrl { get; set; }
    }
}