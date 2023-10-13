Console.WriteLine("Digite um valor: ");
int valorusuario = int.Parse(Console.ReadLine());
int x = 1;
int total = 0;


while (x < valorusuario)
{
    total += x;
    x++;
    Console.WriteLine("Valor:" + total);
}