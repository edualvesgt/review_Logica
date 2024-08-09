int[] nums = new int[10];
int numPar = 0;

Console.WriteLine("Vamos fazer a soma dos numeros pares ");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º Numero:");
    nums[i] = int.Parse(Console.ReadLine()!);
}

foreach (int i in nums)
{
    if (i % 2 == 0)
    {
        numPar += i;
    }
}

Console.WriteLine($"A Soma dos Numeros pares e de {numPar}");