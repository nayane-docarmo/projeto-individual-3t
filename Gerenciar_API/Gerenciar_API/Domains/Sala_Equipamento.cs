﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciar_API.Domains
{
    public class Sala_Equipamento : BaseDomain
    {
        public Guid IdSala { get; set; }
        [ForeignKey("IdSala")]
        public Sala Sala { get; set; }

        public Guid IdEquipamento { get; set; }
        [ForeignKey("IdEquipamento")]
        public Equipamento Equipamento { get; set; }

        public string Descricao { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool StatusG { get; set; }
    }
}
