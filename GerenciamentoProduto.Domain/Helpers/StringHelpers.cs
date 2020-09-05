using System;
using System.Security.Cryptography;
using System.Text;

namespace GerenciamentoProduto.Domain.Helpers
{
    public static class StringHelpers
    {

        public static String Encrypt(this String senha)
        {
            var salt = "FA9F644787B84F58B563C4BD9D4DFF96|51276D49BA914956A1A8F51EDC16AD32";
            var arrayBytes = Encoding.UTF8.GetBytes(senha + salt);
            byte[] hash;
            using (var sha = SHA512.Create())
            {
                hash = sha.ComputeHash(arrayBytes);
            }

            return Convert.ToBase64String(hash);
        }
    }
}
