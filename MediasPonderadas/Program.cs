using System;
using System.Globalization;

namespace MediasPonderadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verifica a quantidade de repetição que as notas serão inseridas.
            int n = int.Parse(Console.ReadLine());                
            
            for (int i = 0; i < n; i++)
            {
                //Efetua a leitura dos valores e recorta os valores separados por "espaço".
                string[] vet = Console.ReadLine().Split(' ');
                double nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                //Cálculo da média final.
                double total = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / 10.0;

                Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
            }            
            
        }
    }
}
