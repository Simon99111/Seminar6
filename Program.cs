using static Shares;

Console.Write("Введите количество элементов массива ");
int msg = Convert.ToInt32(Console.ReadLine());
int [] ar = CreateArray(msg);
ar = RandomArray(msg);
Print1(ar);
ChangeElements(ar);
Print1(ar);