using System.Buffers;
using System.Diagnostics;
using System.Runtime.InteropServices;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1- abrir um arquivo");
    Console.WriteLine("2- Criar um novo arquivo");
    Console.WriteLine("0- Sair");
    short opcao = short.Parse(Console.ReadLine());


    switch(opcao) 
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    
}

static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite o se texto abaixo: ");
    Console.WriteLine("_________________________");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }  
    while (Console.ReadKey().Key != ConsoleKey.Escape);
    
    Console.Write(text);
}