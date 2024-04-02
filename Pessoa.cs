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
public class Estudante : Pessoa{
    private String curso;

    // Construtor da classe Estudante
    public Estudante(string nome, int idade, string cpf, string curso) ; base(nome, idade, cpf){
        Curso = curso;
    }

    //Propriedades da classe Estudante que permite acesso controlado a um campo privado
    public string Curso{
        get { return curso;}
        set {curso = value;}
    }
}
public class Funcionario : Pessoa {
    private double salario;

    public double Bonus(){
        return salario * 0.1;
    }

    public Funcionario(string nome, int idade, string cpf, double salario) : base(nome,idade,cpf){
        Salario = salario
    }


    public string Salario {
        get {return salario;}
        set {salario = value;}
    }
}
public class Diretor : Funcionario {

    //Construtor da classe Gerente
    public Diretor(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf, salario){
        //
    }
    //Sobrescrevendo o método Bonus para adicionar 1000 ao bônus
    public override double Bonus {
        return base.Bonus() + 1000;
    }
}
