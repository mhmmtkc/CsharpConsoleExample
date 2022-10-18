//Atama ve işlemli atama
int x = 3;
int y = 5;
Console.WriteLine(y);
y += 6;
Console.WriteLine(y + Environment.NewLine + x);
x *= 10;
Console.WriteLine(x);

//Logical operators
// ||,&&,!

bool isSuccess = true;
bool isCompleted = false;
if (isCompleted && isCompleted)
    Console.WriteLine("great");
if (isCompleted || isSuccess)
    Console.WriteLine("nice");
if (isSuccess && !isCompleted)
    Console.WriteLine("excellent");

//Relational operators
int a = 3;
int b = 4;
int c = 10;
bool result = a > b;
Console.WriteLine(result);
if (c > b && b > a)
    Console.WriteLine("you are learning");

//Arithmetic operators
// +,-,*,/,%

int result2 = (((c + b * 2) / a) * b) / 24;
if (1 == result2)
    Console.WriteLine("solved the problem");
