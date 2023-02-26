public class Shares
{
    public static int[] CreateArray(int size) //Создание массива - Антон
    {
        return new int[size];
    }


    int[] RandomArray(int Length) //Заполнение массива случайными числами - Семён
    {
        int[] arr = new int[Length];
        for (int i = 0; i < Length; i++)
        {
            arr[i] = new Random().Next(-100, 100);
        }
        return arr;
    }

    public static void Print1(int[] array) //Вывод массива - Альбина
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

    public static int[] ChangeElements(int[] array) // Замена положительных элементов массива на отрицательные и наоборот - Ольга
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = -array[i];
        }
        return array;
    }



    // public static void FillArray(int[] array)
    // {
    //     int[] randomArray = new int[i];
    //     for (int i = 0; i < randomArray.Length; i++)
    //     {
    //         randomArray[i] = new Random().Next(-20, 20);
    //         Console.Write(randomArray[i] + " ");
    //     }
    // }
}