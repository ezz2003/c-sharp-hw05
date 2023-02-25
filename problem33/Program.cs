// 33. Задайте массив. Напишите программу, которая определяет, присутствует ли данное число в массиве или нет.

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

string FindElementInArr(int el, int[] ar)
{
  for (int i = 0; i < ar.Length; i++) if (ar[i] == el) return "ДА";
  return "НЕТ";
}

int[] readyArr = MakeArrRnd(7, 1, 9);
int number = new Random().Next(1, 10);
// Console.Clear();
Console.WriteLine($"{number}; массив {MakeStrPrintArr(readyArr)} -> {FindElementInArr(number, readyArr)}");
