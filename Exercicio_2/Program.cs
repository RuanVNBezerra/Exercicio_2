using System.Text.RegularExpressions;

namespace Exercicio_2;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma placa de carro: ");
        var placa = Console.ReadLine();
        /*
         chama o método (APlacaEValida) passando a placa digitada como argumento. 
         Esse verifica se a placa está no formato correto.
         */
        if (APlacaEValida(placa)) 
        {
            Console.WriteLine("A placa é valida");
        }
        else
        {
            Console.WriteLine("A placa não é valida!");
        }
    }

    //criando uma função estatica booleana para ver se a placa é valida ou não.
    //aqui retorna true caso a placa for valida e false caso não seja valida.
    static bool APlacaEValida(string? placa) // colocando "?" em string, para indicar que a variável "placa" pode ser null.
    {
        // verifica se a placa é nula ou vazia e se não possui exatamente 7 caracteres.
        if (string.IsNullOrEmpty(placa) || placa.Length != 7)
        {
            return false;
        }
        // verifica se a placa corresponde ao padrão valido até 2018.
        //3 letras 4 numeros
        var Regex = new Regex("^[a-zA-Z]{3}[0-9]{4}$");

        //Regex.IsMatch(placa):
        //Verifica se a placa corresponde ao padrão especificado na expressão regular(("^[a-zA-Z]{3}[0-9]{4}$"))
        // 3 letras e 4 numeros
        return Regex.IsMatch(placa);

    }
}
/*
 Curiosidade: Oque é Regex?
 Regex é uma ferramenta que permite especificar um padrão de texto, buscando, validando
 e alterando padrões de caracteres.
 que nem no exemplo que fiz acima
var Regex = new Regex("^[a-zA-Z]{3}[0-9]{4}$");

1. O ^ marca o inicio da string.
2. [a-zA-Z]{3}, exige que 3 caracteres(Maiusculas ou minusculas) sejam inseridas
3. [0-9]{4}, exige que tenha 4 numeros de 0 a 9.
4. $, marca o fim da string.
 */