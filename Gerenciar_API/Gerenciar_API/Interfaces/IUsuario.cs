using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    interface IUsuario
    {
        Usuario Cadastrar(Usuario u);
        List<Usuario> LerTodos();
        Usuario BuscarPorId(Guid id);
        Usuario Alterar(Usuario u);
        void Excluir(Guid id);
    }
}
