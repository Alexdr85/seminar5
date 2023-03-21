//Задайте массив из 12 элементов, заполненный случайными числами промежутка -9,9.
//Найдите сумму отрицательных и положительных элементов массива


void InputArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
     array[i] = new Random().Next(-9,10);
}

void ReleaseArray(int[]array)
{
    int sum_p = 0, sum_n = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]>0)
            sum_p+= array[i];
        else 
            sum_n += array[i];
            Console.WriteLine($"Сумма положительных элементов = {sum_p}");
            Console.WriteLine($"Сумма отрицательных элементов = {sum_n}");
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

