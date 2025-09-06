// Declaração da lista de tarefas
List<Tarefa> tarefas = new List<Tarefa>();

// Solicita a entrada do usuário
Console.WriteLine("Adicione uma nova tarefa: ");
string descricaoDaTarefa = Console.ReadLine();

// Cria uma nova tarefa e preenche com a descrição
Tarefa novaTarefa = new Tarefa();
novaTarefa.Descricao = descricaoDaTarefa;

// Adiciona a nova tarefa na lista
tarefas.Add(novaTarefa);
Console.WriteLine($"Tarefa '{descricaoDaTarefa}' foi adicionada com sucesso!");

foreach (Tarefa tarefa in tarefas)
{
    Console.WriteLine(tarefa.Descricao);
}

int numeroDaTarefa = 1;
foreach (Tarefa tarefa in tarefas)
{
    Console.WriteLine($"{numeroDaTarefa}. {tarefa.Descricao}");
    numeroDaTarefa++;
}

Console.WriteLine("Digite a tarefa que você deseja concluir:");
int numeroDaTarefaSelecionada = int.Parse(Console.ReadLine());
