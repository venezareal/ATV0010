using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0010.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t========== ATIVIDADE 10 ==========");

            Console.Write("\tDigite o nome da cidade: ");
            String nomecid = Console.ReadLine();

            Console.Write("\n\tDigite a extensão territorial: ");
            float territorio = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n\tDigite a população em habitantes: ");
            int habitantes = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\tDigite o PIB: ");
            float pib = Convert.ToSingle(Console.ReadLine());

           
            float pibPerCapita = pib / habitantes;


            Console.WriteLine("\n\n");
            Console.WriteLine($"\n\t========== DADOS DEMOGRÁFICOS DA CIDADE: {nomecid}");

            Console.Write($"\n\tNome da Cidade: {nomecid}");
            Console.Write($"\n\tArea Territorial: {territorio}");
            Console.Write($"\n\tNúmero de Habitantes: {habitantes}");
            Console.Write($"\n\tPIB Per Capita: {pib}");
            Console.Write($"\n\n\n\tPib Per Capita: {pibPerCapita}\n");
        }
    }
}
