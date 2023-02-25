// 32. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.

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

int[] ReplacementElementsNegToPos(int[] ar)
{
  for (int i = 0; i < ar.Length; i++) ar[i] *= -1;
  return ar;
}

int[] readyArr = MakeArrRnd(12, -9, 9);
Console.WriteLine($"{MakeStrPrintArr(readyArr)} -> {MakeStrPrintArr(ReplacementElementsNegToPos(readyArr))}");