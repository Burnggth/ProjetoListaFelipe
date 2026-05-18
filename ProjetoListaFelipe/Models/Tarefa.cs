namespace ProjetoListaFelipe.Models;
using System.Text.Json;
public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";

    private JsonSerializerOptions options = new JsonSerializerOptions()
    {
        WriteIndented = true,
        IncludeFields = true,
    };

    //private Tarefa tarefa1 = new Tarefa();

    public void CadastrarTarefa(string titulo, string descricao)
    {
        Tarefa novatarefa = new Tarefa();
        novatarefa.Titulo = titulo;
        novatarefa.Descricao = descricao;
        novatarefa.Concluida = false;

        //tarefa1 = novatarefa;
        string json = JsonSerializer.Serialize(novatarefa,options);
        File.WriteAllText(caminhoTarefa1,json);

        Console.WriteLine("Tarefa Cadastrada com SUCESS!");

    }
}

