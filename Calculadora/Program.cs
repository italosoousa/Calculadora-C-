using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Calculadora
{
    internal class Program
    {
        // Colocando o somar como 1 para o que meu enum seja contado de forma natural
        enum Menu { Somar = 1, Subtrair, Dividir, Multiplicar, Potencia, Raiz, Sair };

        static void Main(string[] args)
        {

            bool escolheuSair = false;

            while (!escolheuSair)
            {
                // Construção do menu da calculadora no consoole
                Console.WriteLine("----- CALCULADORA -----");
                Console.WriteLine("");
                Console.WriteLine("Qual operação você deseja fazer? ");
                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicar\n5 - Potencia\n6 - Raiz\n7 - Sair");
                Console.WriteLine("");

                // Coletando o valor digitado e trasformando ele em texto
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                // Dando funcionalidade ao menu
                switch (opcao)
                {
                    case Menu.Somar:
                        Somar();
                        break;

                    case Menu.Subtrair:
                        Subtrair();
                        break;

                    case Menu.Dividir:
                        Dividir();
                        break;

                    case Menu.Multiplicar:
                        Multiplicar();
                        break;

                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        return;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                // Limpa o console depois de executar o loop
                Console.Clear();

            }

        }

        // Função para somar números
        static void Somar()
        {
            Console.WriteLine("Digite os valores que você quer somar: ");
            Console.WriteLine("Digite o seu primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        // Função para subtrair números
        static void Subtrair()
        {
            Console.WriteLine("Digite os valores que você quer subtrair: ");
            Console.WriteLine("Digite o seu primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        // Função para dividir números
        static void Dividir()
        {
            Console.WriteLine("Digite os valores que você quer dividir: ");
            Console.WriteLine("Digite o seu primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a / b;
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        // Função para multiplicar números
        static void Multiplicar()
        {
            Console.WriteLine("Digite os valores que você quer multiplicar: ");
            Console.WriteLine("Digite o seu primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        // Função para potência números
        static void Potencia()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite a sua base: ");
            // A palavra 'base' é uma palavra reservada no C#
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        // Função para raiz números
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O seu resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

    }
}
