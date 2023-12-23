using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa_PruebaTecnica
{
    public class Media
    {
        public double AgentA(List<double> LstNumbers)
        {
            double sum = LstNumbers.Sum();
            double media = sum / LstNumbers.Count;

            return media;
        }

        public double AgentB(List<double> LstNumbers)
        {
            double sumaInversos = 0.0;
            foreach (double numero in LstNumbers)
            {
                sumaInversos += 1.0 / numero;
            }
            
            double mediaArmonica = LstNumbers.Count / sumaInversos;

            return mediaArmonica;
        }

        public double AgentC(List<double> LstNumbers)
        {
            // Se ordena la lista
            LstNumbers.Sort();

            // se obtiene la pocicion de la mitad
            int mitad = LstNumbers.Count / 2;

            // Validacion si la cantidad de datos es par o impar
            if (LstNumbers.Count % 2 == 0)
            {                
                double valor1 = LstNumbers[mitad - 1];
                double valor2 = LstNumbers[mitad];
                return (valor1 + valor2) / 2.0;
            }
            else
            {                
                return LstNumbers[mitad];
            }
        }

    }
}
