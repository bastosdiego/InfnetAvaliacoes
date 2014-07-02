﻿using System;
using System.Collections.Generic;

namespace Avaliacoes.Domain
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public string Objetivo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public virtual ICollection<Questao> Questoes { get; set; }
        public Coordenador Coordenador { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; }
        public enum Situacao
        {
            Agendada,
            EmAndamento,
            Finalizada
        }


    }
}
