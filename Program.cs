
Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer?");
    Console.WriteLine("1- Abrir um arquivo");
    Console.WriteLine("2- Criar um novo arquivo");
    Console.WriteLine("0- Sair");
    if (!short.TryParse(Console.ReadLine(), out short opcao))
    {
        Menu();
        return;
    }

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
     Console.Clear();
     Console.WriteLine("Qual o caminho do arquivo: ");
     string path = Console.ReadLine() ?? string.Empty;

    string text = "";
    
    if (File.Exists(path))
    {
        using (var file = new StreamReader(path))
        {
            text = file.ReadToEnd();
            Console.WriteLine(text);
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Arquivo não encontrado, tente novamente!");
        Thread.Sleep(1500);
        Menu();
        return;
    }

    Console.WriteLine("");
    Console.WriteLine("Deseja editar esse arquivo?      S = Sim || N = Não");
    
    string? opcao = Console.ReadLine()?.ToUpper();

    if( opcao == "S")
    {
        Editar(path, text);
    }else if ( opcao == "N")
    {
        Console.WriteLine("Voltando para o menu");
        Thread.Sleep(1500);
        Menu();
        return;
    }else{ 
        Console.WriteLine("Opção não válida");
        Thread.Sleep(1500);
        Menu();
        return;
    }
}

static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite o seu texto abaixo:                      (ESC para sair) ");
    Console.WriteLine("___________________________");
    string text = "";
    ConsoleKeyInfo tecla; 

    do
    {       
        tecla = Console.ReadKey(true);
        
            switch (tecla.Key)
            {
                 case ConsoleKey.Escape:
                    break;
            
                 case ConsoleKey.Enter:
                    text += Environment.NewLine;
                    Console.WriteLine();
                    break;
            
                 case ConsoleKey.Backspace:
                    if (text.Length > 0 && !text.EndsWith(Environment.NewLine))
                    {
                        text = text.Substring(0, text.Length -1);
                        Console.Write("\b \b");
                    }
                    break;
            
                default:
                    text += tecla.KeyChar;
                    Console.Write(tecla.KeyChar);
                    break;
            }
    
    } while (tecla.Key != ConsoleKey.Escape);

    Salvar("",text);
}

static void Salvar(string path, string text)
{
    try
    {
         Console.Clear();
        if (string.IsNullOrWhiteSpace(path))
        {
            Console.WriteLine("Qual o caminho para salvar o arquivo: ");
            path  = Console.ReadLine() ?? string.Empty;
        }

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Não foi possível salvar o arquivo");
        Thread.Sleep(2000);
        Menu();
        return;
    }
   
    Console.WriteLine($"Arquivo salvo no caminho {path} com sucesso!! ");
    Thread.Sleep(1500);
    Console.WriteLine("Voltando ao menu");
    Thread.Sleep(1000);
    Menu();
}

static void Editar(string path ,string text)
{
    Console.Clear();
    Console.WriteLine("Editando o texto escolhido:                    (ESC para encerrar a edição)");
    Console.WriteLine("");
    Console.WriteLine(text);
    string newText = text;
    ConsoleKeyInfo tecla;

    do
    {       
        tecla = Console.ReadKey(true);
        
            switch (tecla.Key)
            {
                 case ConsoleKey.Escape:
                    break;
            
                 case ConsoleKey.Enter:
                    newText += Environment.NewLine;
                    Console.WriteLine();
                    break;
            
                 case ConsoleKey.Backspace:
                    if (newText.Length > 0 && !newText.EndsWith(Environment.NewLine))
                    {
                        newText = newText.Substring(0, newText.Length -1);
                        Console.Write("\b \b");
                    }
                    break;
            
                default:
                    newText += tecla.KeyChar;
                    Console.Write(tecla.KeyChar);
                    break;
            }
    
    } while (tecla.Key != ConsoleKey.Escape);


    text = newText;
    Salvar(path,text);
}