
static int sum(int Value)
{ 
    int result = 0;
    while(Value > 0)
    {
        result += Value % 10;
        Value= Value / 10;
    }
    return result;
}    

Console.WriteLine("введите число!");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(sum(a));
