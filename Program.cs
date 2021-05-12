using System;

namespace Passagens_Aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Bem vindo ao Aeroporto do Barretão\n");
            bool acesso = true;
            while (acesso)
            {

                Console.WriteLine("Para acessar o sistema digite a senha: ");
                int senha = int.Parse(Console.ReadLine());

                if (senha == 123456)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acesso confirmado!!!");
                    Console.ResetColor();
                    acesso = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Acesso negado!!! Tente novamente");
                    Console.ResetColor();
                    acesso = true;
                }
            }
            string[] nomes = new string[5];
            string[] Origens = new string[5];
            string[] Destinos = new string[5];
            string[] Datas = new string[5];
            int j = 1;
            int i2 = 0;
            // bool novamente = true;
            bool sair = true;
            while (sair)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("MENU\n");
                Console.WriteLine("Digite a o numero para confirmar a opção:\n");
                Console.WriteLine("1- Cadastrar passagem");
                Console.WriteLine("2- Listar Passagens");
                Console.WriteLine("0- Sair\n");
                int opçãoMenu = int.Parse(Console.ReadLine());

                if (opçãoMenu == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("Cadastro de Passagem\n");

                    do
                    {
                        Console.WriteLine($"Cadastro do {j}º voo");
                        j++;
                        Console.WriteLine("Insira o Nome do Passageiro...:");
                        nomes[i2] = Console.ReadLine().ToUpper();
                        Console.WriteLine("Insira a origem do voo...:");
                        Origens[i2] = Console.ReadLine().ToUpper();
                        Console.WriteLine("Insira o Destino do voo...:");
                        Destinos[i2] = Console.ReadLine().ToUpper();
                        Console.WriteLine("Insira a Data do voo (dd/mm/yyyy)...:");
                        Datas[i2] = Console.ReadLine().ToUpper();
                        i2++;


                        Console.WriteLine($"Voce deseja cadastrar mais um ? (Digite 's' para continuar)");
                        string respostaCad = Console.ReadLine().ToLower();
                        if (i2 == nomes.Length)
                        {

                            Console.WriteLine("Voce atingiu o numero maximo de cadastro");
                        }
                        else
                        {
                            if (respostaCad == "s")
                            {
                                Console.WriteLine("------>");
                            }
                            else
                            {
                                break;
                            }
                        }

                    } while (true);
                }
                else if (opçãoMenu == 2)
                {

                    for (var i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"{i + 1} {nomes[i]} - {Origens[i]} - {Destinos[i]} - {Datas[i]}\n");
                    }
                    sair = true;
                }
                else if (opçãoMenu == 0)
                {
                    sair = false;
                    Console.WriteLine("Bye bye...");
                    Console.ResetColor();

                }
            }
        }
    }
}
