using Gerenciar_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Interfaces
{
    public interface IEquipamento
    {
        List<Equipamento> Listar();
        Equipamento BuscarPorId(Guid id);
        List<Equipamento> BuscarPorTipo(string tipo);
        void Cadastrar(Equipamento e);
        void Alterar(Equipamento e);
        void Excluir(Guid id);
    }
}
