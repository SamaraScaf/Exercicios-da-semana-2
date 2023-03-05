using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class FichaDeInscricao
    {
    public int Id { get; set; }

    public string Nome { get; set; }

    public DateTime DataDeNasc {get; set;}

    public bool MenorIdade {get; set;}

public FichaDeInscricao (int id, string nome, DateTime dataDeNasc, bool menorIdade){
    this.Id = id;
    this.Nome = nome;
    this.DataDeNasc = dataDeNasc;
    this.MenorIdade = menorIdade;
    string textoIdade;
    if (MenorIdade){
        textoIdade = "É menor de idade.";}
    else { 
        textoIdade = "É maior de idade.";}
    Console.WriteLine ($"Id = {Id}, Nome = {Nome}, Data de Nascimento = {DataDeNasc:dd/MM/yyyy} e {textoIdade}");
    }
}
    }
