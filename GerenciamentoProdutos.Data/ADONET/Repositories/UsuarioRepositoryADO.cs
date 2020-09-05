using GerenciamentoProduto.Domain.Contracts.Repositories;
using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProdutos.Data.ADONET.Repositories
{
    public class UsuarioRepositoryADO : IUsuarioRepository
    {

        private readonly GerencimanetoProdutoDataContextADO _gerencimanetoProdutoDataContextADO;
        public UsuarioRepositoryADO(GerencimanetoProdutoDataContextADO gerencimanetoProdutoDataContextADO)
        {
            _gerencimanetoProdutoDataContextADO = gerencimanetoProdutoDataContextADO;
        }
        public Usuarios GetUser(string email)
        {
            try
            {


                var query = $@"SELECT * FROM USUARIOS WHERE EMAIL = '{email}'";

                var dataRead = _gerencimanetoProdutoDataContextADO.ExecutCommand_Query(query);
                if (dataRead.HasRows)
                {
                    var usuarios = new List<Usuarios>();
                    while (dataRead.Read())
                    {
                        Usuarios usuario = new Usuarios();

                        usuario.Id = Convert.ToInt32(dataRead["Id"]);
                        usuario.usuario = Convert.ToString(dataRead["usuario"]);
                        usuario.email = Convert.ToString(dataRead["email"]);
                        usuario.senha = Convert.ToString(dataRead["senha"]);
                        usuario.dtCadastro = Convert.ToDateTime(dataRead["dtCadastro"]);
                        usuarios.Add(usuario);

                    }
                    dataRead.Close();
                  
                    return usuarios.First();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return null;
        }
        public void Dispose()
        {

        }

        public void Add(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuarios entity)
        {
            throw new NotImplementedException();
        }



        public void Edit(Usuarios entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuarios> Get()
        {
            throw new NotImplementedException();
        }





        public Usuarios Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
