int [] RandomArray(int Length)
{
    int [] arr = new int [Length];
    for (int i = 0; i<Length; i++)
    {
        arr[i] = new Random().Next (-100, 100);
    }
    return arr;
}