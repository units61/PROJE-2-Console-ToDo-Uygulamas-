
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO;
internal class Database
{
    private static List<Kart> _Cards;
    private static List<AtananKisi> _PersonList;
    static Database()
    {
        _Cards = new List<Kart>()
        {
            
            new Kart{baslik="Ödevler", icerik="Web API ödevini yapacak. ",atanakisi="Ali", buyukluk="L",kolon="TODO" },
            new Kart{baslik="Proje", icerik="Proje dosyalarını tamamlayacak. ", atanakisi="Ayşe", buyukluk="M",kolon="IN PROGRESS" },
            new Kart{baslik="Toplantı", icerik="08.05.2022 00.00 da toplantı yapılacak ", atanakisi="Ahmet", buyukluk="XL",kolon="DONE" },
            new Kart{baslik="Egitim", icerik="Stajerlere eğitim verilecek", atanakisi="Gül", buyukluk="XS",kolon="TODO" },
        };

        _PersonList = new List<AtananKisi>()
        {
            new AtananKisi{Id=1,Name="Ali",Team="A"},
            new AtananKisi{Id=2,Name="Ayşe",Team="A"},
            new AtananKisi{Id=3,Name="Ahmet",Team="B"},
            new AtananKisi{Id=4,Name="Gül",Team="B"},
        };

    }
    public static List<Kart> Cards=>_Cards;
    public static List<AtananKisi> PersonList => _PersonList;

    
}