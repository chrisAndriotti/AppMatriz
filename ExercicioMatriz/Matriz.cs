using System;

namespace AppMatriz
{
    public class ObjMatriz
    {
        private int[,] Matriz { get; set; }

        public ObjMatriz() { }

        public ObjMatriz(int[,] matriz)
        {
            Matriz = matriz;
        }

        public void CriarMatriz()
        {
            try
            {
                Console.WriteLine("****************************************************************************");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Para calcular a diagonal principal da matriz entre com os seguintes dados: ");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------------------");

                Console.WriteLine();
                int tamanho = Matriz.Length / 3;
                //for para percorrer as linhas da matriz
                for (int i = 0; i < tamanho; i++)
                {
                    //for que percorre as colunas da matriz
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.Write(">> Linha: " + i + ", Coluna: " + j + ": ");
                        int valor = int.Parse(Console.ReadLine());
                        Matriz[i, j] = valor;
                    }
                }
                Console.WriteLine("****************************************************************************");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Matriz");
                Console.ResetColor();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(ToString());
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro ao ler um número interio: " + e.Message);
            }

        }

        public void DiagonalPrincipal_Christofer()
        {
            int aux = 0;

            //for para percorrer as linhas da matriz
            for (int i = 0; i < 3; i++)
            {
                //for que percorre as colunas da matriz
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        int soma = Matriz[i, j];
                        aux += soma;                      
                    }
                }
            }
            Console.WriteLine("****************************************************************************");
            Console.Write("Resultado: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(aux);
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------------------------------------");

        }



        public override string ToString()
        {
            return ">>   " + Matriz[0,0] +" "+ Matriz[0,1] + " " + Matriz[0,2]+"\n"
                +">>   "+ Matriz[1,0] + " " + Matriz[1,1] + " " + Matriz[1,2]+"\n"
                +">>   "+ Matriz [2,0] + " " + Matriz[2,1] + " " + Matriz[2,2];
        }
       
    }



}
