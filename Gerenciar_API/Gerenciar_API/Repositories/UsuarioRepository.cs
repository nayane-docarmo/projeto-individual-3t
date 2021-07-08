using API_Gerenciar.Context;
using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly GerenciarContext _ctx;

        public UsuarioRepository()
        {
            _ctx = new GerenciarContext();
        }
        public List<Usuario> Listar()
        {
            try
            {
                return _ctx.Usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            try
            {
                //return _ctx.Usuarios.FirstOrDefault(c => c.Id == id);
                return _ctx.Usuarios.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Cadastrar(Usuario e)
        {
            try
            {
                _ctx.Usuarios.Add(e);
                //Formas de adicionar o objeto
                //_ctx.Set<Usuario>().Add(e);
                //_ctx.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void Alterar(Usuario e)
        {
            try
            {
                //Buscar o Usuario por Id
                Usuario usuariotemp = BuscarPorId(e.Id);

                //Verifica se o Usuario existe
                //Caso não existe gera uma exception
                if (usuariotemp == null)
                    throw new Exception("Usuário não encontrado");

                //Caso exista altera suas propriedades 
                 usuariotemp.Nome    = e.Nome;
                 usuariotemp.CPF     = e.CPF;
                 usuariotemp.Setor   = e.Setor;
                 usuariotemp.Senha   = e.Senha;

                //Altera o Usuario no contexto 
                _ctx.Usuarios.Update(usuariotemp);
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
                //Buscar o Usuario por Id
                Usuario usuariotemp = BuscarPorId(id);

                //Verifica se o Usuario existe
                //Caso não existe gera uma exception
                if (usuariotemp == null)
                    throw new Exception("Usuário não encontrado");

                _ctx.Usuarios.Remove(usuariotemp);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
