using System;

class Personagem {
    // Atributos
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;

    // Construtor
    public Personagem(string nome; string cor; int idade; double altura, char genero) {
    this.nome = nome;
    this.cor = cor;
    this.idade = idade;
    this.altura = altura;
    this.genero = genero;
    }
    //Metodos
    public void infoPersonagem(){
        Console.WriteLine($"Nome:{nome}, idade:{idade}, altura:{altura}, genero:{genero}");
    }
    private void correr(){
        Console.WriteLine("Correndo. ");
    }
    private.void pular(){
        Console.WriteLine("Pulando. ")
    }
}