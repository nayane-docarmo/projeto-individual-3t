using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    interface IEquipamento
    {
        Equipamento Cadastrar(Equipamento e);
        List<Equipamento> LerTodos();
        Equipamento BuscarPorId(Guid id);
        Equipamento Alterar(Equipamento e);
        void Excluir(Guid id);
    }
}
