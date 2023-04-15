double nota1, nota2, nota3, nota4, media;
string resultado;
Console.WriteLine("== Média de notas ==");

Console.Write("Digite a nota 1:");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 2:");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 3:");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 4:");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

bool notasvalidas =    nota1>= 0 && nota1<= 10 
                    && nota2>= 0 && nota2<= 10
                    && nota3>= 0 && nota3<= 10 
                    && nota4>= 0 && nota4<= 10;
                    
if (notasvalidas)
{
    media = (nota1 + nota2 + nota3 + nota4) / 4;

if (media < 5)
{
        Console.ForegroundColor = ConsoleColor.Red;
    resultado = "Reprovado";
        Console.ResetColor();
}
else
{
    if (media > 6 )
    {
        Console.ForegroundColor = ConsoleColor.Green;
        resultado = "Aprovado !";
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        resultado = "Recuperação";
        Console.ResetColor();
    }
    
}
    Console.WriteLine($"1° nota {nota1:N1}"); Console.WriteLine($"2° nota {nota2:N1}");
    Console.WriteLine($"3° nota {nota3:N1}"); Console.WriteLine($"4° nota {nota4:N1}");
    Console.WriteLine($"Média de notas: {media:N1}.");
    Console.WriteLine($"Resultado: {resultado}");
}
else
Console.WriteLine("Digite somente notas de 0 a 10.");
