int aramaYap, veriTut;
int[] elemanlar = { 32, 52, 1, 3, 5, 87, 12, 35, 26, 46, 88, 15 };
Array.Sort(elemanlar);  // elemanları sıralayarak .search edebiliriz


Console.WriteLine("Arama Yapmak İstediğiniz Değeri Girin: ");
aramaYap = Convert.ToInt32(Console.ReadLine());

Console.Write("Dizi Elemanlarını Yazdıralım");
for (int i = 0; i < elemanlar.Length; i++)
    Console.Write("[{0}]", elemanlar[i]);

Console.WriteLine("\nVerinin kaçıncı sırada olduğunu bulalım");
veriTut = Array.BinarySearch(elemanlar, aramaYap);

Console.WriteLine($"Aradğınız '{aramaYap}' verisi dizinin '{veriTut}' indisinde bulunuyor...");