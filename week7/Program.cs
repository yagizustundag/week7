int a = 5;
int b = 6;

Add(a, b);
Add(10, 100);
Add(12312, 44324);

static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}


Multiply(a, b);
Multiply(10, 100);
Multiply(12312, 44324);

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

Substract(a, b);
Substract(10, 100);

static void Substract(int x, int y)
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}

Divide(a, b);
Divide(10, 100);

static void Divide(double x, double y)
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}

