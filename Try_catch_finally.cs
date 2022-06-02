try
{
    Console.WriteLine("Bir Sayı Giriniz : ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş oldugunuz sayi : " + sayi);
}
catch (Exception ex)
{
    Console.WriteLine("Hata : " + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İşlem tamamlandı");
}


try
{
    int a = int.Parse(null);
    int b = int.Parse("Hello :) ");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz ! ");
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Format Hatası");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("İslem basarıyla tamamlandı .")
}