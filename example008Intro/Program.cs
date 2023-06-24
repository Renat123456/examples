int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2) result = arg2;
    if (result < arg3) result = arg3;
    return result;
}

int a = 11;
int a2 = 13;
int a3 = 11;
int a4 = 141;
int a5 = 21;
int a6 = 171;
int a7 = 41;
int a8 = 37;
int a9 = 11;

int max1 = Max(a, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);

Console.WriteLine("максимум: " + max);