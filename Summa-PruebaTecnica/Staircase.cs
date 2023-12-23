using System.Text;

namespace Summa_PruebaTecnica
{
    public class Staircase
    {
        public string AgentA(int size)
        {
            try
            {
                StringBuilder resultado = new StringBuilder();

                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < size - i; j++)
                    {
                        resultado.Append(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        resultado.Append("#");
                    }

                    resultado.AppendLine();
                }
                return resultado.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
                return string.Empty;
            }
        }

        public string AgentB(int size)
        {
            try
            {
                StringBuilder resultado = new StringBuilder();

                for (int i = size; i >= 1; i--)
                {

                    for (int j = 0; j < size - i; j++)
                    {
                        resultado.Append(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        resultado.Append("#");
                    }

                    resultado.AppendLine();
                }
                return resultado.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
                return string.Empty;
            }
        }

        public string AgentC(int size)
        {
            try
            {
                StringBuilder resultado = new StringBuilder();

                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < size - i; j++)
                    {
                        resultado.Append(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        resultado.Append("#");
                    }

                    for (int k = 0; k < i - 1; k++)
                    {
                        resultado.Append("#");
                    }

                    resultado.AppendLine();
                }



                for (int i = size - 1; i >= 1; i--)
                {
                    for (int j = 0; j < size - i; j++)
                    {
                        resultado.Append(" ");
                    }

                    for (int k = 0; k < i; k++)
                    {
                        resultado.Append("#");
                    }

                    for (int k = 0; k < i - 1; k++)
                    {
                        resultado.Append("#");
                    }

                    resultado.AppendLine();
                }
                return resultado.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Se presento un error en el proceso" + e.ToString());
                return string.Empty;
            }
        }
    }
}
