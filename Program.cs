using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testando
{
    class Program

        //Formula do IMC:
        //peso em Kg / pela altura ao quadrado

        //Tabela IMC
        //ABAIXO PESO 18,5
        //PESO NORMAL 18.5- 24,9
        //SOBREPESO 25- 29,90
        //OBESIDADE GRAU I 30- 34,9
        //OBESIDADE GRAU II 30-34,9
        //OBESIDADE GRAU III OU MÓRBIDA MAIOR OU IGUAL A 40
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculo de IMC ");

            Definicao DefinicaoDaAline = new Definicao();

            Console.WriteLine("Digite seu Peso");

            DefinicaoDaAline.peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Altura");

            DefinicaoDaAline.altura = double.Parse(Console.ReadLine());

            double IMC = DefinicaoDaAline.peso / (DefinicaoDaAline.altura * DefinicaoDaAline.altura) ;

            if (IMC < 18.5) {
                Console.WriteLine("Você esta abaixo do peso ");
            }
            else if (IMC >= 18.5 && IMC <= 24.9){
                Console.WriteLine("Seu peso esta normal");
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine("Você esta acima do peso");
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                Console.WriteLine("Você tem obesidade grau I");
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                Console.WriteLine("Você tem obesidade grau II");
            }
            else
            {
                Console.WriteLine("Você tem obesidade grau III");
            }

            Console.WriteLine(IMC);

            Console.ReadLine();
            
        }
    }
}
