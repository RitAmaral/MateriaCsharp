using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calculadora
    {
        
        public static int Soma(int n1, int n2) //primeiro construtor
        { 
            return n1 + n2; 
        }

        public static int Soma(int n1, int n2, int n3) //segundo construtores
        {
            return n1 + n2 + n3;
        }

        public static int Soma(int n1, int n2, int n3, int n4) //terceiro construtor
        {
            return n1 + n2 + n3 + n4;
        }
        //fazer isto imensas vezes, ou fazer vetor:
        /*
        public static int Sum(int[] numeros) //definição do nosso vetor
        {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) //numeros.length: vai percorrer todo o comprimento do vetor numeros
            {
                sum += numeros[i];
            }
            return sum;
        }
        */
        //Params - não temos de tar sempre a instanciar o vetor (new int[]) no main program.cs
        //Params: uma calculadora para calcular a soma de uma quantidade variável de valores
        public static int Sum(params int[] numeros) 
        {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) 
            {
                sum += numeros[i];
            }
            return sum;
        }
    }
}
