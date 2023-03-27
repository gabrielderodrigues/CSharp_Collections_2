using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections_2___OutrosOperadoresLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            // Pegar o primeiro trimestre
            var consultaTrimestre = meses.Take(3);            
            ImprimirMeses(consultaTrimestre);

            // Pegar os meses depois do primeiro trimestre
            var consultaDepoisTrimestre = meses.Skip(3);
            ImprimirMeses(consultaDepoisTrimestre);

            // Pegar os meses do terceiro trimestre
            var consultaTerceiroTrimestre = meses.Skip(6).Take(3);
            ImprimirMeses(consultaTerceiroTrimestre);

            // Pegar os meses até que o mês comece com a letra 'S'
            var consultarMesLetra = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            ImprimirMeses(consultarMesLetra);

            // Pular os meses até que comece com a letra 'S'
            var consultarMesesComLetraS = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            ImprimirMeses(consultarMesesComLetraS);


            Console.ReadLine();
        }

        private static void ImprimirMeses(IEnumerable<Mes> consultaTrimestre)
        {
            foreach (var item in consultaTrimestre)
            {
                Console.WriteLine($"{item.Nome} - {item.Dias} dia(s).");
            }
            Console.WriteLine();
        }

        public class Mes
        {
            public string Nome { get; private set; }
            public int Dias { get; private set; }

            public Mes(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }
        }
    }
}
