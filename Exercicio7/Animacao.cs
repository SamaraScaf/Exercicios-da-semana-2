using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio7
{
    public static class Animacao
    {
     public static void Filme(){
        Console.WriteLine("Animação Frozen");
     }
     public static void Filme(string tipo){
        Console.WriteLine ("Animação {0}", tipo);
        }
     }
    }