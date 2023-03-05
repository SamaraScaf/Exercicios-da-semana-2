using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Guitarra
    {
        private static string Afinacao {get; set;}

        static Guitarra(){
            Afinacao = "SOL";
        }

        private void TomAfinado(){
        Console.WriteLine ($"A guitarra está com afinação em {Afinacao}");
        }

        public void Tocar(){
            TomAfinado();
        }

        public void Tocar(string afinaçãoAtual){
        Afinacao = afinaçãoAtual;
        TomAfinado();
        }

    }
}