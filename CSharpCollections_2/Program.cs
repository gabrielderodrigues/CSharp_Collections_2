using CSharpCollections_2___SortedList.Entities;
using System;
using System.Collections.Generic;

namespace CSharpCollections_2___SortedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17654));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            ImprimirDicionario(alunos);

            RemoveAluno(alunos, "AL");

            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17654));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            ImprimirDicionario(sorted);

            Console.ReadLine();
        }

        private static void ImprimirDicionario(IDictionary<string, Aluno> alunos)
        {
            Console.WriteLine();
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }

        private static void RemoveAluno(IDictionary<string, Aluno> alunos, string chave)
        {
            alunos.Remove(chave);
            ImprimirDicionario(alunos);
        }
    }
}
