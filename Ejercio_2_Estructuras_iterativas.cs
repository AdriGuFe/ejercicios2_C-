using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Console.Write("Introduce el primer número: ");
        double numeroA = double.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double numeroB = double.Parse(Console.ReadLine());
        Console.WriteLine($"El número mayor es {Math.Max(numeroA, numeroB)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2");
        Console.Write("Kilovatios consumidos en el período anterior: ");
        double kilovatios = double.Parse(Console.ReadLine());
        double precio;
        if (kilovatios > 1800)
        {
            precio = 0.8;
        }
        else if (kilovatios >= 1000)
        {
            precio = 0.12;
        }
        else
        {
            precio = 0.14;
        }
        double totalLuz = kilovatios * precio;
        Console.WriteLine($"Total a pagar: {totalLuz:C2}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3");
        Console.Write("Introduce tu estado civil (C, S, V o D): ");
        string estado = Console.ReadLine().ToUpper();
        switch (estado)
        {
            case "C":
                Console.WriteLine("Tu estado civil es Casad@");
                break;
            case "S":
                Console.WriteLine("Tu estado civil es Solter@");
                break;
            case "V":
                Console.WriteLine("Tu estado civil es Viud@");
                break;
            case "D":
                Console.WriteLine("Tu estado civil es Divorciad@");
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4");
        Console.Write("Introduce un número del 1 al 9: ");
        int numeroTabla = int.Parse(Console.ReadLine());
        while (numeroTabla < 1 || numeroTabla > 9)
        {
            Console.WriteLine("El número está fuera de rango");
            Console.Write("Introduce un número del 1 al 9: ");
            numeroTabla = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 5");
        Console.Write("Introduce una cadena de texto: ");
        string cadena = Console.ReadLine();
        Console.WriteLine($"Longitud: {cadena.Length}");
        Console.Write("Introduce una subcadena para buscar: ");
        string subcadena = Console.ReadLine();
        Console.WriteLine($"Contiene la subcadena: {cadena.Contains(subcadena)}");
        Console.Write("Letra que quieres reemplazar: ");
        char antigua = Console.ReadLine()[0];
        Console.Write("Letra nueva: ");
        char nueva = Console.ReadLine()[0];
        Console.WriteLine($"Texto con la letra reemplazada: {cadena.Replace(antigua, nueva)}");
        Console.WriteLine($"En mayúsculas: {cadena.ToUpper()}");
        Console.WriteLine($"En minúsculas: {cadena.ToLower()}");
        Console.Write("Posición del carácter que quieres eliminar: ");
        int posicion = int.Parse(Console.ReadLine());
        Console.WriteLine($"Texto sin ese carácter: {cadena.Remove(posicion, 1)}");
        Console.Write("Posición de inicio de la subcadena: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.Write("Posición de fin de la subcadena: ");
        int fin = int.Parse(Console.ReadLine());
        Console.WriteLine($"Subcadena obtenida: {cadena.Substring(inicio, fin - inicio + 1)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 6");
        Console.Write("Introduce un número: ");
        int numeroFactorial = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 2; i <= numeroFactorial; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numeroFactorial} es {factorial}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 7");
        for (int codigo = 90; codigo >= 65; codigo--)
        {
            Console.WriteLine(Convert.ToString((char)codigo));
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 8");
        Random aleatorio = new Random();
        int numeroAleatorio = aleatorio.Next(10, 31);
        Console.WriteLine($"Número aleatorio: {numeroAleatorio}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 9");
        Console.Write("Tamaño del array: ");
        int tamano = int.Parse(Console.ReadLine());
        int[] numeros = new int[tamano];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Valores pares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        Console.WriteLine("Valores impares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 != 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 10");
        int[] desordenados = { 42, 7, 19, 3, 88, 25, 61, 14, 50, 9 };
        Array.Sort(desordenados);
        for (int i = 0; i < desordenados.Length; i++)
        {
            Console.WriteLine(desordenados[i]);
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 11");
        Stack pila = new Stack();
        Console.Write("Cuántos valores quieres introducir: ");
        int cantidad = int.Parse(Console.ReadLine());
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            pila.Push(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Valores de la pila:");
        foreach (object valor in pila)
        {
            Console.WriteLine(valor);
        }
        if (pila.Count >= 2)
        {
            Console.WriteLine($"Sacado de la pila: {pila.Pop()}");
            Console.WriteLine($"Sacado de la pila: {pila.Pop()}");
        }
        Console.WriteLine("Valores de la pila después de sacar dos:");
        foreach (object valor in pila)
        {
            Console.WriteLine(valor);
        }
    }
}
