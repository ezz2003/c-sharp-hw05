// 37. найдите произведение пар чисел в одномерном массиве. Парой считаем первый и послединий элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. 


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
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]} ";
  strPrn += arr.Last();
  return strPrn;
}

int[] StrangeNewArr(int[] ar)
{
  int len = ar.Length;
  int[] stNArray = new int[(len + 1) / 2];
  if (len % 2 != 0) stNArray[stNArray.Length - 1] = ar[len / 2];
  int cou = 0;
  while (len - cou >= 2)
  {
    stNArray[cou] = ar[cou] * ar[len - 1];
    cou++;
    len--;
    // if (cou == len - 1)
    // {
    // stNArray[cou] = ar[cou];
    // return stNArray;
    // }
  }
  return stNArray;
}

int[] readyArr = MakeArrRnd(11, 1, 10);
Console.WriteLine($"[{MakeStrPrintArr(readyArr)}] -> {MakeStrPrintArr(StrangeNewArr(readyArr))}");
