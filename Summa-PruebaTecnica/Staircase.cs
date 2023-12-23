namespace Summa_PruebaTecnica
{
    public class Staircase
    {
        public void AgentA(int size)
        {
            try
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

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
            }
        }

        public void AgentB(int size)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
            }
        }

        public void AgentC(int size)
        {
            try
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
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
            }
        }
    }
}
