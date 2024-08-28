// Random ile rastgele 10 adet sayıdan oluşan bir liste oluşturuyorum.
// Var sayilar: -40 ile 40 arasından oluşan rastgele sayılardır. 
Random rnd = new Random(); 
var sayilar = Enumerable.Range(0, 10)
                        .Select(sayilar => rnd.Next(-40, 40))
                        .ToList();

Console.WriteLine("Tüm sayılar:"); //Tüm sayıları foreach ile yazdırıyorum.
foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------");

var ciftsayi = sayilar.Where(x => x % 2 == 0).ToList(); // Sayılar dizisinden seçilen rastgele sayılar içinden çift sayıları bulur.

Console.WriteLine("Çift sayılar:");
foreach (var sayi in ciftsayi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------");

var teksayi = sayilar.Where(x => x % 2 != 0).ToList(); // Sayılar dizisinden seçilen rastgele sayılar içinden tek sayıları bulur.

Console.WriteLine("Tek sayılar:");
foreach (var sayi in teksayi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------");

var negatif = sayilar.Where(x => x <= 0).ToList(); // Sayılar dizisinden seçilen rastgele sayılar içinden negatif sayıları bulur.

Console.WriteLine("Negatif sayılar:");
foreach (var sayi in negatif)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------");

var pozitif = sayilar.Where(x => x >= 0).ToList(); // Sayılar dizisinden seçilen rastgele sayılar içinden pozitif sayıları bulur.

Console.WriteLine("Pozitif sayılar:");
foreach (var sayi in pozitif)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------"); // Sayılar dizisinden seçilen rastgele sayılar içinden 15 ile 22 arasındaki sayıları bulur.

var range = sayilar.Where(x => x > 15 && x < 22).ToList();

Console.WriteLine("15 ile 22 arasındaki sayılar:");
foreach (var sayi in range)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------");

var kare = sayilar.Select(x => x * x).ToList(); // Sayılar dizisinden seçilen rastgele sayıların karesini alır.

Console.WriteLine("Listedeki sayıların karesi:");
foreach (var sayi in kare)
{
    Console.WriteLine(sayi);
}