// 1. Introduce el primer valor
using System;
using System.Timers;

internal partial class Program
{
    static void Main()
    {
        // 1. Introduce el primer valor
        Console.WriteLine("Introducir el primer valor: ");
        string Entrada1 = Console.ReadLine(); // Guardamos el valor introducido
        if (!int.TryParse(Entrada1, out int valor1))
        {
            Console.WriteLine("Entrada inválida. Se esperaba un número entero.");
            return;
        }

        Console.WriteLine($"Valor leído: {valor1}");
        // 2. Introduce el segundo valor
        Console.WriteLine("Introducir el segundo valor:");
        string Entrada2 = Console.ReadLine(); // Guardamos el valor introducido
        if (!int.TryParse(Entrada2, out int valor2))
        {
            Console.WriteLine("Entrada inválida. Se esperaba un número entero.");
            return;
        }

        // 3. Calculamos la suma y la resta
        int suma = valor1 + valor2;
        int resta = valor1 - valor2;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        // 4. Imprimimos los resultados en la consola
        Console.WriteLine($"El resultado de la suma es: {suma}");
        Console.WriteLine($"El resultado de la resta es: {resta}");

        // 5.  Esperamos a que el usuario presione una tecla para finalizar el programa
        Console.WriteLine("Presiona cualquier tecla para finalizar...");
        Console.ReadKey();

        
    }
}
