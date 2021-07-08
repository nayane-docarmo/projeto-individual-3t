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
    public class SalaController : ControllerBase
    {
        private readonly ISala _salaRepository;
        public SalaController()
        {
            _salaRepository = new SalaRepository();
        }
        [HttpGet]
        public List<Sala> Get()
        {
            return _salaRepository.Listar();
        }
        // GET api/<EquipamentoController>/5
        [HttpGet("{Nome}")]
        public void Get(string nome)
        {
            _salaRepository.BuscarPorNome(nome);
            //TODO: ARRUMAR BUSCAR POR TIPO
        }

        // GET api/<EquipamentoController>/5
        [HttpGet("{id}")]
        public Sala Get(Guid id)
        {
            return _salaRepository.BuscarPorId(id);
            //TODO: ARRUMAR BUSCAR POR ID 
        }

        // POST api/<EquipamentoController>
        [HttpPost]
        public void Post(Sala sala)
        {
            _salaRepository.Cadastrar(sala);
        }

         // PUT api/<EquipamentoController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Sala sala)
        {
            sala.Id = id;
            _salaRepository.Alterar(sala);
        }


        // DELETE api/<EquipamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _salaRepository.Excluir(id);
        }
    }
}
