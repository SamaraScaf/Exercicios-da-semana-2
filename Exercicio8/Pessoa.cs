using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio8;

    public class Pessoa
    {
    public string Nome {get; set;}
    public DateTime DataDeNasc {get; set;}


    public Pessoa(string nome, DateTime dataDeNasc){
    Nome = nome;
    DataDeNasc = dataDeNasc;
    }

    private int CalcularIdade(){
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - DataDeNasc.Year;
        if (DataDeNasc > dataAtual.AddYears (-idade)){
        idade--;
        }
        return idade;
    }
    public void MostrarIdade(){
    Console.WriteLine ($"Nome: {Nome}. Idade {CalcularIdade()}");
     }
    }

