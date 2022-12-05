Console.WriteLine("Введите трёхзначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int c = ((x - (x % 10)) % 100) / 10;
Console.WriteLine(c);