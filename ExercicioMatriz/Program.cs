using System;

namespace AppMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] m = new int[3, 3];

            ObjMatriz objMatriz = new ObjMatriz(m);

            objMatriz.CriarMatriz();

            objMatriz.DiagonalPrincipal_Christofer();

            //int resultado = objMatriz.DiagonalPrincipal_Christofer();
            
            //Console.WriteLine("Resultado: " + resultado);

        }
    }
}
