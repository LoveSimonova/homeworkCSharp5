// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
double[] GetMass(int length)
{
    Random rnd = new Random();
    double[] massive = new double[length];
    Console.Write("Массив: ");
    for(int i=0;i<length;i++)
    {
        massive[i]=rnd.NextDouble();
        Console.Write(""+massive[i]+" ");
        if(i==(length-1))
            Console.Write("\r\n");
    }
    return massive;
}

void Delta(double[] massive)
{
    double delta=0;
    double min=massive[0];
    double max=massive[0];
    for(int i=1;i<massive.Length;i++)
    {
        if(min>massive[i])
            min=massive[i];
        if(max<massive[i])
            max=massive[i];
    }
    delta=max-min;
    Console.WriteLine("Разница: "+delta);
}

Console.WriteLine("Введите количество элементов массива: ");
Delta(GetMass(Convert.ToInt32(Console.ReadLine())));

