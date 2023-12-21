// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Globalization;

int A, B, C, D, dif;

Console.WriteLine("Porfavor Insira o primeiro numero: ");
A = int.Parse(Console.ReadLine());
Console.WriteLine("Porfavor Insira o segundo numero: ");
B = int.Parse(Console.ReadLine());
Console.WriteLine("Porfavor Insira o terceiro numero: ");
C = int.Parse(Console.ReadLine());
Console.WriteLine("Porfavor Insira o quarto numero: ");
D = int.Parse(Console.ReadLine());

dif = A * B - C * D;

Console.WriteLine("DIFERENCA = " + dif);
        