Console.Write("Digite o tamanho da matriz:");

int tamanho = int.Parse(Console.ReadLine());


for(int x = 0; x <= tamanho; x++)
{
    for(int y = 0; y <= tamanho; y++)
    {
        Console.Write("(" +x+ ","+y+")");
    }
    Console.WriteLine();
}