class Program
{
    static void Main()
    {
        Listas.Exibir(); // Chama o método para trabalhar com listas encadeadas
        Dicionarios.Exibir();
    }
}

public class Listas
{
    static public void Exibir()
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
    static public void Exibir()
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