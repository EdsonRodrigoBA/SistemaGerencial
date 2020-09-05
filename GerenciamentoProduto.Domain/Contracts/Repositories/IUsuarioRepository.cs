﻿using GerenciamentoProduto.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProduto.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuarios>
    {
        Usuarios GetUser(String email);
    }
}
