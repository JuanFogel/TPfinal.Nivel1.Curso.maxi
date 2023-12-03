internal class Program
{
    private static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.
        // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

        int n;
        int mayorPar = 0;
        int contImp = 0;
        int menorPrimo = 0;
        bool banPar = false;
        bool banPrimo = false;

        Console.WriteLine("Bienvenido, ingrese un Número para comenzar: ");
        n = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            Console.WriteLine("Ingrese nuevamente un Número para continuar o 0 para finalizar: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                if (banPar == false)
                {
                    mayorPar = n;
                    banPar = true;
                }
                else if (n > mayorPar)
                    mayorPar = n;

            if (n % 2 == 1)
                contImp++;

            if (primo(n) == true)
            {
                if (n % 2 == 1)
                    if (banPrimo == false)
                    {
                        menorPrimo = n;
                        banPrimo = true;
                    }
                    else if (n < menorPrimo)
                        menorPrimo = n;
            }

        }
        Console.WriteLine("El mayor de los numeros pares es: " + mayorPar);
        Console.WriteLine("La cantidad de numeros impares es: " + contImp);
        Console.WriteLine("El menor de los numeros primos es: " + menorPrimo);
    }
    static bool primo(int num)
    {
        int con = 0;
        for (int x = 1; x <= num; x++)
        {
            if (num % x == 0)
                con++;
        }
        if (con == 2)
            return true;
        else
            return false;
    }
}