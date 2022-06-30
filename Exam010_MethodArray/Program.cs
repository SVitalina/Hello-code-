int[] array = { 16, 27, 73, 4, 75, 6, 37, 80 };

int n = array.Length;
int find = 37;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
