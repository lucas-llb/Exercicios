using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public class NotaAluno
    {
        public string name { get; set; }
        public int nota { get; set; }
    }

    public List<NotaAluno> Lista { get; } = new List<NotaAluno>();
    
    public void Add(string student, int grade)
    {
        var Lista2 = new List<NotaAluno>(); 
        var aluno = new NotaAluno()
        {
            name = student,
            nota = grade
        };
        Lista.Add(aluno);
        
    }

    public IEnumerable<string> Roster()
    {
        var ListaAlunos = new List<NotaAluno>();
        foreach (var aluno in Lista)
        {
            ListaAlunos.Add(aluno);
        }
        var listaOrdenada = ListaAlunos.OrderBy(q=>q.nota).ThenBy(q=>q.name);
        return listaOrdenada.Select(q=>q.name);
    }

    public IEnumerable<string> Grade(int grade)
    {
        var ListaOrdenada = new List<NotaAluno>();
        foreach (var item in Lista)
        {
            ListaOrdenada.Add(item);
        }
        var listaordenada2 = ListaOrdenada.OrderBy(q => q.nota).Where(q=>q.nota == grade);
        var ListaOrdenadaNova = listaordenada2.OrderBy(q => q.name).Select(q=>q.name);

        return ListaOrdenadaNova;
    }
}