Console.WriteLine("Cadastre 5 Nomes que iremos retornar em ordem alfabética");

// Array para armazenar os nomes
string[] nomes = new string[5];

// Coletando os nomes
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º Nome:");
    nomes[i] = Console.ReadLine()!;
}

// Ordenando o array em ordem alfabética
Array.Sort(nomes);

// Exibindo os nomes ordenados
Console.WriteLine("Nomes em ordem alfabética:");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}
   
