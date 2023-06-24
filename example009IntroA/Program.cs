int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int [] array1 = {1, 92, 3, 14, 5, 76, 7, 8, 9}; 

int max = Max(Max(array1[0], array1[1], array1[2]), Max(array1[3], array1[4], array1[5]), Max(array1[6], array1[7], array1[8]));

Console.WriteLine("максимум: " + max);
