


void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(-9,10);
}

void ReleaseArray(int[]array)
{
   
    for (int i = 0; i < array.Length; i++)
       array[i] = -1* array[i];
           
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
  PrintArray(array);