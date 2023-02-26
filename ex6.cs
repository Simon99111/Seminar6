// Печать
void Print1(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       Console.Write(array[index] + " ");
       index++;
    }
    System.Console.WriteLine();
}