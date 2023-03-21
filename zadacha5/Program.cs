




void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(1,10);
}

void ReleaseArray(int[]array)
{
   
    for (int i = 0; i < array.Length / 2 + array.Length % 2 ; i++)
       Console.Write($"{array[i]*array[array.Length - 1 - i]}");
    
           
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}


Console.Clear();
 Console.Write($"n = ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[n];
 InputArray(array);
 PrintArray(array);
 ReleaseArray(array);
 