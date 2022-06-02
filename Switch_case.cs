Console.WriteLine("Hello Babyyy , Could u give a number ?");
int degisken = Convert.ToInt32(Console.ReadLine());
switch (degisken)
{
    case 1:
        Console.WriteLine("Sayınız bir değeridir...");
        break;
    case 2:
        Console.WriteLine("Sayınız iki değeridir...");
        break;
    case 3:
        Console.WriteLine("Sayınız üç değeridir...");
        break;
    default:
        Console.WriteLine("Sayınız bir, iki ve üç değerinden farklıdır...");
        break;
}