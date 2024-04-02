public class Pessoa{
    private String nome;
    private int idade;
    private string cpf;
    //Construtor da classe Pessoa
    public Pessoa(string nome, int idade, string cpf){
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }
    //Propriedades da classe Pessoa que permite acesso controlado
    public string Nome{
        get {return nome;}
        set {nome=value;}
    }
    public int Idade{
        get{return idade;}
        set{idade=value;}
    }
    public string CPF{
        get{return cpf;}
        set{cpf=value;}
    }
}    
