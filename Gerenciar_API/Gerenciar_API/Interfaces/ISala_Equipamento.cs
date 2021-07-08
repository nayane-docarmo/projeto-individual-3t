using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    interface ISala_Equipamento
    {
        List<Sala_Equipamento> Listar();
        Sala_Equipamento BuscarPorId(Guid id);
        void Cadastrar(Sala_Equipamento e);
        void Alterar(Sala_Equipamento e);
        void Excluir(Guid id);
    }
}
