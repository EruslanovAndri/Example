// Факториал. = это произведение от 1 до заданного числа
// 5! = 5*4*3*2*1
// 5*4!
//4*3!
//3*2!


double Factorial(int n)
{   // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}? = {Factorial(i)}");
}

//Console.WriteLine(Factorial(5)); // 1*2*3 = 6

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n -2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}

