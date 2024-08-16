using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro
{
    internal class Program //Nomes: João Vitor Acordi, Murilo Ferraz, Lucius Crotti
    {
        static void Main(string[] args)
        {
            string nome = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int n1, n2, soma, subtracao, multiplicacao, divisao;

            
            Console.Write("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            subtracao = n1 - n2;
            multiplicacao = n1 * n2;
            divisao = n1 / n2;
            Console.WriteLine(nome + ", Você escolheu fazer operações com os seguintes números: {0} e {1}", n1, n2);
            Console.WriteLine("A soma é: " + soma + "\nA subtração é: " + subtracao + "\nA multiplicação é: " + multiplicacao + "\nA divisão é: " + divisao);
             Console.ReadKey();
                
        }
    }
}
