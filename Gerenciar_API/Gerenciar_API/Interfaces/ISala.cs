using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    interface ISala
    {
        Sala Cadastrar(Sala s);
        List<Sala> LerTodos();
        Sala BuscarPorId(Guid id);
        Sala Alterar(Sala s);
        void Excluir(Guid id);
    }
}
