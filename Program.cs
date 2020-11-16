using System;

namespace Calculo_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma empresa decide dar aumento de 30% aos funcionários cujo salário é
            //inferior a 500 reais. Escreva um programa que receba o salário de um
            //funcionário e imprima o valor do salário reajustado ou uma mensagem
            //caso o funcionário não tenha direito a aumento.

            double reajuste;
            double salario = 0;
            

            Console.WriteLine("Informe seu salário:");
            salario = double.Parse(Console.ReadLine());

            if(salario <= 500){
                
                reajuste = (salario * 0.3)+salario;
                Console.WriteLine("Seu salário foi reajustado para: R$ "+reajuste);

            }else

                Console.WriteLine("Você não está elegível ao reajuste salarial");
      
        }
    }
}
