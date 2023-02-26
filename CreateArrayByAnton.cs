int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[]array)
{
    int[] randomArray = new int[i];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = new Random().Next(-20,20);
                Console.Write(randomArray[i] + " ");
    }
}