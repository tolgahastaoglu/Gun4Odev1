using System;

namespace Gun4Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            BPG bpg = new BPG();
            bpg.ID = 1;
            bpg.isler = "Stand";

            BilgiTalebi bilgiTalebi = new BilgiTalebi();
            bilgiTalebi.Nereden = "EBB";
            bpg = bilgiTalebi;
            Console.WriteLine(bilgiTalebi.ID);
        }
        class BPG
        {
            public int ID { get; set; }
            public string isler { get; set; }
        }

        class BilgiTalebi:BPG
        {
            public string Nereden { get; set; }
        }
        
        
    }
}
