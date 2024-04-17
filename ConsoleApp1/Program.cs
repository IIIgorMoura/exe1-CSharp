using Microsoft.Win32;
using System;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXE-1:");

            double salario = 35.00;
            double calcSalarioHoras = salario * 8;

            Console.WriteLine("O salário de 1 dia de 8 horas trabalhadas é de " + calcSalarioHoras);





            Console.WriteLine("\nEXE-2:");

            int CaixaBomBomUnidades = 27;
            int calcQntBomBoms = CaixaBomBomUnidades * 16; 
            Console.WriteLine("Pamela tem: " + calcQntBomBoms + " unidades de BomBom");





            Console.WriteLine("\nEXE-3:");

            int valor1 = 10;
            int valor2 = 20;

            int soma = valor1 + valor2;

            Console.WriteLine("A soma dos valores é: " + soma);





            Console.WriteLine("\nEXE-4:");

            int qntGarrafas = 300;
            int qntGarrafasPorCaixa = 20;

            int calcQntGarrafasPorCaiza = qntGarrafas / qntGarrafasPorCaixa;

            Console.WriteLine("Há " + calcQntGarrafasPorCaiza + " garrafas por caixa");





            Console.WriteLine("\nEXE-5:");

            double precoInstalacao = 300.00;
            double precoLimpeza = 150.00;
            double precoManutencao = 499.99;

            bool clienteNovo = true;

            if (clienteNovo == false)
            {
                double calcSomaPrecoServicos = precoInstalacao + precoLimpeza + precoManutencao;
                Console.WriteLine("A soma do preço dos serviços é de: " + calcSomaPrecoServicos);
            }
            else if (clienteNovo == true)
            {
                double desconto = 50.00;
                double calcSomaPrecoServicosDesconto = precoInstalacao + precoLimpeza + precoManutencao - desconto;
                Console.WriteLine("A soma do preço dos serviços com desconto é de: " + calcSomaPrecoServicosDesconto);
            }
        }
    }
}
