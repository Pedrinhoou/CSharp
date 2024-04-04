public class Produto{
    private String nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    //Construtor da classe Pessoa
    public Pessoa(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }
    //Propriedades da classe Pessoa que permite acesso controlado
    public string Nome{
        get {return nome;}
        set {nome=value;}
    }
    public decimal Preco{
        get{return preco;}
        set{preco=value;}
    }
    public string Descricao{
        get{return descricao;}
        set{descricao=value;}
    }
     public string Categoria{
        get{return categoria;}
        set{categoria=value;}
    }
} 

public class ConsoleGame : Produto{
    private int capacidadeArmazenamento;

    // Construtor da classe Estudante
    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento) : base(nome, preco, descricao, categoria){
        capacidadeArmazenamento = capacidadeArmazenamento;
    }

    //Propriedades da classe Estudante que permite acesso controlado a um campo privado
    public int CapacidadeArmazenamento{
        get { return capacidadeArmazenamento;}
        set {capacidadeArmazenamento = value;}
    }
}

public class Jogo : Produto {
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria){
        Genero = genero
    }
    public string Genero {
        get {return genero;}
        set {genero = value;}
    }
}

public class Acessorio : Produto {
     private string tipo;

    //Construtor da classe Gerente
    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria){
        Tipo = tipo
    }
    public string Tipo {
        get {return tipo;}
        set {tipo = value;}
    }
}

public class Colecionavel : Produto {
     private bool edicaoLimitada;

    //Construtor da classe Gerente
    public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaoLimitada
    }
    public string EdicaoLimitada {
        get {return edicaoLimitada;}
        set {edicaoLimitada = value;}
    }
}

public class Program {

    public static void main (String[] args){
        Produto produto;
        produto = new ConsoleGame("PlayStation 5", 3.500, "Console de Vídeo Game PlayStation 5 com 1 Tera de armazenamento", "Console", 1024000)

        Jogo jogo = new Jogo("FIFA PREMIUM LIMITADO ALL TIME", 1.000, "Jogo completo FIFA PREMIUM LIMITADO ALL TIME para PS5", "Jogo", "Esportes e Futebol")

        Acessorio acessorio = new Acessorio("Controle PS5 EDIÇÃO LIMITADA FIFA", 1.200, "Controle PS5 Original com peças exclusivas tematizado FIFA", "Acessorio", "Controle")

        Colecionavel colecionavel = new Colecionavel("Action Figure EXCLUSIVA do Cristiano Ronaldo", 8.000, "Action figure exclusivo CR7 ultra realista", "Colecionavel", 
        "edição especial limitada")
    }
}