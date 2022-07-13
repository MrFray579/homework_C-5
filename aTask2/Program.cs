//Console.WriteLine("Введите длинну массива:");
//int a = Convert.ToInt32(Console.ReadLine());
int a = 10;
int[] arr = new int[a];
Random rnd = new Random();
int odd = 0;

for (int i = 0; i < a; i++)
{
    arr[i] = rnd.Next(1, 10);
    Console.Write(arr[i] + " ");
   
    if (i % 2 != 0)
    {
    odd += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine("sum of odd numbers {0} ", odd);

