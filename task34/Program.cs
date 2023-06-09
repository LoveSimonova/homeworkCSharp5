// See https://aka.ms/new-console-template for more information
int[] GetMass(int length)
{
    Random rnd = new Random();
    int[] massive = new int[length];
    Console.Write("Полученный массив: ");
    for(int i=0;i<length;i++)
    {
        massive[i]=rnd.Next(100,999);
        Console.Write(""+massive[i]+" ");
        if(i==(length-1))
            Console.Write("\r\n");
    }
    return massive;
}

void CountChet(int[] massive)
{
    int count=0;
    for(int i=0;i<massive.Length;i++)
        if((massive[i]%2)==0)
            count++;
    Console.WriteLine("Количество четных чисел: "+count);
}

Console.WriteLine("Введите количество элементов массива: ");
CountChet(GetMass(Convert.ToInt32(Console.ReadLine())));
