using System;

Converter<string, int> c1 = new((s) => s.Length);
string[] arr1 = { "Hello", "World", "C#" };
Console.WriteLine(@$"

=== 문자열 -> 길이 변환 ===
Hello -> {c1.Convert(arr1[0])}
전체 변환: ");
foreach (var n in c1.ConvertAll(arr1))
{
    Console.Write($"{n} ");
}

Converter<int, string> c2 = new((n) => $"{n}번");
int[] arr2 = { 1, 2, 3 };
Console.WriteLine(@$"

=== 정수 -> 문자열 변환 ===
1 -> {c2.Convert(arr2[0])}
전체 변환: ");
foreach (var s in c2.ConvertAll(arr2))
{
    Console.Write($"{s} ");
}

Converter<double, int> c3 = new((d) => (int)d);
double[] arr3 = { 3.7, 1.2, 9.7 };
Console.WriteLine(@$"

=== 정수 -> 문자열 변환 ===
1 -> {c3.Convert(arr3[0])}
전체 변환: ");
foreach (var n in c3.ConvertAll(arr3))
{
    Console.Write($"{n} ");
}