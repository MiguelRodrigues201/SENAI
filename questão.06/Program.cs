using System;

Console.WriteLine("Digite o primeiro valor por favor");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor por favor");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor por favor");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro peso por favor");
int peso1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo peso por favor");
int peso2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro peso por favor");
int peso3 = int.Parse(Console.ReadLine());

int mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

Console.WriteLine("A media ponderada é " + mediaPonderada);

if (mediaPonderada >= 7)
{
    Console.WriteLine("voce esta aprovado!");
}
else if (mediaPonderada >=5 )
{
    Console.WriteLine("Voce esta de recuperação");
}
else
{
    Console.WriteLine("Voce esta reprovado");
}
