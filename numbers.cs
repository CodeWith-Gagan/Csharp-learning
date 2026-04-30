 WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}"); //The range of integers is -2147483648 to 2147483647
int what = max + 3;
Console.WriteLine(what);    // overflow output -2147483646 It's the same as min + 2. 

// Double numeric type

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max1 = double.MaxValue;
double min1 = double.MinValue;
Console.WriteLine($"The range of double is {min1} to {max1}"); //The range of double is -1.7976931348623157E+308 to 1.7976931348623157E+308

double third = 1.0 / 3.0;
Console.WriteLine(third); //rounding error remains.

decimal min2 = decimal.MinValue;
decimal max2 = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min2} to {max2}"); //The range of the decimal type is -79228162514264337593543950335 to 79228162514264337593543950335

double e = 1.0;
double f = 3.0;
Console.WriteLine(e / f);

decimal g = 1.0M;
decimal h = 3.0M;  //The M suffix on the numbers indicates that a constant should use the decimal type. Otherwise, the compiler assumes the double type.
Console.WriteLine(g / h);