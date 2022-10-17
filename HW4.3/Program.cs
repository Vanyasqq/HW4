int[] RandomArray(int Len, int min, int max)
{
    int[] array = new int[Len];
    for(int i =0; i<Len; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

string PrintArray(int[] array, int N)
{
    string msg = "[";
    for (int i=0; i <N-1; i++)
    {
        msg += array[i] + ", ";
    }
        msg += array[N-1] + "]";
        
    return msg;
}

Console.WriteLine("Введите длину массива");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение числа в массиве");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значиение числа в массиве");
int max = int.Parse(Console.ReadLine());


Console.WriteLine(PrintArray(RandomArray(N, min, max), N));