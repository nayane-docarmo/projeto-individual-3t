using API_Gerenciar.Context;
using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gerenciar_API.Repositories
{
    public class EquipamentoRepository : IEquipamento
    {
        private readonly GerenciarContext _ctx;

        public EquipamentoRepository()
        {
            _ctx = new GerenciarContext();
        }


        #region Leitura 
        /// <summary>
        /// Listar todos os equipamento
        /// </summary>
        /// <returns>Listagem dos Equipamentos</returns>
        public List<Equipamento> Listar()
        {
            try
            {
                return _ctx.Equipamentos.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Buscar o Equipamento por seu Id
        /// </summary>
        /// <param name="id">Id do Equipamento</param>
        /// <returns></returns>
        public Equipamento BuscarPorId(Guid id)
        {
            try
            {
                //return _ctx.Equipamentos.FirstOrDefault(c => c.Id == id);
                return _ctx.Equipamentos.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Buscar pelo 'Tipo do Equipamento
        /// </summary>
        /// <param name="tipo">Objeto dado para o Tipo do Equipamento </param>
        /// <returns></returns>
        public List<Equipamento> BuscarPorTipo(string tipo)
        {
            try
            {
                return _ctx.Equipamentos.Where(c => c.Tipo.Contains(tipo)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Gravação 
        /// <summary>
        /// Cadastra um novo equipamento
        /// </summary>
        /// <param name="e">Objeto do tipo Equipamento</param>
        public void Cadastrar(Equipamento e)
        {
            try
            {
                _ctx.Equipamentos.Add(e);
                //Formas de adicionar o objeto
                //_ctx.Set<Equipamento>().Add(e);
                //_ctx.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Altera o Equipamento existente 
        /// </summary>
        /// <param name="e">Equipamento a ser editado</param>
        public void Alterar(Equipamento e)
        {
            try
            {
                //Buscar o equipamento por Id
               Equipamento equipamentotemp = BuscarPorId(e.Id);

                //Verifica se o equipamento existe
                //Caso não existe gera uma exception
                if (equipamentotemp == null)
                    throw new Exception("Equipamento não encontrado");

                //Caso exista altera suas propriedades 
                equipamentotemp.Marca        = e.Marca;

                equipamentotemp.NPatrimonio  = e.NPatrimonio;
                equipamentotemp.NSerie       = e.NSerie;
                equipamentotemp.Tipo         = e.Tipo;
                equipamentotemp.Disponivel   = e.Disponivel;
                equipamentotemp.Descricao    = e.Descricao;

                //Altera o equipamento no contexto 
                _ctx.Equipamentos.Update(equipamentotemp);
                //Salva o contexto 
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }           
        }
        /// <summary>
        /// Deleta um Equipamento existente 
        /// </summary>
        /// <param name="id">Id do Equipamento a ser deletado</param>
        public void Excluir(Guid id)
        {
            try
            {
                //Buscar o equipamento por Id
                Equipamento equipamentotemp = BuscarPorId(id);

                //Verifica se o equipamento existe
                //Caso não existe gera uma exception
                if (equipamentotemp == null)
                    throw new Exception("Equipamento não encontrado");

                _ctx.Equipamentos.Remove(equipamentotemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
