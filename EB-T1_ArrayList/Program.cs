using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Koleksiyon = new ArrayList();

            Koleksiyon.Add("Fatih");
            Koleksiyon.Add("Emre");
            Koleksiyon.Add("İlayda");
            Koleksiyon.Add("Suzan");

            Koleksiyon.Remove("Emre");

            Koleksiyon.Insert(2, "Deniz");

            int Count = Koleksiyon.Count;

            //Koleksiyon.Clear(); 
            bool KontrolEt = Koleksiyon.Contains("Emre");

            int SiraSAyisi = Koleksiyon.IndexOf("İlayda");
            Koleksiyon.Reverse();


            Console.WriteLine("Dizinin Eleman Sayısı : " + Count);
            Console.WriteLine(KontrolEt);
            Console.WriteLine("İlayda İsmi" + " " + SiraSAyisi + ".İndexte");


            foreach (var a in Koleksiyon)
            {
                Console.WriteLine(a);

            }

            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(25);
            rakamlar.Add(7);
            rakamlar.Add(39);

            rakamlar.Sort();

            foreach (var a in rakamlar)
            {

                Console.WriteLine(a);

            }
            Console.ReadLine();
        }

    }
}








