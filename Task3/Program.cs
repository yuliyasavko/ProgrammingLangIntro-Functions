int n = 9;
int[] arr = new int[n];
Random random  = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(100, 1000);
}  
for (int j = 0; j < arr.Length; j++)
{
    Console.Write($"{arr[j]} ");
}
Console.WriteLine();

for (int k = 0; k < arr.Length / 2; k++)
{
    int temp = arr[k];
    int m = arr.Length - k - 1;
    arr[k] = arr[m];
    arr[m] = temp;
}
for (int l = 0; l < arr.Length; l++)
{
    Console.Write($"{arr[l]} ");
}
Console.WriteLine();