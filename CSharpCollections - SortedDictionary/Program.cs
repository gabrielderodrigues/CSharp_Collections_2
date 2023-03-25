using CSharpCollections_2___SortedDictionary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_2___SortedDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();

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
    }
}
