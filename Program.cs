using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem. - Só será possível executar tais métodos se o celular estiver ligado.

            Celular telefone = new Celular();

            Console.WriteLine("CELULAR");
            System.Console.WriteLine("O telefone está ligado?");
            telefone.status = bool.Parse(Console.ReadLine());
            
        }
    }
}
