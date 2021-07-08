using Gerenciar_API.Domains;
using Gerenciar_API.Interfaces;
using Gerenciar_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Gerenciar_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SalaEquipamentoController : ControllerBase
    {

        private readonly ISala_Equipamento _seRepository;
        public SalaEquipamentoController()
        {
            _seRepository = new Sala_EquipamentoRepository();
        }
        [HttpGet]
        public List<Sala_Equipamento> Get()
        {
            return _seRepository.Listar();
        }

        // GET api/<EquipamentoController>/5
        [HttpGet("{id}")]
        public Sala_Equipamento Get(Guid id)
        {
            return _seRepository.BuscarPorId(id);
        }

        // POST api/<EquipamentoController>
        [HttpPost]
        public void Post(Sala_Equipamento se)
        {
            _seRepository.Cadastrar(se);
        }

        // PUT api/<EquipamentoController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, Sala_Equipamento se)
        {
            se.Id = id;
            _seRepository.Alterar(se);
        }

        // DELETE api/<EquipamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _seRepository.Excluir(id);
        }
    }
}
