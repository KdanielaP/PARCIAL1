namespace Parcial
{
    using System;

    public class Calculadora
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0;
            }
            return num1 / num2;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de la clase Calculadora
            Calculadora miCalculadora = new Calculadora();

            // Ejecutar los cuatro métodos de operaciones básicas
            int resultadoSuma = miCalculadora.Sumar(10, 5);
            Console.WriteLine("Suma: " + resultadoSuma);

            int resultadoResta = miCalculadora.Restar(10, 5);
            Console.WriteLine("Resta: " + resultadoResta);

            int resultadoMultiplicacion = miCalculadora.Multiplicar(10, 5);
            Console.WriteLine("Multiplicación: " + resultadoMultiplicacion);

            int resultadoDivision = miCalculadora.Dividir(10, 5);
            Console.WriteLine("División: " + resultadoDivision);

            // Llamar al método estático para sumar dos valores
            SumarDosValores();
        }

        public static void SumarDosValores()
        {
            try
            {
                // Pedir dos valores de entrada
                Console.WriteLine("Ingrese el primer valor:");
                string valor1Str = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo valor:");
                string valor2Str = Console.ReadLine();

                // Convertir los valores a enteros
                int valor1 = int.Parse(valor1Str);
                int valor2 = int.Parse(valor2Str);

                // Sumar los valores
                int suma = valor1 + valor2;

                // Mostrar el resultado
                Console.WriteLine($"La suma de {valor1} y {valor2} es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar valores numéricos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }
    }
}