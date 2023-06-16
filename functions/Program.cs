Console.Clear();

double[] FindMiMaArray(double[] array)
{
    int size = array.Length;
    int current_index = 0;
    double fstMax = array[current_index];
    double scdMax = array[current_index];
    int fstMaxIndex = 0;
    int scdMaxIndex = 0;
    double fstMin = array[current_index];
    double scdMin = array[current_index];
    int fstMinIndex = 0;    
    int scdMinIndex = 0;
    double[] rezult = new double[8];
    while (current_index < size)
    {
        if (array[current_index]>fstMax)
        {
            fstMax = array[current_index];
            fstMaxIndex = current_index;
        }
        if (array[current_index]<fstMin)
        {
            fstMin = array[current_index];
            fstMinIndex = current_index;
        }
        current_index ++;
    }
    // Console.WriteLine($"fmsx {fstMax} {fstMaxIndex} fmin {fstMin} {fstMinIndex}"); debug output
    current_index = 0;
    if (fstMaxIndex == 0)
    {
        scdMax = array[1];
    }
    if (fstMinIndex == 0)
    {
        scdMin = array[1];
    }
    while (current_index < size)
    {
        if (current_index != fstMaxIndex)
        {
            if (array[current_index] > scdMax)
            {
                scdMax = array[current_index];
                scdMaxIndex = current_index;
            }
        }
        if (current_index != fstMinIndex)
        {
            if (array[current_index] < scdMin)
            {
                scdMin = array[current_index];
                scdMinIndex = current_index;
            }
        }
        current_index ++;
    }
    // Console.WriteLine($"smax {scdMax} {scdMaxIndex} smin {scdMin} {scdMinIndex}"); debug output

    rezult[0]=fstMax;
    rezult[1]=fstMin;
    rezult[2]=scdMax;
    rezult[3]=scdMin;
    rezult[4]=fstMaxIndex;
    rezult[5]=fstMinIndex;
    rezult[6]=scdMaxIndex;
    rezult[7]=scdMinIndex;
    return rezult;
}

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}

int[] CreateRandomMassive(int val)
{
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);  // генератор [a,b)
    }
    return array;
}

void PrintMassive(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
}