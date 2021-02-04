using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleado
{
    class Program
    {
        static void Main(string[] args)
        {
            //datos de entrada
            Console.WriteLine("ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("ingrese numero de años que lleva en la empresa");
            int antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de horas trabajadas en el mes");
            int cantidadhoras = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de la hora");
            double valorhora = Double.Parse(Console.ReadLine());
            //proceso

            int bono = antiguedad * 50000;
            double totalpagarhora = cantidadhoras * valorhora;
            double totalcobrar = bono + totalpagarhora;

            double descuento = totalcobrar * 0.15;
            double valorneto = totalcobrar - descuento;

            //datos de salida
            Console.WriteLine(nombre);
            Console.WriteLine("cantidad de años en la  empresa es: " + antiguedad);
            Console.WriteLine("valor de la hora: " + valorhora);
            Console.WriteLine("total a cobrar en bruto es: " + totalcobrar);
            Console.WriteLine("el descuento es : " + descuento);
            Console.WriteLine("valor a cobrar neto " + valorneto);

        }
    }
}
