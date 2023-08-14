using System;

class Program
{
 static bool EsPrimo(int numero)
 {
 if (numero <= 1)
    return false;

 if (numero <= 3)
    return true;

  if (numero % 2 == 0 || numero % 3 == 0)
    return false;

  for (int i = 5; i * i <= numero; i += 6)
  {
  if (numero % i == 0 || numero % (i + 2) == 0)
    return false;
  }

    return true;
  }

 static void Main(string[] args)
  {
 Console.Write("Ingrese un número: ");
 int numero = Convert.ToInt32(Console.ReadLine());

 if (EsPrimo(numero))
 {
  Console.WriteLine($"{numero} es un número primo.");
 }
 else
 {
 Console.WriteLine($"{numero} no es un número primo.");
  }
 }
}
