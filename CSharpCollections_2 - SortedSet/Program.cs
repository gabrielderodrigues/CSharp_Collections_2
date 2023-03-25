using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_2___SortedSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            ImprimirAlunos(alunos);

            ISet<string> outroConjunto = new HashSet<string>();

            // Este conjunto é subconjunto do outro? IsSubsetOf
            var isSubsetOf = alunos.IsSubsetOf(outroConjunto);
            Console.WriteLine(isSubsetOf);

            // Este conjunto é superconjunto do outro? IsSupersetOf
            var isSupersetOf = alunos.IsSupersetOf(outroConjunto);
            Console.WriteLine(isSupersetOf);

            // Os conjuntos contêm o mesmo elemento? SetEquals
            var setEquals = alunos.SetEquals(outroConjunto);
            Console.WriteLine(setEquals);

            // Subtrai os elementos da outra coleção que também estão na coleção
            alunos.ExceptWith(outroConjunto);

            // Intersecção dos conjuntos? IntersectWith
            alunos.IntersectWith(outroConjunto);

            // Somente em um ou outro conjunto - SymmetrickExceptWith
            alunos.SymmetricExceptWith(outroConjunto);

            // União de conjunto - UnionWith
            alunos.UnionWith(outroConjunto);


            Console.ReadLine();
        }

        private static void ImprimirAlunos(ISet<string> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
