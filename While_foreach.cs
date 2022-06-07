int i = 1;
Random rdn = new Random();
int rastgele = rdn.Next(0, 10);
while (true)
{
    Console.Write("Sayı Giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == rastgele)
    {
        break;
    }
    i++;
}
Console.WriteLine(i + ". tahmininizde sayıyı buldunuz.");




string[] isimler = {"Ahmet CANSEVER","Emirhan SOYLU","Elif SÜTÇÜ",
                                "Hakan ALTIN","Sema ÇALIŞKAN"};
foreach (string eleman in isimler)
{
    Console.WriteLine(eleman);
}
Console.ReadKey();