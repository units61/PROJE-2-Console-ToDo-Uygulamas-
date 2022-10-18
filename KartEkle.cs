namespace TODO;
internal class KartEkle : IOperation
{
    public void Add()
    {
        Kart newCard = new Kart();

        Console.WriteLine("Kart Ekleme Bölümü");
        Console.WriteLine("*******************************************");
        Console.Write(" Başlık Giriniz                                  : ");
        newCard.baslik = Console.ReadLine();
        Console.Write(" İçerik Giriniz                                  : ");
        newCard.icerik = Console.ReadLine();
        Console.Write(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
        int size = int.Parse(Console.ReadLine());

        if (size != null)
        {

            string sizeValue = Enum.GetName(typeof(Sizes), size);
            newCard.buyukluk = sizeValue;
        }
        else
        {
            Console.WriteLine("Gecersiz bir karakter girdiniz. Tekrar deneyiniz ");
        }
        Console.Write(" Kişi Seçiniz                                    : ");
        newCard.atanakisi = Console.ReadLine();
        CheckPersonId(newCard);
    }
    public void CheckPersonId(Kart newCard)
    {
    againId:
        Console.WriteLine("İşleme devam edebilmek için ID nizi giriniz ");
        int id = int.Parse(Console.ReadLine());
        var person = Database.PersonList.FirstOrDefault(x => x.Id == id);
        if (person != null)
        {
            Database.Cards.Add(newCard);
            Console.WriteLine("Bu kart {0} tarafından oluşturulmuştur.", person.Name);
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız!");
        againTry:
            Console.WriteLine("Tekrar denemek için 1'e iptal etmek için 2'e basınız ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                goto againId;
            }
            else if (choice == 2)
            {
                Console.WriteLine("İşlemi iptal ettiniz.");
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                goto againTry;
            }
        }

    }
    enum Sizes
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}