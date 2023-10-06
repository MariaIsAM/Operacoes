using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        double resultado = num + num1;


        if(resultado == 0) { Console.WriteLine(" Número invalido"); }
        if (resultado == 1) { Console.WriteLine(" Número invalido"); }
        if (resultado == 3) { Console.WriteLine(" Número invalido"); }
        if (resultado == 4) { Console.WriteLine(" Número invalido"); }

        Console.WriteLine("A multiplicação é: " + resultado );

        Console.ReadKey();
    }


}
