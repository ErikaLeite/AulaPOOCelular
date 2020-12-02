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
            //CARACTERISTICAS DO APARELHO
            System.Console.WriteLine("Qual o modelo do aparelho?");
            telefone.modelo = Console.ReadLine();
            
            System.Console.WriteLine("Qual a cor do aparelho?");
            telefone.cor = Console.ReadLine();
            
            System.Console.WriteLine("Qual o tamanho?");
            telefone.tamanho = float.Parse(Console.ReadLine());

            //ESTADO DO APARELHO
            System.Console.WriteLine("O telefone está ligado? S/N");
            string escolha = Console.ReadLine(); 

            if(escolha == "S"){
                telefone.status=true;
            }else{
                telefone.status = false;
                System.Console.WriteLine("Não é possível acessar os recursos do aparelho. Ligue e volte mais tarde");
            }


            //MENU
            int menu = 0;
            do
            {
                System.Console.WriteLine("MENU");

                System.Console.WriteLine("[1] - Chamar");
                System.Console.WriteLine("[2] - Enviar Mensagem");
                System.Console.WriteLine("[0] - Desligar Aparelho");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
            {
                case 1:
                    System.Console.WriteLine($"Ligar para");
                    break;
                 case 2:
                    System.Console.WriteLine($"Eviar mensagem");
                    break;
                 case 0:
                    System.Console.WriteLine("Desligando");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }

            } while (menu !=0);
            
            
        }
    }
}
