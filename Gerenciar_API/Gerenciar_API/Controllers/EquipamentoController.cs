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
    public class EquipamentoController : ControllerBase
    {
        private readonly IEquipamento _equipamentoRepository;
        public EquipamentoController()
        {
            _equipamentoRepository = new EquipamentoRepository();
        }
        [HttpGet]
        public List<Equipamento> Get()
        {
            return _equipamentoRepository.Listar();
        }
        // GET api/<EquipamentoController>/5
        [HttpGet("{id}")]
        public void Get(string tipo)
        {
            _equipamentoRepository.BuscarPorTipo(tipo);
            //TODO: ARRUMAR BUSCAR POR TIPO
        }

        // GET api/<EquipamentoController>/5
        [HttpGet("{id}")]
        public Equipamento Get (Guid id)
        {
           return _equipamentoRepository.BuscarPorId(id);
            //TODO: BUSCAR POR ID 
        }

        // POST api/<EquipamentoController>
        [HttpPost]
        public void Post(Equipamento equipamento)
        {
            _equipamentoRepository.Cadastrar(equipamento);
        }

        // PUT api/<EquipamentoController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Equipamento equipamento)
        {
            equipamento.Id = id;
            _equipamentoRepository.Alterar(equipamento);
        }

        // DELETE api/<EquipamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _equipamentoRepository.Excluir(id);
        }
    }
}
