using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCollections_2___ConsultandoCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // PROBLEMA: Obter os nomes do meses do ano
            // que tem 31 dias, em maiúsculo e em ordem alfabética.

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

            IEnumerable<Mes> consulta = meses;

            ImprimirMeses(consulta);

            Console.ReadLine();
        }

        private static void ImprimirMeses(IEnumerable<Mes> consulta)
        {
            // LINQ = Consulta Integrada à Linguagem

            var filtroMeses = consulta.Where(m => m.Dias == 31).OrderBy(m => m.Nome);

            foreach (var mes in filtroMeses)
            {
                Console.WriteLine($"{mes.Nome.ToUpper()} - {mes.Dias} dia(s).");
            }
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
