


void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(0,10);
}

string ReleaseArray(int[]array,int k)
{
   
    for (int i = 0; i < array.Length; i++)
       if (array[i]== k)
            return "yas";
    return "no";
           
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}


Console.Clear();
 Console.Write($"n = ");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.Write($"k = ");
 int k = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[n];
 InputArray(array);
 PrintArray(array);
 Console.WriteLine(ReleaseArray(array, k));
  