int ChangeElements(int[] array) // Замена положительных элементов массива на отрицательные и наоборот
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

