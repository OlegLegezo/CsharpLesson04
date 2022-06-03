// числа Фибоначчи
//f(n)=f(n-1)+f(n-2)

int Fibonacci (int n)
{
    if(n==1||n==2)// "||" - знак или
    return 1;
    else 
    return Fibonacci(n-1)+Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i})={Fibonacci(i)}");
}