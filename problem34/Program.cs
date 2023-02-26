// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// 
// [345, 897, 568, 234] -> 2
// 

int[] MakeArrRnd(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < size; i++) array[i] = rnd.Next(min, max + 1);
  return array;
}

string MakeStrPrintArr(int[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]}, ";
  strPrn += arr.Last();
  return $"[ {strPrn} ]";
}

int CountEvenNumbers(int[] ar)
{
  int count = 0;
  for (int i = 0; i < ar.Length; i++)
  {
    if (ar[i] % 2 == 0) count++;
  }
  return count;
}

int[] readyArr = MakeArrRnd(12, 100, 1000);
Console.WriteLine($"{MakeStrPrintArr(readyArr)} -> {CountEvenNumbers(readyArr)}");