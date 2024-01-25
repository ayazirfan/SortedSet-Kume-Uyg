
using Microsoft.VisualBasic;

internal class Program
{
     static void Main(string[] args)
    {
       
        var sayilar = new List<int>();
        var r = new Random();

        Console.WriteLine("Sayılar listesi");
          

        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(r.Next(0, 1000));
            Console.Write($"{sayilar[i],-5}");
        }
        Console.WriteLine();

        //Listedeki benzersiz elemanları bulmak
        var benzersizSayilarListesi = new SortedSet<int>(sayilar);

        Console.WriteLine();
        Console.WriteLine("\nBenzersiz sayıların listesi\n");

        foreach (int sayi in benzersizSayilarListesi)
        {
            Console.Write($"{sayi,-5}");
        }
        Console.WriteLine("\nBenzersiz {0} sayı var", benzersizSayilarListesi.Count);

        // var sayilar2 = new List<int> ();
        // for (int i = 0; i < 10; i++)
        // {
        //     sayilar2.Add(r.Next(0,1000));
            
        // }

        //var A = new SortedSet<int>(sayilar); 
        // var B = new SortedSet<int>(sayilar2);
        var A = new SortedSet<int>(Rastgele(100));
        var B = new SortedSet<int>(Rastgele(100));

        Console.WriteLine();
        Console.WriteLine(" A Kümesi");
        foreach (int s in A)
        {
            Console.Write($"{s,5}");
        }
        Console.WriteLine();
        Console.WriteLine(" B Kümesi");
        foreach (int s in B)
        {
            Console.Write($"{s,5}");
        }
        
        
        //Union (Birleştirme)
        // A.UnionWith(B); //UnionWith void dikkat (refarans bazlı çalışır)
        // Console.WriteLine("\nA ve B Kümesinin birleşimi");
        // foreach (var ss in A)
        // {
        //     Console.Write($"{ss,5}");
        // }
        // Console.WriteLine();
        // Console.WriteLine("Toplam Eleman sayısı: {0}", A.Count);

        // A.IntersectWith Kesişim
    //     A.IntersectWith(B);
    //    System.Console.WriteLine();
    //    System.Console.Write("\n\n A ve B Küme Kesişim.");
    //    foreach (var s in A)
    //    {
    //     System.Console.Write($"{s,5}");
    //    }
    //    System.Console.WriteLine();
    //    System.Console.WriteLine("\nToplam sayı: {0}", A.Count);
    // A.ExceptWith(B);
    //    System.Console.WriteLine();
    //    System.Console.Write("\n\n sadece A elemanları.");
    //    foreach (var s in A)
    //    {
    //     System.Console.Write($"{s,5}");
    //    }
    //    System.Console.WriteLine();
    //    System.Console.WriteLine("\nToplam sayı: {0}", A.Count);

    A.SymmetricExceptWith(B);
       System.Console.WriteLine();
       System.Console.Write("\n\n Kesişim dışındaki elemanları.");
       foreach (var s in A)
       {
        System.Console.Write($"{s,5}");
       }
       System.Console.WriteLine();
       System.Console.WriteLine("\nToplam sayı: {0}", A.Count);
    }


    static List<int> Rastgele(int n)
    {
        var list = new List<int>();
        var r = new Random();
        for (int i = 0; i < n; i++)
        
            list.Add(r.Next(0,1000));
            return list;
        
    }
  
}


