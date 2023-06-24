int [] array = {1, 92, 3, 14, 5, 76, 7, 8, 7}; 
int n = array.Length;
int find = 7;
int index = 0;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
}
