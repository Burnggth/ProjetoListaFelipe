
using ProjetoListaFelipe.Models;

bool cotinuidade = true;
Tarefa tarefa = new Tarefa();



while (cotinuidade)
{
    tarefa.CarregarDoJson();
    Console.Clear();
    Console.WriteLine("== Sistema de Tarefas - turma 3B==");
    Console.WriteLine("1 - Cadastrar Tarefa");
    Console.WriteLine("2 - Listar Tarrefas");
    Console.WriteLine("3 - Concluir Tarefa");
    Console.WriteLine("4 - Remover Tarefa");
    Console.WriteLine("0 - SAIR");

    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        //cadatro de tarefas
        Console.WriteLine("digite um titulo para sua tarefa:");
        string titulo = Console.ReadLine();

        Console.WriteLine("Qual seria a descrição da tarefa:");
        string descricao = Console.ReadLine();

        // Tarefa tarefa = new Tarefa();
        tarefa.CadastrarTarefa(titulo, descricao);


    }

    else if (opcao == "2")
    {
        //listagem de tarefa
        
        tarefa.ListarTarefa();

    }

    else if (opcao == "3")
    {
        //concluir tarefa
        Console.WriteLine("Digite a Tarefa a Ser Comcluida");
        int numero = int.Parse(Console.ReadLine());
        tarefa.ConcluirTarefa(numero);
    }

    else if (opcao == "4")
    {
        //remover tarefa
        Console.WriteLine("Digite a Tarefa a Ser Excluida");
        int numero = int.Parse(Console.ReadLine());
        tarefa.RemoverTarefa(numero);
    }

    else if (opcao == "0")
    {
        cotinuidade = false;
        Console.WriteLine("Programa encerrado");
       
    }


}