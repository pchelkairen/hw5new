// Функцию, которая вычисляет число a в степени n

int a = new Random().Next(1, 20);
int n = new Random().Next(1, 5);
int b = 1;
int c = 1;

for (int i = 1; i <= n; i++)
{
    b *= a;
}
Console.WriteLine($"число {a} в степени {n} = {b}");


// Функцию, которая вычисляет факториал числа n

int Factorial(int a)
{
    if (a == 1) return 1;
    return a * Factorial(a - 1);
}
c = Factorial(a);
Console.WriteLine($"Factorial {a} = {c}");

//Функцию, которая вычисляет сумму цифр произвольного целого числа n


int sum = 0;
for (int i = a; i > 0; i = i / 10)
{
    sum = sum + i % 10;
}
Console.WriteLine($"суммa цифр произвольного целого числа {a} = {sum}");


//  Функцию, которая проверяет является ли заданное число n полиндромом


n = a;
int rev = 0;
int dig = 0;

while (a > 0)
{
    dig = a % 10;
    rev = rev * 10 + dig;
    a = a / 10;
}
if (n == rev)
{
    Console.WriteLine($"является ли заданное число n полиндромом: yes");
}
else
{
    Console.WriteLine($"является ли заданное число n полиндромом: not");
}



// Функцию, складывающую два целых числа

int[] arr = new int[] { 12, 10 };
int sum3 = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum3 = sum3 + arr[i];
}
Console.WriteLine($"sum: {sum3}");

//Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false

bool isPrime(int n)
{
if (n < 2) return false;
for (int i = 2; i <= Math.Sqrt(n); i++)
{
if (n % i == 0) return false;
}
return true;
}

bool m = isPrime(n);
Console.WriteLine($"является ли число {n} простым {m}");



// Функцию, определяющую является ли число чётным, то есть возвращающую true, если число чётное, иначе - false

bool array(int n)
{
if (n % 2 != 0) return false;
else
{
    return true;
}
}

bool f = array(n);
Console.WriteLine($"является ли число {n} чётным {f}");