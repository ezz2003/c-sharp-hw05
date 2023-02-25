// 35. задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

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

int CountNumbers(int[] ar)
{
  int count = 0;
  for (int i = 0; i < ar.Length; i++)
  {
    if (ar[i] >= 10 & ar[i] < 100) count++;
  }
  return count;
}

int[] readyArr = MakeArrRnd(123, 1, 999);
Console.WriteLine($"{MakeStrPrintArr(readyArr)} -> {CountNumbers(readyArr)}");