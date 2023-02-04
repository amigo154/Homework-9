// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ack(m, n);

System.Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
