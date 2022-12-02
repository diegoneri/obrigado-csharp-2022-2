int numero = 0;
bool ehPar = false;

Console.WriteLine("=============================");
Console.WriteLine("========Par ou ímpar=========");
Console.WriteLine("=============================");

Console.Write("Informe um número:\t");

numero = Convert.ToInt32(Console.ReadLine()!);
ehPar = (numero % 2 == 0);

if (ehPar)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}