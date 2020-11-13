using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula a idade com base no ano de nascimento e o ano atual. A idade será mostrada em anos e semanas.
            int idade;
            int semanas;

            Console.WriteLine("Qual o ano de seu nascimento?");
            int nascimento =int.Parse(Console.ReadLine());

             Console.WriteLine("Qual o ano atual?");
            int atual =int.Parse(Console.ReadLine());

            idade = atual - nascimento;

            Console.WriteLine("A sua idade atual é: "+idade+" anos");

            Console.WriteLine("Você gostaria de saber sua idade em semanas? - Responda apenas com Sim ou Não.");
            string resposta = Console.ReadLine();

            if(resposta == "Sim"){
                semanas = idade * 52;
                Console.WriteLine("A sua idade atual é: "+semanas+" semanas");

            }
            else{
                Console.WriteLine("Obrigado pela sua participação.");
            }
        }
    }
}
