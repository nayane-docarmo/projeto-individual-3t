using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using Gerenciar_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gerenciar_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuario _usuarioRepository;
        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }
        [HttpGet]
        public List<Usuario> Get()
        {
            return _usuarioRepository.Listar();
        }

        // GET api/<EquipamentoController>/5
        [HttpGet("{id}")]
        public Usuario Get(Guid id)
        {
            return _usuarioRepository.BuscarPorId(id);
            //TODO: ARRUMAR BUSCAR POR ID 
        }

        // POST api/<EquipamentoController>
        [HttpPost]
        public void Post(Usuario usuario)
        {
            _usuarioRepository.Cadastrar(usuario);
        }

        // PUT api/<EquipamentoController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Usuario usuario)
        {
            usuario.Id = id;
            _usuarioRepository.Alterar(usuario);
        }   

        // DELETE api/<EquipamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _usuarioRepository.Excluir(id);
        }
    }
}
