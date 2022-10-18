namespace TODO;
public class BoardListele : IOperation
{
    private static Board _Boards;
    
    public void LineBoard()
    {
        var toDo = Database.Cards.Where(x => x.kolon == "TODO").ToList();
        var ınProgress = Database.Cards.Where(x => x.kolon == "IN PROGRESS").ToList();
        var done = Database.Cards.Where(x => x.kolon == "DONE").ToList();

        _Boards = new Board();
        _Boards.ToDo = toDo;
        _Boards.InProgress = ınProgress;
        _Boards.Done = done;
    }
    public void List()
    {
        LineBoard();
        ShowCard(" TODO Line", _Boards.ToDo);
        ShowCard(" IN PROGRESS Line", _Boards.InProgress);
        ShowCard(" DONE Line", _Boards.Done);

    }
    void ShowCard(string boardType,List<Kart>? listName)
    {
        Console.WriteLine("\t");
        Console.WriteLine(boardType);
        Console.WriteLine("*******************************************");
        foreach (var item in listName)
        {
            Console.WriteLine("Başlık      :  {0}", item.baslik);
            Console.WriteLine("İçerik      :  {0}", item.icerik);
            Console.WriteLine("Atanan Kişi :  {0}", item.atanakisi);
            Console.WriteLine("Büyüklük    :  {0}\n", item.buyukluk);
        }
    }
}