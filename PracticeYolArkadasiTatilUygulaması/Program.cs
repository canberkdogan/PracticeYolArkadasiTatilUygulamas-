bool devam = true;

while (devam)
{
    Console.WriteLine("Nereye Gitmek İstiyorsunuz?");

    string tercih = Console.ReadLine().ToLower();
    int fiyat = 0;
    switch (tercih)
    {
        case "1":
        case "bodrum":
            fiyat = 4000;
            break;
        case "2":
        case "marmaris":
            fiyat = 3000;
            break;
        case "3":
        case "cesme":
            fiyat = 5000;
            break;
        default:
            Console.WriteLine("Hatalı seçim yaptınız!");
            Console.WriteLine("Bodrum, Marmaris, Çeşme lokasyonlarını seçebilirsiniz.");

            break;

    }

    Console.WriteLine("Kaç kişi tatil yapacaksınız?");
    int kisiSayisi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(tercih + "lokasyonunu tercih ettiniz.");
    Console.WriteLine("Bu lokasyonda denize girebilir tatilin tadını çıkarabilirsiniz");

    Console.WriteLine("Tatilinize hangi ulaşım aracıyla gitmek istersiniz?");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

    int ulasim;
    int ulasimFiyat = 0;
    bool gecerliUlasimSecimi = false;

    while (!gecerliUlasimSecimi)
    {
        if (int.TryParse(Console.ReadLine(), out ulasim))
        {
            if (ulasim == 1)
            {
                Console.WriteLine("Kara yolunu seçtiniz.");
                ulasimFiyat = 1500;
                gecerliUlasimSecimi = true;

            }
            else if (ulasim == 2)
            {
                Console.WriteLine("Hava yolunu seçtiniz.");
                ulasimFiyat = 4000;
                gecerliUlasimSecimi = true;
            }
            else
            {
                Console.WriteLine("Hatalı Seçim Yaptınız. Lütfen 1 ya da 2 seçeneğini girin.");
            }
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 ya da 2 seçeneğini girin.");
        }
    }



    int totalFiyat = (fiyat * kisiSayisi) + ulasimFiyat;

    Console.WriteLine(tercih + "lokasyonunu tercih ettiniz");
    Console.WriteLine(kisiSayisi + "kişisiniz");
    Console.WriteLine(totalFiyat + "TL");

    Console.WriteLine("Başka bir tatil yapmak ister misiniz?");



    string devamSecimi = Console.ReadLine().ToLower(); // Büyük küçük harf duyarlılığı

    if (devamSecimi != "evet")
    {
        devam = false;
    }
}

Console.WriteLine(" İyi günler!");