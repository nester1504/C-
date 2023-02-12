int[] array = { 11, 22, 333, 44, 19, 85, 446, 72, 887, 19 };

int n = array.Length;

int find = 19;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}