// See https://aka.ms/new-console-template for more information
int[] GetMass(int length)
{
    Random rnd = new Random();
    int[] massive = new int[length];
    Console.Write("Массив: ");
    for(int i=0;i<length;i++)
    {
        massive[i]=rnd.Next(0,999);
        Console.Write(""+massive[i]+" ");
        if(i==(length-1))
            Console.Write("\r\n");
    }
    return massive;
}

void Sum(int[] massive)
{
    int sum=0;
    for(int i=0;i<massive.Length;i++)
        if((i%2)!=0)
            sum+=massive[i];
    Console.WriteLine("Сумма: "+sum);
}

Console.WriteLine("Введите количество элементов массива: ");
Sum(GetMass(Convert.ToInt32(Console.ReadLine())));
