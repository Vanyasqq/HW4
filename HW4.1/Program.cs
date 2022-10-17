    
static int NumberDegree(int number, int degree)
{
    int result = number;
    if (degree == 0)
    {
         result = 1;
    }
    else
    {
        for(int i=1; i < degree; i++)
        {
            result = result * number;
        }
    }
    return result;
} 

    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите степень числа");
    int b = int.Parse(Console.ReadLine());
    

Console.WriteLine(NumberDegree(a,b));