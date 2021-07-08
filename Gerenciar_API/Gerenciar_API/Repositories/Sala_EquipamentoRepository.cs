using API_Gerenciar.Context;
using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Repositories
{
    public class Sala_EquipamentoRepository : ISala_Equipamento
    {
        private readonly GerenciarContext _ctx;
        public Sala_EquipamentoRepository()
        {
            _ctx = new GerenciarContext(); 
        }
        public List<Sala_Equipamento> Listar()
        {
            try
            {
                return _ctx.Sala_Equipamentos.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Sala_Equipamento BuscarPorId(Guid id)
        {
            try
            {
                //return _ctx.Sala_Equipamentos.FirstOrDefault(c => c.Id == id);
                return _ctx.Sala_Equipamentos.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(Sala_Equipamento e)
        {
            try
            {
                _ctx.Sala_Equipamentos.Add(e);
                //Formas de adicionar o objeto
                //_ctx.Set<Sala_Equipamento>().Add(e);
                //_ctx.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Alterar(Sala_Equipamento e)
        {
            try
            {
                //Buscar a Sala_Equipamento por Id
                Sala_Equipamento salaEquiptemp = BuscarPorId(e.Id);

                //Verifica se a Sala_Equipamento existe
                //Caso não existe gera uma exception
                if (salaEquiptemp == null)
                    throw new Exception("Sala_Equipamento não encontrada");

                //Caso exista altera suas propriedades 
                salaEquiptemp.IdEquipamento     = e.IdEquipamento;
                salaEquiptemp.Equipamento       = e.Equipamento;
                salaEquiptemp.IdSala            = e.IdSala;
                salaEquiptemp.Sala              = e.Sala;
                salaEquiptemp.DataEntrada       = e.DataEntrada;
                salaEquiptemp.Descricao         = e.Descricao;
                salaEquiptemp.StatusG           = e.StatusG;
            
                //Altera a Sala no contexto 
                _ctx.Sala_Equipamentos.Update(salaEquiptemp);
                //Salva o contexto 
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Excluir(Guid id)
        {
            try
            {
                //Buscar a Sala por Id
                Sala_Equipamento salaEquiptemp = BuscarPorId(id);

                //Verifica se a Sala_Equipamento existe
                //Caso não existe gera uma exception
                if (salaEquiptemp == null)
                    throw new Exception("Sala_Equipamento não encontrado");

                _ctx.Sala_Equipamentos.Remove(salaEquiptemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
