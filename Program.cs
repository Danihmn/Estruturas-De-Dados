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

        Console.WriteLine("====================================="); // Separador para melhor visualização

        // Criando uma árvore e adicionando filhos
        Arvore<string> arvore = new Arvore<string>("Raiz"); // Cria uma nova árvore com a raiz "Raiz"
        arvore.AdicionarFilho(arvore.Raiz, "Filho 1"); // Adiciona um filho à raiz
        arvore.AdicionarFilho(arvore.Raiz, "Filho 2"); // Adiciona outro filho à raiz

        ArvoreNos<string> filho1 = arvore.Raiz.Filho[0]; // Acessando o primeiro filho da raiz
        filho1.Filho.Add(new ArvoreNos<string>("Neto 1")); // Adiciona um neto ao primeiro filho
        filho1.Filho.Add(new ArvoreNos<string>("Neto 2")); // Adiciona outro neto

        ArvoreNos<string> neto1 = filho1.Filho[0]; // Acessando o primeiro neto do primeiro filho
        neto1.Filho.Add(new ArvoreNos<string>("Bisneto 1")); // Adiciona um bisneto ao primeiro neto
        neto1.Filho.Add(new ArvoreNos<string>("Bisneto 2")); // Adiciona outro bisneto

        // Percorrendo a árvore
        arvore.Percorrer(arvore.Raiz); // Chama o método para percorrer a árvore a partir da raiz

        Console.WriteLine("====================================="); // Separador para melhor visualização

        // Criando uma árvore binária e adicionando elementos
        ArvoreBinaria arvoreBinaria = new ArvoreBinaria(); // Cria uma nova árvore binária
        arvoreBinaria.Inserir(10);
        arvoreBinaria.Inserir(20);
        arvoreBinaria.Inserir(30);
        arvoreBinaria.Inserir(40);

        arvoreBinaria.Iniciar();
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

// Classe para representar os nós da árvore
public class ArvoreNos<A>
{
    public A Valor; // Valor a ser definido na instância
    public List<ArvoreNos<A>> Filho; // Nó filho que será inserido nos demais nós que foremm criados

    public ArvoreNos(A valor)
    {
        // Inicializando o valor da lista e a lista de filhos
        Valor = valor;
        Filho = new List<ArvoreNos<A>>();
    }
}

// Classe para representar a árvore em si
public class Arvore<A>
{
    public ArvoreNos<A> Raiz; // Nó principal

    public Arvore(A valor)
    {
        // Ao intanciar a árvore, já deve informar o valor da raiz
        Raiz = new ArvoreNos<A>(valor);
    }

    // Método para adicionar um filho a um nó pai
    public void AdicionarFilho(ArvoreNos<A> pai, A valor) // Deve passar o nó pai que será inserido e o valor a ser inserido
    {
        pai.Filho.Add(new ArvoreNos<A>(valor)); // Adiciona o filho à lista de elementos filhos
    }

    // Méodo para percorrer a árvore
    public void Percorrer(ArvoreNos<A> no)
    {
        if (no != null)
        {
            Console.WriteLine(no.Valor); // Exibe o valor do nó atual

            // Percorre e a cada iteração chama o método recursivamente
            foreach (ArvoreNos<A> filhos in no.Filho)
            {
                Percorrer(filhos); // Chama o método recursivamente para cada filho
            }
        }
    }
}

public class ArvoreBinariaNos
{
    public int Valor;
    public ArvoreBinariaNos Esquerda;
    public ArvoreBinariaNos Direita;

    public ArvoreBinariaNos(int valor)
    {
        Valor = valor; // Inicializa o valor do nó
        Esquerda = null; // Inicializa o nó esquerdo como nulo
        Direita = null; // Inicializa o nó direito como nulo
    }
}

// Classe que representa os nós da árvore
public class ArvoreBinaria
{
    public ArvoreBinariaNos Raiz; // Define a raiz como nó principal

    public ArvoreBinaria()
    {
        Raiz = null;
    }

    // Adiciona ao nó principal um valor
    public void Inserir(int valor)
    {
        Raiz = AdicionarElemento(Raiz, valor);
    }

    // Método que adiciona os elementos na árvore binária
    public ArvoreBinariaNos AdicionarElemento(ArvoreBinariaNos no, int valor)
    {
        if (no == null)
        {
            no = new ArvoreBinariaNos(valor); // Se o nó for nulo, cria um novo nó com o valor
            return no; // Retorna o novo nó
        }

        if (valor < no.Valor)
        {
            no.Esquerda = AdicionarElemento(no.Esquerda, valor);
        }
        else
        {
            no.Direita = AdicionarElemento(no.Direita, valor);
        }

        return no; // Retorna o nó atualizado
    }

    public void Percorrer(ArvoreBinariaNos raiz)
    {
        if (raiz != null)
        {
            Percorrer(raiz.Esquerda); // Percorre a subárvore esquerda
            Console.Write(raiz.Valor + " "); // Exibe o valor do nó atual
            Percorrer(raiz.Direita); // Percorre a subárvore direita
        }
    }

    public void Iniciar()
    {
        Percorrer(Raiz);
    }
}