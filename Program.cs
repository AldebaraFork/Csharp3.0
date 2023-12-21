// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Schema;

Console.WriteLine("Digite um numero! ");

int NumeroLidos = int.Parse(Console.ReadLine());
int soma = 0;



while (NumeroLidos != 0)
{

    Console.WriteLine("Digite outro numero: ");
    soma = soma + NumeroLidos;
}
Console.WriteLine("O valor dos numeros inseridos é de: " + soma);
