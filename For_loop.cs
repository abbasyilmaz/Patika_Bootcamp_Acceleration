int[] dizi = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write((i + 1) + ".sayı giriniz:");
    dizi[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(dizi);
Console.WriteLine("-------------");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(dizi[i]);
}
Console.ReadKey();