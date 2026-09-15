# TextEdition

Um editor de texto simples desenvolvido em C# para praticar manipulação de arquivos, entrada de teclado, estruturas de controle e tratamento de erros.

## Funcionalidades

* Criar novos arquivos de texto
* Abrir arquivos existentes
* Adicionar conteúdo a arquivos existentes e salvá-los novamente.
* Salvar arquivos
* Usar `Enter` para criar novas linhas
* Usar `Backspace` para apagar caracteres
* Usar `ESC` para finalizar a edição
* Tratamento de erros ao abrir ou salvar arquivos

## Tecnologias

* C#
* .NET 10

## Como executar

### Pré-requisitos

É necessário ter o .NET SDK instalado.

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/gustavoschmittt/TextEdition.git
```

Entre na pasta do projeto:

```bash
cd TextEdition
```

Execute:

```bash
dotnet run
```

## Como usar

Ao iniciar o programa, será exibido um menu com as opções:

```text
1- Abrir um arquivo
2- Criar um novo arquivo
0- Sair
```

Ao criar ou editar um arquivo, utilize:

* `Enter` para criar uma nova linha
* `Backspace` para apagar o último caractere
* `ESC` para finalizar a edição

## Objetivo do projeto

Este projeto foi desenvolvido como prática de programação em C#, com foco em:

* Métodos e organização do código
* Estruturas `if`, `switch` e `do/while`
* Manipulação de `string`
* Leitura e escrita de arquivos
* `Console.ReadKey()` e `ConsoleKeyInfo`
* Tratamento de exceções com `try/catch`
* Validação de entradas do usuário

## Observações

O TextEdition é um projeto de estudo e possui uma implementação simples de edição de texto. O objetivo principal é praticar os fundamentos de C# e manipulação de arquivos.
