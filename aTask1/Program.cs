int len = 10;
int [] arr = new int[len];
Random rnd = new Random();
int even = 0;

for (int i = 0; i < len; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.WriteLine(arr[i] + " ");
    if (arr[i] % 2 == 0)
    even++;
}

Console.WriteLine();
Console.WriteLine("Even numbers {0}:", even);