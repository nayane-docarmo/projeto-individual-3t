using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> Listar();
        Usuario BuscarPorId(Guid id);
        void Cadastrar(Usuario e);
        void Alterar(Usuario e);
        void Excluir(Guid id);
    }
}
