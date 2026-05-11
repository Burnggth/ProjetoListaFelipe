using ProjetoListaFelipe.Models;

namespace ProjetoListaFelipe.Services;


public class TarefaService
{


    private Tarefa tarefa1 = new Tarefa();
    private Tarefa tarefa2 = new Tarefa();
    private Tarefa tarefa3 = new Tarefa();

    private string caminhoTarefa1 = "tarefa1.json";
    private string caminhoTarefa2 = "tarefa2.json";
    private string caminhoTarefa3 = "tarefa3.json";

public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa tarefa = new Tarefa();
        tarefa.Titulo = titulo;
        tarefa.Descricao = descricao;
        tarefa.Concluida = false;
    }
}


