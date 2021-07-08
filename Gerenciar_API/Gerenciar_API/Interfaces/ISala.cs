using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    public interface ISala
    {
        List<Sala> Listar();
        List<Sala> BuscarPorNome(string nome);
        Sala BuscarPorId(Guid id);
        void Cadastrar(Sala e);
        void Alterar(Sala e);
        void Excluir(Guid id);
    }
}
