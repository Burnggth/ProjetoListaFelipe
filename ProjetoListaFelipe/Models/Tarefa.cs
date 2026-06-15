namespace ProjetoListaFelipe.Models;
using System.Text.Json;
public class Tarefa
{
    public string Titulo = "";
    public string Descricao = "";
    public bool Concluida;

    private string caminhoTarefa1 = "tarefa1.json";
    private string caminhoTarefa2 = "tarefa2.json";
    private string caminhoTarefa3 = "tarefa3.json";

    private Tarefa tarefa1;
    private Tarefa tarefa2;
    private Tarefa tarefa3;

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

        if (tarefa1 == null || tarefa1.Titulo == "")
        {
            string json = JsonSerializer.Serialize(novatarefa, options);
            File.WriteAllText(caminhoTarefa1, json);

            Console.WriteLine("");
            Console.ReadLine();
        }

        else if (tarefa2 == null || tarefa2.Titulo == "")
        {
            string json = JsonSerializer.Serialize(novatarefa, options);
            File.WriteAllText(caminhoTarefa2, json);

            Console.WriteLine("");
            Console.ReadLine();
        }
       
        else if (tarefa3 == null || tarefa3.Titulo == "")
        {
            string json = JsonSerializer.Serialize(novatarefa, options);
            File.WriteAllText(caminhoTarefa3, json);

            Console.WriteLine("");
            Console.ReadLine();
        }



    }


    public void ListarTarefa()
    {
        if (tarefa1 == null || tarefa1.Titulo == "")
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
            Console.WriteLine("Status:" + status);
        }

        Console.ReadLine();

        if (tarefa2 == null || tarefa2.Titulo == "")
        {
            Console.WriteLine("Tarefa2: vazia");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Tarefa2:");
            Console.WriteLine("Titulo: " + tarefa2.Titulo);
            Console.WriteLine("Titulo:" + tarefa2.Descricao);
            string status;

            if (tarefa2.Concluida)
            {
                status = "Concluida";
            }

            else
            {
                status = "Pendente";
            }
            Console.WriteLine("Status:" + status);
        }

        Console.ReadLine();

        if (tarefa3 == null || tarefa3.Titulo == "")
        {
            Console.WriteLine("Tarefa3: vazia");
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Tarefa3:");
            Console.WriteLine("Titulo: " + tarefa3.Titulo);
            Console.WriteLine("Titulo:" + tarefa3.Descricao);
            string status;

            if (tarefa3.Concluida)
            {
                status = "Concluida";
            }

            else
            {
                status = "Pendente";
            }
            Console.WriteLine("Status:" + status);
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

        if (File.Exists(caminhoTarefa2))
        {
            string json = File.ReadAllText(caminhoTarefa2);
            tarefa2 = JsonSerializer.Deserialize<Tarefa>(json, options);
        }

        else
        {
            tarefa2 = null;
        }

        if(File.Exists(caminhoTarefa3))
        {
            string json = File.ReadAllText(caminhoTarefa3);
            tarefa3 = JsonSerializer.Deserialize<Tarefa>(json, options);
        }

        else
        {
            tarefa3 = null;
        }
    }

    public void ConcluirTarefa(int numero)
    {
        if (numero == 1)
        {
           tarefa1.Concluida = true;
            string json = JsonSerializer.Serialize(tarefa1, options);
            File.WriteAllText(caminhoTarefa1, json);

            Console.WriteLine("Tarefa 1 marcada como concluida.");
            Console.ReadLine();
        }

        else if (numero == 2)
        {
            tarefa3.Concluida = true;
            string json = JsonSerializer.Serialize(tarefa3, options);
            File.WriteAllText(caminhoTarefa2, json);

            Console.WriteLine("Tarefa 2 marcada como concluida.");
            Console.ReadLine();
        }
        
        else if (numero == 3)
        {
            tarefa3.Concluida = true;
            string json = JsonSerializer.Serialize(tarefa3, options);
            File.WriteAllText(caminhoTarefa3, json);

            Console.WriteLine("Tarefa 3 marcada como concluida.");
            Console.ReadLine();
        }
    }

    public void RemoverTarefa(int numero)
    {
        if (numero == 1)
        {
            string json = JsonSerializer.Serialize(new Tarefa(), options);
            File.WriteAllText(caminhoTarefa1, json);
        }

        else if (numero == 2)
        {
            string json = JsonSerializer.Serialize(new Tarefa(), options);
            File.WriteAllText(caminhoTarefa2, json);
        }

        else if (numero == 3)
        {
            string json = JsonSerializer.Serialize(new Tarefa(), options);
            File.WriteAllText(caminhoTarefa3, json);
        }
    }
}

