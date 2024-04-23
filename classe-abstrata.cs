using System;

// Classe abstrata Veiculo
public abstract class Veiculo
{
    // Atributos
    private string marca;
    private string modelo;

    // Construtor
    public Veiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    // Métodos de acesso para a marca
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    // Métodos de acesso para o modelo
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    // Método abstrato para acelerar
    public abstract void Acelerar();

    // Método abstrato para frear
    public abstract void Frear();

    // Método virtual para ligar o veículo (pode ser sobrescrito nas classes derivadas)
    public virtual void Ligar()
    {
        Console.WriteLine($"O veículo {marca} {modelo} está ligado.");
    }

    // Método virtual para desligar o veículo (pode ser sobrescrito nas classes derivadas)
    public virtual void Desligar()
    {
        Console.WriteLine($"O veículo {marca} {modelo} está desligado.");
    }
}

// Classe derivada Carro
public class Carro : Veiculo
{
    // Atributos
    private int numeroDePortas;

    // Construtor
    public Carro(string marca, string modelo, int numeroDePortas)
        : base(marca, modelo)
    {
        this.numeroDePortas = numeroDePortas;
    }

    // Método de acesso para o número de portas
    public int NumeroDePortas
    {
        get { return numeroDePortas; }
        set { numeroDePortas = value; }
    }

    // Implementação do método abstrato Acelerar
    public override void Acelerar()
    {
        Console.WriteLine($"O carro {Marca} {Modelo} está acelerando.");
    }

    // Implementação do método abstrato Frear
    public override void Frear()
    {
        Console.WriteLine($"O carro {Marca} {Modelo} está freando.");
    }

    // Sobrescrita do método virtual Ligar
    public override void Ligar()
    {
        Console.WriteLine($"O carro {Marca} {Modelo} está ligado.");
    }

    // Sobrescrita do método virtual Desligar
    public override void Desligar()
    {
        Console.WriteLine($"O carro {Marca} {Modelo} está desligado.");
    }
}

// Classe derivada Moto
public class Moto : Veiculo
{
    // Atributo
    private bool temSidecar;

    // Construtor
    public Moto(string marca, string modelo, bool temSidecar)
        : base(marca, modelo)
    {
        this.temSidecar = temSidecar;
    }

    // Método de acesso para o atributo temSidecar
    public bool TemSidecar
    {
        get { return temSidecar; }
        set { temSidecar = value; }
    }

    // Implementação do método abstrato Acelerar
    public override void Acelerar()
    {
        Console.WriteLine($"A moto {Marca} {Modelo} está acelerando.");
    }

    // Implementação do método abstrato Frear
    public override void Frear()
    {
        Console.WriteLine($"A moto {Marca} {Modelo} está freando.");
    }

    // Sobrescrita do método virtual Ligar
    public override void Ligar()
    {
        Console.WriteLine($"A moto {Marca} {Modelo} está ligada.");
    }

    // Sobrescrita do método virtual Desligar
    public override void Desligar()
    {
        Console.WriteLine($"A moto {Marca} {Modelo} está desligada.");
    }
}

// Classe de teste
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto de Carro com marca, modelo e número de portas
        Veiculo meuCarro = new Carro("Toyota", "Corolla", 4);

        // Criando um objeto de Moto com marca, modelo e indicação de sidecar
        Veiculo minhaMoto = new Moto("Honda", "CBR", false);

        // Testando o carro
        Console.WriteLine("Testando o carro:");
        meuCarro.Ligar();
        meuCarro.Acelerar();
        meuCarro.Frear();
        meuCarro.Desligar();

        Console.WriteLine();

        // Testando a moto
        Console.WriteLine("Testando a moto:");
        minhaMoto.Ligar();
        minhaMoto.Acelerar();
        minhaMoto.Frear();
        minhaMoto.Desligar();
    }
}