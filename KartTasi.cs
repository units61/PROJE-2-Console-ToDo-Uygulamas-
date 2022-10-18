
namespace TODO;
internal class KartTasi : IOperation
{
    public void Move()
    {
    againDo:
        Console.WriteLine(" Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\r\n Lütfen kart başlığını yazınız:  ");
        string input = Console.ReadLine();
        Kart card = Database.Cards.FirstOrDefault(x => x.baslik == input);
        if (card != null)
        {
            Console.WriteLine("Bulunan kart bilgiler");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Başlık      :  {0}", card.baslik);
            Console.WriteLine("İçerik      :  {0}", card.icerik);
            Console.WriteLine("Atanan Kişi :  {0}", card.atanakisi);
            Console.WriteLine("Büyüklük    :  {0}", card.buyukluk);
            Console.WriteLine("Line        :  {0}\n", card.kolon);

            Console.WriteLine("Lütfen taşımak istediğiniz Durum'u seçiniz");
            Console.WriteLine("(0) TODO");
            Console.WriteLine("(1) IN PROGRESS");
            Console.WriteLine("(2) DONE");

            int line = int.Parse(Console.ReadLine());

            if (line == 0) { card.kolon = "TODO"; }
            else if (line == 1) { card.kolon = "IN PROGRESS"; }
            else if (line == 2) { card.kolon = "DONE"; }
            else { card.kolon = "Hatalı bir seçim yaptınız!"; }

        }
        else
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\r\n * İşlemi sonlandırmak için : (1)\r\n * Yeniden denemek için : (2)");
        againTry:
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Kart taşıma işlemi sonlandırıldı.");
            }
            else if (choice == 2)
            {
                goto againDo;
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz ");
                goto againTry;
            }
        }
    }
}