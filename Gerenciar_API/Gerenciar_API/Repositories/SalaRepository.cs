using API_Gerenciar.Context;
using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Repositories
{
    public class SalaRepository : ISala
    {
        private readonly GerenciarContext _ctx;

        public SalaRepository()
        {
            _ctx = new GerenciarContext();
        }

        public List<Sala> Listar()
        {
            try
            {
                return _ctx.Salas.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Sala BuscarPorId(Guid id)
        {
            try
            {
                //return _ctx.Salas.FirstOrDefault(c => c.Id == id);
                return _ctx.Salas.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Sala> BuscarPorNome(string nome)
        {
            try
            {
                return _ctx.Salas.Where(c => c.Nome.Contains(nome)).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(Sala e)
        {
            try
            {
                _ctx.Salas.Add(e);
                //Formas de adicionar o objeto
                //_ctx.Set<Sala>().Add(e);
                //_ctx.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Alterar(Sala e)
        {
            try
            {
                //Buscar a Sala por Id
                Sala salatemp = BuscarPorId(e.Id);

                //Verifica se a Sala existe
                //Caso não existe gera uma exception
                if (salatemp == null)
                    throw new Exception("Sala não encontrada");

                //Caso exista altera suas propriedades 
                salatemp.Nome       = e.Nome;
                salatemp.Andar      = e.Andar;
                salatemp.Metragem   = e.Metragem;

                //Altera a Sala no contexto 
                _ctx.Salas.Update(salatemp);
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
                Sala salatemp = BuscarPorId(id);

                //Verifica se a Sala existe
                //Caso não existe gera uma exception
                if (salatemp == null)
                    throw new Exception("Sala não encontrado");

                _ctx.Salas.Remove(salatemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
