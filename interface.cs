using System;

// Interface representando um atacante
interface IAtacante {
    void Atacar();
}

// Classe abstrata representando um herói
abstract class Heroi {
    // Atributos
    protected string nome;
    protected int pontosDeVida;
    protected int pontosDeMana;

    // Getter para o nome 
    public string GetNome(){
        return nome;
    }
    // Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para pontosDeVida
    public int GetPontosDeVida(){
        return pontosDeVida;
    }
    // Setter para pontosDeVida
    public void SetPontosDeVida(int pontosDeVida){
        this.pontosDeVida = pontosDeVida;
    }
    // Getter para pontosDeMana
    public int GetPontosDeMana(){
        return pontosDeMana;
    }
    // Setter para pontosDeMana
    public void SetPontosDeMana(int pontosDeMana){
        this.pontosDeMana = pontosDeMana;
    }

    // Método abstrato que deve ser implementado pelas subclasses
    public abstract void Especial();
}

// Classe Guerreiro implementando a interface IAtaque e estendendo a classe Heroi
class Guerreiro : Heroi, IAtacante {
    public Guerreiro(string nome, int pontosDeVida, int pontosDeMana) {
        this.nome = nome;
        this.pontosDeVida = pontosDeVida;
        this.pontosDeMana = pontosDeMana;
    }

    public override void Especial() {
        Console.WriteLine("Guerreiro executa habilidade especial!");
    }

    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}

// Classe Mago implementando a interface IAtaque e estendendo a classe Heroi
class Mago : Heroi, IAtacante {
    public Mago(string nome, int pontosDeVida, int pontosDeMana) {
        this.nome = nome;
        this.pontosDeVida = pontosDeVida;
        this.pontosDeMana = pontosDeMana;
    }

    public override void Especial() {
        Console.WriteLine("Mago executa habilidade especial!");
    }

    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
}

// Classe Arqueiro implementando a interface IAtaque e estendendo a classe Heroi
class Arqueiro : Heroi, IAtacante {
    public Arqueiro(string nome, int pontosDeVida, int pontosDeMana) {
        this.nome = nome;
        this.pontosDeVida = pontosDeVida;
        this.pontosDeMana = pontosDeMana;
    }

    public override void Especial() {
        Console.WriteLine("Arqueiro executa habilidade especial!");
    }

    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
}

class Program {
    static void Main(string[] args) {
        // Criando instâncias de diferentes personagens
        Guerreiro guerreiro = new Guerreiro("Guerreiro1", 100, 50);
        Mago mago = new Mago("Mago1", 80, 100);
        Arqueiro arqueiro = new Arqueiro("Arqueiro1", 90, 70);

        // Chamando o método Atacar de cada personagem
        guerreiro.Atacar();
        mago.Atacar();
        arqueiro.Atacar();

        // Chamando o método Especial de cada personagem
        guerreiro.Especial();
        mago.Especial();
        arqueiro.Especial();

        // Exibindo informações dos personagens
        Console.WriteLine($"Nome: {guerreiro.GetNome()}, HP: {guerreiro.GetPontosDeVida()}, MP: {guerreiro.GetPontosDeMana()}");
        Console.WriteLine($"Nome: {mago.GetNome()}, HP: {mago.GetPontosDeVida()}, MP: {mago.GetPontosDeMana()}");
        Console.WriteLine($"Nome: {arqueiro.GetNome()}, HP: {arqueiro.GetPontosDeVida()}, MP: {arqueiro.GetPontosDeMana()}");
    }
}