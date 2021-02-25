using System;
using System.Collections.Generic;

namespace TriVoiture
{
    class Program
    {

        static void TriABulle(Voiture[] TableauVoiture, string Critere)
        {
            

        }


        static void Main(string[] args)
        {
            Voiture[] TableauVoitures = new Voiture[5];
            List<Voiture> ListeVoitures = new List<Voiture>();

            TableauVoitures[0] = new Voiture("Hennessey", "Venom GT", 1244, 2011);
            TableauVoitures[1] = new Voiture("Bugatti", "Centodieci", 1600, 2020);
            TableauVoitures[2] = new Voiture("Koenigsegg", "Regera", 1500, 2015);
            TableauVoitures[3] = new Voiture("Rimac", "Concept S", 1384, 2016);
            TableauVoitures[4] = new Voiture("Aston Martin", "Valkyrie", 1176, 2019);

            //ListeVoitures.Add(new Voiture("Hennessey", "Venom GT", 1244, 2011));
            //ListeVoitures.Add(new Voiture("Bugatti", "Centodieci", 1600, 2020));
            //ListeVoitures.Add(new Voiture("Zenvo", "ST1", 1104, 2015));
            //ListeVoitures.Add(new Voiture("GTA", "Spano", 925, 2010));
            //ListeVoitures.Add(new Voiture("Ferrari", "LaFerrari", 963, 2013));
            //ListeVoitures.Add(new Voiture("Aston Martin", "Valkyrie", 1176,2019));
            //ListeVoitures.Add(new Voiture("Bristol", "T Fighter", 1012, 2007));
            //ListeVoitures.Add(new Voiture("SSC", "Tuatara", 1750, 2020));
            //ListeVoitures.Add(new Voiture("McLaren", "Speedtail", 1070, 2020));
            //ListeVoitures.Add(new Voiture("Koenigsegg", "Regera", 1500, 2015));

            Console.WriteLine("Tableau de voitures non trié");
            Console.WriteLine("---");
            for (int i = 0; i < TableauVoitures.Length; i++)
            {
                Console.WriteLine(TableauVoitures[i].ToString());
            }

            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine("Liste de voitures non trié");
            //Console.WriteLine("---");
            //foreach (var item in ListeVoitures)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Console.WriteLine(Environment.NewLine);
            TriABulle(TableauVoitures, "Annee");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Tableau trié suivant les années:");
            Console.WriteLine("---");
            for (int i = 0; i < TableauVoitures.Length; i++)
            {
                Console.WriteLine(TableauVoitures[i].ToString());
            }
            TriABulle(TableauVoitures, "Puissance");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Tableau trié suivant les puissances:");
            Console.WriteLine("---");
            for (int i = 0; i < TableauVoitures.Length; i++)
            {
                Console.WriteLine(TableauVoitures[i].ToString());
            }

        }
    }
}
