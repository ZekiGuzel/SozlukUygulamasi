Dictionary<string, string> sozluk = new Dictionary<string, string>();

// Temel kelimeler
sozluk.Add("hello", "merhaba");
sozluk.Add("goodbye", "güle güle");
sozluk.Add("thank you", "teşekkür ederim");
sozluk.Add("please", "lütfen");
sozluk.Add("yes", "evet");
sozluk.Add("no", "hayır");
sozluk.Add("sorry", "özür dilerim");

// Yiyecek & İçecek
sozluk.Add("water", "su");
sozluk.Add("food", "yemek");
sozluk.Add("bread", "ekmek");
sozluk.Add("coffee", "kahve");
sozluk.Add("tea", "çay");
sozluk.Add("milk", "süt");
sozluk.Add("fruit", "meyve");
sozluk.Add("meat", "et");
sozluk.Add("fish", "balık");

// Renkler
sozluk.Add("red", "kırmızı");
sozluk.Add("blue", "mavi");
sozluk.Add("green", "yeşil");
sozluk.Add("yellow", "sarı");
sozluk.Add("black", "siyah");
sozluk.Add("white", "beyaz");

// Günler
sozluk.Add("monday", "pazartesi");
sozluk.Add("tuesday", "salı");
sozluk.Add("wednesday", "çarşamba");
sozluk.Add("thursday", "perşembe");
sozluk.Add("friday", "cuma");
sozluk.Add("saturday", "cumartesi");
sozluk.Add("sunday", "pazar");

// Sayılar
sozluk.Add("one", "bir");
sozluk.Add("two", "iki");
sozluk.Add("three", "üç");
sozluk.Add("four", "dört");
sozluk.Add("five", "beş");
sozluk.Add("ten", "on");
sozluk.Add("hundred", "yüz");

// Teknoloji
sozluk.Add("computer", "bilgisayar");
sozluk.Add("phone", "telefon");
sozluk.Add("software", "yazılım");
sozluk.Add("keyboard", "klavye");
sozluk.Add("screen", "ekran");

// Doğa
sozluk.Add("sea", "deniz");
sozluk.Add("mountain", "dağ");
sozluk.Add("sun", "güneş");
sozluk.Add("moon", "ay");
sozluk.Add("star", "yıldız");
sozluk.Add("rain", "yağmur");
sozluk.Add("wind", "rüzgar");

Console.WriteLine("=== İngilizce - Türkçe Sözlük ===");
Console.WriteLine("Toplam kelime sayısı: " + sozluk.Count);
Console.WriteLine("----------------------------------");
Console.Write("Aramak istediğiniz kelimeyi girin: ");
string kelime = Console.ReadLine().ToLower();

if (sozluk.ContainsKey(kelime))
{
    Console.WriteLine("✓ Türkçesi: " + sozluk[kelime]);
}
else
{
    Console.WriteLine("✗ Kelime bulunamadı!");
}
