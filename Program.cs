Console.Clear();

int A, B, R;

Console.WriteLine("Algoritmo de Euclides: Método Iterativo MDC\n");

Console.Write("Escreva o dividendo: ");
A = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Escreva o divisor: ");
B = Convert.ToInt32(Console.ReadLine()!);

R = A % B;
Console.Write($"Resto = {R}");

while (B != 0)

{
A = B;
B = R;
}
return A;


Console.WriteLine($"MDC(A,B)= {A}");