Console.Clear();

int A, B, R;

Console.WriteLine("Algoritmo de Euclides: Método Iterativo MDC\n");

Console.Write("Escreva o dividendo: ");
A = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Escreva o divisor: ");
B = Convert.ToInt32(Console.ReadLine()!);


while (B != 0)

{
R = A % B;
A = B;
B = R;
}



Console.WriteLine($"MDC(A,B)= {A}");