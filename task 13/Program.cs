Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100) Console.WriteLine("Нет третьего числа.");
else
{
    int[] a = new int[1];
    int index = 0;
    while (x != 0)
    {
        int y = x % 10;
        Array.Resize(ref a, a.Length + 1);
        a[index] = y;
        x = (x - y) / 10;
        index++;
    }
    Console.WriteLine(a[a.Length - 4]);
}