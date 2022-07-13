double[] arr = new double[] {3, 56, 43, 70, 9, 15};
double diff = 0;
double max = arr[0], min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    max = arr[i];
    if (arr[i] < min)
    min = arr[i];
}

diff = max - min;
Console.WriteLine("difference between min and max " + diff);
