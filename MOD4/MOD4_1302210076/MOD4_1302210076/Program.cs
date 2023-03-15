// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;

public class KodeBuah
{ 
    
    public static string getKodeBuah(string Buah)
    {
        Dictionary<string, string> KodeBuah = new Dictionary<string, string>();
        KodeBuah.Add("Apel", "A00");
        KodeBuah.Add("Aprikot", "B00");
        KodeBuah.Add("Alpukat", "C00");
        KodeBuah.Add("Pisang", "D00");
        KodeBuah.Add("Paprika", "E00");
        KodeBuah.Add("Blackberry", "F00");
        KodeBuah.Add("Ceri", "H00");
        KodeBuah.Add("Kelapa", "I00");
        KodeBuah.Add("Jagung", "J00");

    if (KodeBuah.ContainsKey(Buah))
        {
            return KodeBuah[Buah];

        }
        else
        {
            return "Tidak ada Data";
        }
    }



    class program
    {
        static void Main(string[] args)
        {
            KodeBuah Kodebuah = new KodeBuah();
            string buah = "Apel";
            string KodeBuahbuah = KodeBuah.getKodeBuah(buah);
            Console.WriteLine(buah + " : " + KodeBuahbuah);
        }
    }
}
