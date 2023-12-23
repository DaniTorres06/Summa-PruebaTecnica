using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa_PruebaTecnica
{
    public class Staircase
    {
        public void AgentA(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                // Imprimir espacios en blanco (antes de los caracteres de la escalera)
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                // Imprimir caracteres de la escalera
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }

                // Cambiar de línea para la siguiente fila
                Console.WriteLine();
            }
        }

        public void AgentB(int size)
        {
            for (int i = size; i >= 1; i--)
            {

                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        public void AgentC(int size)
        {
            for (int i = 1; i <= size; i++)
            {                
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                
                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write("#");
                }
                
                Console.WriteLine();
            }

            
            for (int i = size - 1; i >= 1; i--)
            {
                
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                
                for (int k = 0; k < i - 1; k++)
                {
                    Console.Write("#");
                }

                
                Console.WriteLine();
            }
        }
    }
}
