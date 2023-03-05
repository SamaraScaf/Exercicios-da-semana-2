using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class MensagemCelular
    {
    public int Telefone { get; set; }
    public string Mensagem { get; set; }

public MensagemCelular (int telefone, string mensagem){
this.Telefone = telefone;
this.Mensagem = mensagem;
}
public void Executar(){
Console.WriteLine ("Método Executado pelo Console");
EnviarMensagemAoTelefone();
}
        private void EnviarMensagemAoTelefone(){
Console.WriteLine("Método privado executado na classe");
Console.WriteLine($"Telefone {Telefone} , Mensagem {Mensagem}");
        }
    }
}

