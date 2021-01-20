using EstruturaDados.Estruturas_de_Dados;
using System;

namespace EstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuPrincipal;
            do
            {
                Console.Clear();
                Console.WriteLine("Manipulação de estrutra de dados.");
                Console.WriteLine("1 - Fila FIFO");
                Console.WriteLine("2 - Pilha LIFO");
                Console.WriteLine("3 - Sair");
                Console.WriteLine();
                Console.Write("Menu: ");
                menuPrincipal = int.Parse(Console.ReadLine());

                if (menuPrincipal == 1)
                {
                    MinhaFila minhaFila = new MinhaFila();
                    int menuSecundario;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Estrutura de dados Fila");
                        Console.WriteLine("1 - Enfileirar");
                        Console.WriteLine("2 - Desenfileirar");
                        Console.WriteLine("3 - Topo");
                        Console.WriteLine("4 - Limpar");
                        Console.WriteLine("5 - Sair");
                        Console.WriteLine();
                        Console.Write("Menu: ");
                        menuSecundario = int.Parse(Console.ReadLine());

                        switch (menuSecundario)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Digite valor string: ");
                                string item = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine(minhaFila.Enfileirar(item));
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine(minhaFila.Desenfileirar());
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(minhaFila.Topo());
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine(minhaFila.Limpar());
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }

                    } while (menuSecundario < 5);
                }
                else if (menuPrincipal == 2)
                {
                    MinhaPilha minhaPilha = new MinhaPilha();
                    int menuSecundario;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Estrutura de dados Pilha");
                        Console.WriteLine("1 - Empilhar");
                        Console.WriteLine("2 - Dempilhar");
                        Console.WriteLine("3 - Topo");
                        Console.WriteLine("4 - Limpar");
                        Console.WriteLine("5 - Sair");
                        Console.WriteLine();
                        Console.Write("Menu: ");
                        menuSecundario = int.Parse(Console.ReadLine());

                        switch (menuSecundario)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Digite valor string: ");
                                string item = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine(minhaPilha.Empilhar(item));
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine(minhaPilha.Desempilhar());
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine(minhaPilha.Topo());
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine(minhaPilha.Limpar());
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }

                    } while (menuSecundario < 5);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Até a próxima!");
                }

            } while (menuPrincipal < 3);



        }
    }
}
