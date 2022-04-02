Console.Clear();

int numero;

Console.Write("Escreva um número qualquer: ");
numero = Convert.ToInt32(Console.ReadLine());

bool numeroNegativo = numero < 0, numeroPositivo = numero > 0, Zero = numero == 0;

if (numeroNegativo)
{
    Console.WriteLine("Negativo!");
}
if (numeroPositivo)
{
    Console.WriteLine("Positivo!");
}
if (Zero)
{
    Console.WriteLine("Zero!");
}