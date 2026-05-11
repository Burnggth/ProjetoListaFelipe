
bool cotinuidade = true;

while (cotinuidade)
{
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

    }

}