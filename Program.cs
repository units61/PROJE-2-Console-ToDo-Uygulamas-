namespace TODO
{
    class Program 
    {
        static void Main(string[] args)
        {

            string continueProgram = "";
            while (continueProgram != "exit")

            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Board listelemek");
                Console.WriteLine("(2) Board'a kart eklemek");
                Console.WriteLine("(3) Board'dan kart silmek");
                Console.WriteLine("(4) Kart taşımak");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                    BoardListele operation1 = new BoardListele();
                    operation1.List();
                    break;
                    case 2:
                    KartEkle operation2 = new KartEkle();
                    operation2.Add();
                    break;
                    case 3:
                    KartSil operation3 = new KartSil();
                    operation3.Delete();
                    break;
                    case 4:
                    KartTasi operation4 = new KartTasi();
                    operation4.Move();
                    break;
                    default:
                    Console.WriteLine("Hatalı tuşlama yaptınız.");
                    break;
                }
            }
            
        }
    }
}