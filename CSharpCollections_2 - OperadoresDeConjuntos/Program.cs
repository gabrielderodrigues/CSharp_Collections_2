using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_2___OperadoresDeConjuntos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] seq1 = { "Janeiro", "Fevereiro", "Março" };
            string[] seq2 = { "Fevereiro", "MARÇO", "Abril" };

            Console.WriteLine("-- Concatenando duas sequências:");
            var consultaArrays = seq1.Concat(seq2);
            ImprimirArray(consultaArrays);

            Console.WriteLine("-- União de duas sequências:");
            var consultaUniaoSequencias = seq1.Union(seq2);
            ImprimirArray(consultaUniaoSequencias);

            Console.WriteLine("-- União de duas sequências com comparador:");
            var consultaUniaoSequenciasComparador = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            ImprimirArray(consultaUniaoSequenciasComparador);

            Console.WriteLine("-- Interseção de duas sequências:");
            var consultaIntersecao = seq1.Intersect(seq2);
            ImprimirArray(consultaIntersecao);

            Console.WriteLine("-- Exceto: elementos de seq1 que não tão em seq2:");
            var consultaExceto = seq1.Except(seq2);
            ImprimirArray(consultaExceto);

            Console.ReadLine();
        }

        private static void ImprimirArray(IEnumerable<string> consultaArrays)
        {
            foreach (var item in consultaArrays)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
