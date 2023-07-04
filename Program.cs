// See https://aka.ms/new-console-template for more information
//Programa da lista de LP, letra j e k
Console.WriteLine("Quantos lados tem o polígono?");
int.TryParse(Console.ReadLine(), out int lados);


switch(lados)
{
    case 3:
        Console.WriteLine("Triângulo");
        Console.WriteLine("Escreva a medida do lado 1 em cm:");
        double.TryParse(Console.ReadLine(), out double l1);
        Console.WriteLine("Escreva a medida do lado 2 em cm:");
        double.TryParse(Console.ReadLine(), out double l2);
        Console.WriteLine("Escreva a medida do lado 2 em cm:");
        double.TryParse(Console.ReadLine(), out double l3);

        var perimetro = l1 + l2 + l3;
        Console.WriteLine("Seu perímetro é:{0}", perimetro);
            break;
    case 4:
        Console.WriteLine("É um quadrado!");
        Console.WriteLine("Escreva o valor do lado em cm");
        double.TryParse(Console.ReadLine(), out double l4);
        var area = l4 * l4;
        Console.WriteLine("A área do quadrado é:{0}", area);
        break;
    case 5:
        Console.WriteLine("É um Pentágono!");
        break;
    case < 3:
        Console.WriteLine("Não é um polígono!");
        break;
    case > 5:
        Console.WriteLine("Polígono não identificado!");
        break;

};

