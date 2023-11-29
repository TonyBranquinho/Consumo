using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int distancia;
            double consumo, media;

            Console.Write("Distancia percorrida: ");
            distancia = int.Parse(Console.ReadLine(), CI);
            Console.Write("Combustivel gasto: ");
            consumo = double.Parse(Console.ReadLine(), CI);

            media = distancia / consumo;

            Console.WriteLine("Consumo medio: "+media.ToString("F3", CI));
            
        }
    }
}
