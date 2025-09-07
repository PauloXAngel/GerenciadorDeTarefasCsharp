// Declaração da lista de tarefas
List<Tarefa> tarefas = new List<Tarefa>();

// Solicita a entrada do usuário para a primeira tarefa
Console.WriteLine("adicione uma nova tarefa");
string descricaoDaTarefa = Console.ReadLine();

// Cria uma nova tarefa e preenche com a descrição
Tarefa novaTarefa = new Tarefa();
novaTarefa.Descricao = descricaoDaTarefa;

// Adiciona a nova tarefa na lista
tarefas.Add(novaTarefa);

Console.WriteLine($"Tarefa '{descricaoDaTarefa}' foi adicionada com sucesso!");

// Lista todas as tarefas com numeração
Console.WriteLine("\nSuas tarefas:");
int numeroDaTarefa = 1;
foreach (Tarefa tarefa in tarefas)
{
    Console.WriteLine($" {numeroDaTarefa}. {tarefa.Descricao}");
    numeroDaTarefa++;
}

// --- NOVO CÓDIGO AQUI ---
// Pergunta ao usuário qual tarefa ele quer concluir
Console.WriteLine("\nPor favor, digite o número da tarefa que você deseja concluir:");

// Lê o número que o usuário digitou e salva na variável
int numeroDaTarefaSelecionada = int.Parse(Console.ReadLine());

// --- FIM DO NOVO CÓDIGO ---

// A gente precisa de um jeito de encontrar a tarefa que o usuário selecionou
// e depois mudar a propriedade 'Concluida' dela para 'true'.