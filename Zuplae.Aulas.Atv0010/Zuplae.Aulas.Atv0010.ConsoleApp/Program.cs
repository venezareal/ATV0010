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
            double territorio = Console.ReadLine();

            Console.Write("\n\tDigite a população em habitantes: ");
            Int64 habitantes = Console.ReadLine();

            Console.Write("\n\tDigite a densidade demográfica - Hab/Km²: ");
            double densidade = Console.ReadLine();

            Console.Write("\n\tDigite o PIB per capita: ");
            double pib = Console.ReadLine();

            Console.Write("\n\tDigite a porcentagem de escolarização - 6 a 14 anos:");
            double escolaridade = Console.ReadLine();

            Console.Write("\n\tDigite a taxa de analfabetismo em indivíduos +15 anos: ");
            double analfabetismo = Console.ReadLine();

            Console.Write("\n\tDigite a taxa de fecundidade: ");
            double fecundidade = Console.ReadLine();

            Console.Write("\n\tDigite a taxa de mortalidade infantil: ");
            double mortalidadeInf = Console.ReadLine();

            Console.Write("\n\tDigite a taxa de desocupação: ");
            double desocupacao = Console.ReadLine();

            Console.Write("\n\tDigite a taxa IPCA mensal:\n");
            double ipca = Console.ReadLine();


            Console.WriteLine("\n\n");
            Console.WriteLine($"\n\t========== DADOS DEMOGRÁFICOS DA CIDADE: {nomecid}");

            Console.Write($"\n\tNome da Cidade: {nomecid}");
            Console.Write($"\n\tArea Territorial: {territorio}");
            Console.Write($"\n\tNúmero de Habitantes: {habitantes}");
            Console.Write($"\n\tDensidade Demográfica: {densidade}");
            Console.Write($"\n\tPIB Per Capita: {pib}");
            Console.Write($"\n\tEscolarização 6-14 anos: {escolaridade}");
            Console.Write($"\n\tAnalfabetismo + 15 anos: {analfabetismo}");
            Console.Write($"\n\tQuantidade Filhos por mulher: {fecundidade}");
            Console.Write($"\n\tTaxa Mortalidade Infantil: {mortalidadeInf}");
            Console.Write($"\n\tTaxa de Desocupação: {desocupacao}\n");
        }
    }
}
