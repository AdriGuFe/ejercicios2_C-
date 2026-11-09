using System;
using System.Collections;

class Program
{
    static double LeerDouble(string mensaje)
    {
        Console.Write(mensaje);
        return double.Parse(Console.ReadLine());
    }

    static int LeerEntero(string mensaje)
    {
        Console.Write(mensaje);
        return int.Parse(Console.ReadLine());
    }

    static string LeerTexto(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }

    static void Ejercicio1()
    {
        double numero1 = LeerDouble("Introduce el primer número: ");
        double numero2 = LeerDouble("Introduce el segundo número: ");

        Console.WriteLine($"El número mayor es {Math.Max(numero1, numero2)}");
    }

    static void Ejercicio2()
    {
        double kilovatios = LeerDouble("Kilovatios consumidos en el período anterior: ");
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

        double total = kilovatios * precio;
        Console.WriteLine($"Total a pagar: {total:C2}");
    }

    static void Ejercicio3()
    {
        string estado = LeerTexto("Introduce tu estado civil (C, S, V o D): ").ToUpper();

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
    }

    static void Ejercicio4()
    {
        int numero = LeerEntero("Introduce un número del 1 al 9: ");

        while (numero < 1 || numero > 9)
        {
            Console.WriteLine("El número está fuera de rango");
            numero = LeerEntero("Introduce un número del 1 al 9: ");
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    static void Ejercicio5()
    {
        string cadena = LeerTexto("Introduce una cadena de texto: ");

        Console.WriteLine($"Longitud: {cadena.Length}");

        string subcadena = LeerTexto("Introduce una subcadena para buscar: ");
        Console.WriteLine($"Contiene la subcadena: {cadena.Contains(subcadena)}");

        char antigua = LeerTexto("Letra que quieres reemplazar: ")[0];
        char nueva = LeerTexto("Letra nueva: ")[0];
        Console.WriteLine($"Texto con la letra reemplazada: {cadena.Replace(antigua, nueva)}");

        Console.WriteLine($"En mayúsculas: {cadena.ToUpper()}");
        Console.WriteLine($"En minúsculas: {cadena.ToLower()}");

        int posicion = LeerEntero("Posición del carácter que quieres eliminar: ");
        Console.WriteLine($"Texto sin ese carácter: {cadena.Remove(posicion, 1)}");

        int inicio = LeerEntero("Posición de inicio de la subcadena: ");
        int fin = LeerEntero("Posición de fin de la subcadena: ");
        Console.WriteLine($"Subcadena obtenida: {cadena.Substring(inicio, fin - inicio + 1)}");
    }

    static void Ejercicio6()
    {
        int numero = LeerEntero("Introduce un número: ");
        long factorial = 1;

        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es {factorial}");
    }

    static void Ejercicio7()
    {
        for (int codigo = 90; codigo >= 65; codigo--)
        {
            Console.WriteLine(Convert.ToString((char)codigo));
        }
    }

    static void Ejercicio8()
    {
        Random aleatorio = new Random();
        int numero = aleatorio.Next(10, 31);
        Console.WriteLine($"Número aleatorio: {numero}");
    }

    static void Ejercicio9()
    {
        int tamano = LeerEntero("Tamaño del array: ");
        int[] numeros = new int[tamano];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = LeerEntero($"Introduce el valor {i + 1}: ");
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
    }

    static void Ejercicio10()
    {
        int[] numeros = { 42, 7, 19, 3, 88, 25, 61, 14, 50, 9 };

        Array.Sort(numeros);

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    static void Ejercicio11()
    {
        Stack pila = new Stack();
        int cantidad = LeerEntero("Cuántos valores quieres introducir: ");

        for (int i = 0; i < cantidad; i++)
        {
            pila.Push(LeerEntero($"Introduce el valor {i + 1}: "));
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

    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Ejercicio1();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2");
        Ejercicio2();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3");
        Ejercicio3();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4");
        Ejercicio4();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 5");
        Ejercicio5();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 6");
        Ejercicio6();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 7");
        Ejercicio7();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 8");
        Ejercicio8();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 9");
        Ejercicio9();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 10");
        Ejercicio10();
        Console.WriteLine();

        Console.WriteLine("Ejercicio 11");
        Ejercicio11();
    }
}
