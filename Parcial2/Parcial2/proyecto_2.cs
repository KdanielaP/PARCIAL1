using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    internal class proyecto_2
    {
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de numeros a ingresar: ");
        int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidadNumeros];

        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write("Ingrese el numero " + (i + 1) + ": ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int cantidadPares = 0, cantidadImpares = 0;
        int sumaPares = 0, sumaImpares = 0;

        for (int i = 0; i < cantidadNumeros; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                cantidadPares++;
                sumaPares += numeros[i];
            }
            else
            {
                cantidadImpares++;
                sumaImpares += numeros[i];
            }
        }

        Console.WriteLine("Cantidad de numeros pares: " + cantidadPares);
        Console.WriteLine("Cantidad de numeros impares: " + cantidadImpares);
        Console.WriteLine("Suma de numeros pares: " + sumaPares);
        Console.WriteLine("Suma de numeros impares: " + sumaImpares);
    }
}