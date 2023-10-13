Console.WriteLine("Digite um valor: ");


int valorusuario = int.Parse(Console.ReadLine());
int x = 1;
int total = 0;



do
{
    total += x;
    x++;


}while (x <= valorusuario);

Console.WriteLine("Total : " + total);
