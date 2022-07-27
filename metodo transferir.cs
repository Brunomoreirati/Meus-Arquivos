using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace metodo_transferir
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta1 = new Conta();
            conta1.saldo = 1000;

            Conta conta2 = new Conta();
            conta2.saldo = 500;


            Console.WriteLine("Quanto você deseja transferir?");
            double valor = Convert.ToDouble(Console.ReadLine());

            //Agora vamos transferir o dinheiro da conta1 para a conta2
            conta1.transfere(valor,conta2);





            //Coloque comando para escrever na tela o saldo das duas contas.

            Console.WriteLine("Seu saldo é de :  $ " + conta1.saldo);
            Console.WriteLine("Seu saldo é de : $  " + conta2.saldo);
            Console.WriteLine("Você acabou de realizar uma transação no valor de : " + valor);


            Console.ReadKey();

        }
        class Conta
        {
            public int numero;
            public string titular;
            public double saldo;
            public double valor;
            

            public void Saca(double valor)
            {
                if (this.saldo >= valor)
                {
                    this.saldo -= valor;
                }
                
            }
            public void transfere(double valor, Conta destino)
            {
                if (this.saldo < valor)
                {
                    Console.WriteLine("Saldo insuficiente para tranferir o valor desejado!");
                }
                else
                {

                    //implementar o metodo tranferir aqui, o que a questão pede.
                    this.saldo -=valor;
                    destino.saldo+=valor;
                    

                   

                }


            }
        }

    }

}
