int[] array = { 15, 224, 375, 432, 597, 688, 743, 82, 96 };

int num = array.Length;
int find = 6;

int index = 0;
while (index < num)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1;
}