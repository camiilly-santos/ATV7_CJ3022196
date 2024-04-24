namespace ATV7_CJ3022196
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao, i;

            do
            {
                do
                {

                    Console.WriteLine("=========MENU=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - EX1");
                    Console.WriteLine("2 - EX2");
                    Console.WriteLine("3 - EX3");

                    opcao = int.Parse(Console.ReadLine());

                } while (opcao < 0 || opcao > 3);

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por usar o sistema!");
                        break;
                    case 1:
                        Console.WriteLine("Executando o ex1");
                        int n, contador = 0;

                        Console.WriteLine("Digite um número: ");
                        n = int.Parse(Console.ReadLine());

                        while (contador <= n)
                        {
                            Console.WriteLine(contador);
                            contador++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Executando o ex2");
                        int n1, contado = 0;

                        Console.WriteLine("Digite um número: ");
                        n1 = int.Parse(Console.ReadLine());

                        while (contado <= n1)
                        {
                            Console.WriteLine(contado);
                            contado++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Executando o ex3");
                        int n2, contad = 1000;

                        Console.WriteLine("Digite um número menor que 1000: ");
                        n2 = int.Parse(Console.ReadLine());

                        while (contad <= n2)
                        {
                            Console.WriteLine(contad);
                            contad--;
                        }
                        break;
                    case 4:
                        int n4, positivos = 0;
                        i = 0;
                        Console.WriteLine("executando ex 4");

                        while (i < 10)
                        {
                            Console.WriteLine("Digite um número: ");
                            n4 = int.Parse(Console.ReadLine());

                            if (n4 > 0)
                            {
                                positivos += n4;
                                Console.WriteLine(n4);
                            }

                            if (positivos >= 200)
                                break;
                        }

                        if (positivos < 200)
                            Console.WriteLine("A soma dos números positivos é menor que 200.");
                        break;
                    case 5:
                        int n5;
                        i = 1;
                        Console.WriteLine("executando ex 5");
                        Console.WriteLine("Digite um número inteiro: ");
                        n5 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Divisores de ", n5, ":");

                        while (i <= n5)
                        {
                            if (n5 % i == 0)
                            {
                                Console.WriteLine(i + " ");
                            }
                            i++;
                        }
                        Console.ReadLine();


                        break;
                    case 6:
                        Console.WriteLine("executando ex 6");
                        Console.WriteLine("Digite 10 números, um por linha: ");
                        int[] n6 = new int[10];
                        int contador4 = 0;

                        while (contador4 < 10)
                        {
                            Console.Write($"Digite um número {contador4 + 1}: ");
                            string input = Console.ReadLine();

                            if (int.TryParse(input, out int number))
                            {
                                n6[contador4] = number;
                                contador4++;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
                            }
                        }

                        int maior_num = n6.Max();
                        int menor_num = n6.Min();

                        Console.WriteLine($"O maior número é: {maior_num}");
                        Console.WriteLine($"O menor número é: {menor_num}");
                        break;


                    case 7:
                        Console.WriteLine("executando ex 7");
                        int numero, somaPar = 0, somaImpar = 0;

                        Console.WriteLine("Digite uma sequência de números (digite 0 para encerrar):");

                        while (true)
                        {
                            Console.Write("Número: ");
                            numero = int.Parse(Console.ReadLine());

                            if (numero == 0)
                                break;

                            if (numero % 2 == 0)
                                somaPar += numero;
                            else
                                somaImpar += numero;
                        }

                        Console.WriteLine($"A soma dos números pares é: {somaPar}");
                        Console.WriteLine($"A soma dos números ímpares é: {somaImpar}");
                        break;
                }



            } while (opcao != 0);
        }
    }
}