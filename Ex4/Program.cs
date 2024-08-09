Console.WriteLine("Digite o Numero para saber a tabuada");
int num = int.Parse(Console.ReadLine()!);

Tabuada(num);

static void Tabuada(int numero)
{
    Console.WriteLine($"Tabuada do Numero {numero}");

	for (int i = 0; i < 11; i++)
	{
		int result = numero * i;
        Console.WriteLine($"{numero} X {i} = {result}" );

    }


	


}