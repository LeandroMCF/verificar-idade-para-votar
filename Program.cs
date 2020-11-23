using System;

namespace verificar_idade_para_votar
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int idade;
            int rep;

            rep = 1;
            do
            {
                Console.WriteLine("Digite o ano do seu nascimento:");
                ano = int.Parse(Console.ReadLine());
                while (ano > 2020 || ano < 1800)
                {
                    Console.WriteLine($"Ano invalido, digite o ano novamente: ");
                    ano = int.Parse(Console.ReadLine());
                }
                idade = 2020 - ano;
                if (idade < 16)
                {
                    Console.WriteLine($"Você tem {idade} anos, ainda não pode votar");
                } 
                else if (idade >= 16 && idade < 18)
                {
                    Console.WriteLine($"Você tem {idade} anos, você pode votar, mas não é obrigado.");
                }
                else
                {
                    Console.WriteLine($"Você tem {idade} anos, você é obrigado a votar.");
                }
                Console.WriteLine("Deseja verificar outra idade?\n[1] Para sim\n[2] Para não");
                rep = int.Parse(Console.ReadLine());
            } while (rep == 1);
            Console.WriteLine("Ok, tchau!");
        }
    }
}
