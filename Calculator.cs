



Console.Write("num1:");
double num1 = double.Parse(Console.ReadLine());

Console.Write("op:");
string op = Console.ReadLine();

Console.Write("num2:");
double num2 = double.Parse(Console.ReadLine());

double res = 0;

if (op == "+")
{
    res = num1 + num2;
}
else if (op == "-")
{
    res = num1-num2;

}
else if (op == "*")
{
    res = num1*num2;

}else if (op == "/")
{
    res = num1/num2;

}

Console.Write("Result:" + res);


