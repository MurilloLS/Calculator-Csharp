using System;
using System.Collections;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Perfil(); 
        }

        static void Perfil()
        {
            Console.Clear();
            Console.WriteLine("OLÁ, PREENCHA COM SUAS INFORMAÇÕES: ");
            Console.WriteLine("");
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Menu();

        }
        static void Menu()
        {
            
            Console.Clear();
            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão"); 
            Console.WriteLine("5 - Média"); 
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Potência");
            Console.WriteLine("8 - Raiz quadrada");
            Console.WriteLine("9 - Sair"); 

            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma opção: ");
            int res = Convert.ToInt32(Console.ReadLine());
            switch(res) 
            {
                case 1: Soma();break;
                case 2: Subtracao();break;
                case 3: Multiplicacao();break;
                case 4: Divisao();break;
                case 5: Media();break;
                case 6: Porcentagem();break;
                case 7: Potencia();break;
                case 8: RaizQuadrada();break;
                case 9: System.Environment.Exit(0);break;
                default: Menu();break;
            }


        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.ReadKey();
            Menu();
            //Console.WriteLine($"O resultado da soma é {resultado}");
            //Console.WriteLine("O resultado da soma é " + (v1 + v2));
            //Console.WriteLine($"O resultado da soma é {v1 + v2}");
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Divisao()

        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Media()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = (v1 + v2)/2;
            Console.WriteLine($"A média de {v1} e {v2} é {resultado} ");
            Console.ReadKey();
            Menu();
        }
        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem desejada: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = (v1 * v2)/100;
            Console.WriteLine($"A porcentagem {v2} de {v1} é {resultado}");
            Console.ReadKey();
            Menu(); 
        }
        static void Potencia()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = Math.Pow(v1,v2);
            Console.WriteLine($"O resultado da potêcia é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void RaizQuadrada()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double resultado = Math.Sqrt(v1);
            Console.WriteLine($"O resultado da raiz quadrada é {resultado}");
            Console.ReadKey();
            Menu();  
        }
    }   

}