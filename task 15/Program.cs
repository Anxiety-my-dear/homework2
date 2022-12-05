Console.WriteLine("Введите день недели");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 7) Console.WriteLine("Всего 7-мь дней недели а не" + x);
if ((x == 6) && (x == 7)) Console.Write($"{x}-Да");
else Console.Write($"{x}-нет");
