int[] array = {1, 2, 45, 23, 46, 343, 343, 2};

int n = array.Length;
int find = 23;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}