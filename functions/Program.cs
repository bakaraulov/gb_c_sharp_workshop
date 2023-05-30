// int[] array = {1,8,3,2,6};
// int size = array.Length;
// int current_index = 0;
// int fstMax = array[current_index];
// int scdMax = 0;
// int fstMaxIndex = 0;
// int scdMaxIndex = 0;
// while (current_index < size)
// {
//     if (array[current_index]>fstMax)
//     {
//         fstMax = array[current_index];
//         fstMaxIndex = current_index;
//     }
//     current_index ++;
// }
// current_index = 0;
// if (fstMaxIndex == 0)
// {
//     scdMaxIndex = array[1];
// }
// while (current_index < size)
// {
//     if (array[current_index] > scdMaxIndex)
//     {
//         if (current_index != fstMaxIndex)
//         {
//         scdMax = array[current_index];
//         scdMaxIndex = current_index;
//         }
//     }
//     current_index ++;
// }
// Console.Clear ();
int[] MaxArray(int[] array)
{
    int size = array.Length;
    int current_index = 0;
    int fstMax = array[current_index];
    int scdMax = 0;
    int fstMaxIndex = 0;
    int scdMaxIndex = 0;
    int[] rezult = {fstMax , fstMaxIndex , scdMax , scdMaxIndex};
    while (current_index < size)
    {
        if (array[current_index]>fstMax)
        {
            fstMax = array[current_index];
            fstMaxIndex = current_index;
        }
        current_index ++;
    }
    current_index = 0;
    if (fstMaxIndex == 0)
    {
        scdMaxIndex = array[1];
    }
    while (current_index < size)
    {
        if (array[current_index] > scdMaxIndex)
        {
            if (current_index != fstMaxIndex)
            {
            scdMax = array[current_index];
            scdMaxIndex = current_index;
            }
        }
        current_index ++;
    }
    return rezult;
}

int[] array = {4,5,6,7,1,8,3,9};
MaxArray(array);
Console.WriteLine(MaxArray);

