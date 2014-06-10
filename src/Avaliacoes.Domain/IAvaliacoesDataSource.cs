﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacoes.Domain
{
    public interface IAvaliacoesDataSource
    {
        IQueryable<Aluno> Alunos { get; }
        IQueryable<Avaliacao> Avaliacoes { get; }
        IQueryable<Coordenador> Coordenadores { get; }
        IQueryable<Curso> Cursos { get; }
        IQueryable<Disciplina> Disciplinas { get; }
        IQueryable<Opcao> Opcoes { get; }
        IQueryable<Professor> Professores { get; }
        IQueryable<Questao> Questoes { get; }
        IQueryable<Resposta> Respostas { get; }
        IQueryable<TopicoAvaliacao> Topicos { get; }
        IQueryable<Turma> Turmas { get; }

    }
}
