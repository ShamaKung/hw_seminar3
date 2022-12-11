Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B (яв-ся степенью для числа А)");
int lengthB = Convert.ToInt32(Console.ReadLine());

int res = 1;

int [] n = new int [lengthB];

for (int i = 0; i < lengthB; i++)
{
    n[i] = A;
}

for (int i = 0; i < lengthB; i++)
{
    res = res * n[i];
}

Console.WriteLine(res);