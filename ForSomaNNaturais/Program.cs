Console.WriteLine("Digite um número: ");

try
{
    int valorusuario = int.Parse(Console.ReadLine());
    int total = 0;

    for (int x = 1; x <= valorusuario; x++)
    {
        total += x;
    }
    Console.WriteLine("Totalizado :" +  total);
}

catch
{
    Console.WriteLine("Valor invalido");
}

