// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// 
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// 

double[] MakeArrRnd(int size, int min, int max)
{
  double[] array = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < size; i++) array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
  return array;
}

string MakeStrPrintArr(double[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]} ";
  strPrn += arr.Last();
  return strPrn;
}

double DifMinMaxArr(double[] ar)
{
  double min = ar[0];
  double max = ar[0];
  for (int i = 1; i < ar.Length - 1; i++)
  {
    if (min > ar[i]) min = ar[i];
    if (max < ar[i]) max = ar[i];
  }
  return max - min;
}

double[] readyArr = MakeArrRnd(33, 1, 100);
Console.WriteLine($"[{MakeStrPrintArr(readyArr)}] -> {DifMinMaxArr(readyArr)}");