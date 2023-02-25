// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]. Найдите сумму отрицательных и положительных элементов массива.

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

int[] GetTwoSumms(int[] ar)
{
  int[] answer = new int[2];
  for (int i = 0; i < ar.Length; i++) if (ar[i] < 0) answer[0] += ar[i]; else answer[1] += ar[i];
  return answer;
}

int[] readyArray = MakeArrRnd(12, -9, 9);
int[] minMaxSum = GetTwoSumms(readyArray);
Console.Clear();
Console.WriteLine($"В массиве {MakeStrPrintArr(readyArray)} сумма положительных чисел равна {minMaxSum[1]}, а сумма отрицательных чисел равна {minMaxSum[0]}");