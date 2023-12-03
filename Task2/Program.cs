int n = 10;
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

int count = 0;
for (int k = 0; k < arr.Length; k++)
{
    if (arr[k] % 2 == 0)
    {
        count++;
    }
    
}
Console.WriteLine(count);