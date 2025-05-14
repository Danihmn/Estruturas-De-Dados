class Program
{
    static void Main()
    {
        Listas.Exibir(); // Chama o método para trabalhar com listas encadeadas

        Console.WriteLine("====================================="); // Separador para melhor visualização

        Dicionarios.Exibir(); // Chama o método para trabalhar com dicionários

        Console.WriteLine("====================================="); // Separador para melhor visualização

        Pilhas.Exibir(); // Chama o método para trabalhar com pilhas

        Console.WriteLine("====================================="); // Separador para melhor visualização

        Filas.Exibir(); // Chama o método para trabalhar com filas
    }
}

public class Listas
{
    public static void Exibir()
    {
        LinkedList<int> listaEncadeada = new LinkedList<int>();

        // Adicionando elementos à lista encadeada
        listaEncadeada.AddLast(1);
        listaEncadeada.AddLast(2);
        listaEncadeada.AddFirst(0);

        // Exibindo os elementos da lista encadeada
        LinkedListNode<int> no; // Criando um nó para percorrer a lista
        no = listaEncadeada.Find(2); // Encontrando o nó com valor 2

        listaEncadeada.AddAfter(no, 50); // Adicionando 50 após o nó encontrado

        foreach (int valor in listaEncadeada)
        {
            Console.WriteLine(valor); // Exibindo os valores da lista encadeada
        }
    }
}

public class Dicionarios
{
    public static void Exibir()
    {
        Dictionary<string, string> dicionario = new Dictionary<string, string>()
        {
            { "Nome", "Lucas" },
            { "Idade", "25" },
            { "País", "Itália" }
        };

        foreach (KeyValuePair<string, string> item in dicionario)
        {
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}"); // Exibindo chave e valor do dicionário
        }
    }
}

public class Pilhas
{
    public static void Exibir()
    {
        Stack<int> pilha = new Stack<int>();

        // Adicionando elementos
        pilha.Push(12);
        pilha.Push(13);
        pilha.Push(14);

        pilha.Pop(); // Remove o elemento do topo da pilha

        foreach (int valor in pilha)
        {
            Console.WriteLine(valor); // Exibindo os valores da pilha
        }
    }
}

public class Filas
{
    public static void Exibir()
    {
        Queue<int> fila = new Queue<int>();

        // Adicionando elementos
        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);

        fila.Dequeue(); // Remove o elemento do início da fila

        foreach (int item in fila)
        {
            Console.WriteLine(item); // Exibindo os valores da fila
        }
    }
}