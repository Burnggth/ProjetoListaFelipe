namespace ProjetoListaFelipe.Models;
using System.Text.Json;
public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";
    private Tarefa tarefa1;

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


    public void ListarTarefa()
    {
        if (tarefa1 == null)
        {
            Console.WriteLine("Tarefa1: vazia");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Tarefa1:");
            Console.WriteLine("Titulo: " + tarefa1.Titulo);
            Console.WriteLine("Titulo:" + tarefa1.Descricao);
            string status;

            if (tarefa1.Concluida)
            {
                status = "Concluida";
            }

            else
            {
                status = "Pendente";
            }

        }

        Console.ReadLine();
    }


    public void CarregarDoJson()
    {
        if (File.Exists(caminhoTarefa1))
        {
            string json = File.ReadAllText(caminhoTarefa1);
            tarefa1 = JsonSerializer.Deserialize<Tarefa>(json, options);
        }

        else
        {
            tarefa1 = null;
        }
    }

    

}

