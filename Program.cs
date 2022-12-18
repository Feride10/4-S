// 29
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100); 

Console.WriteLine($"[{string.Join(", ", array)}]");




// 27 задача
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int k)
{
 int index = 0;
 while (k > 0)
    {
 k /= 10;
 index++;
    }
 return index;
}

void SumNumbers(int n, int len)
{
 int sum = 0;
 for (int i = 1; i <= len; i++)
    {
 sum += n % 10;
 n /= 10;
    }
 Console.WriteLine(sum);
}
