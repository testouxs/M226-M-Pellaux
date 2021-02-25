using System;
using System.Collections.Generic;
using System.Linq;

namespace TriVoiture
{
    class Program
    {



        static void Main(string[] args)
        {
            Voiture[] TableauVoitures = new Voiture[5];
            List<Voiture> ListeVoitures = new List<Voiture>();

            TableauVoitures[0] = new Voiture("Hennessey", "Venom GT", 1244);
            TableauVoitures[1] = new Voiture("Bugatti", "Centodieci", 1600);
            TableauVoitures[2] = new Voiture("Koenigsegg", "Regera", 1500);
            TableauVoitures[3] = new Voiture("Rimac", "Concept S", 1384);
            TableauVoitures[4] = new Voiture("Aston Martin", "Valkyrie", 1176);

            ListeVoitures.Add(new Voiture("Hennessey", "Venom GT", 1244));
            ListeVoitures.Add(new Voiture("Bugatti", "Centodieci", 1600));
            ListeVoitures.Add(new Voiture("Zenvo", "ST1", 1104));
            ListeVoitures.Add(new Voiture("GTA", "Spano", 925));
            ListeVoitures.Add(new Voiture("Ferrari", "LaFerrari", 963));
            ListeVoitures.Add(new Voiture("Aston Martin", "Valkyrie", 1176));
            ListeVoitures.Add(new Voiture("Bristol", "T Fighter", 1012));
            ListeVoitures.Add(new Voiture("SSC", "Tuatara", 1750));
            ListeVoitures.Add(new Voiture("McLaren", "Speedtail", 1070));
            ListeVoitures.Add(new Voiture("Koenigsegg", "Regera", 1500));

            Console.WriteLine("Tableau de voitures non trié");
            Console.WriteLine("---");
            for (int i = 0; i < TableauVoitures.Length; i++)
            {
                Console.WriteLine(TableauVoitures[i].ToString());
            }
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Liste de voitures non trié");
            Console.WriteLine("---");
            foreach (var item in ListeVoitures)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(Environment.NewLine);
            // Provoque une erreur
            try
            { 
                /* UTILISEZ LINQ POUR TRIER LE TABLEAU SELON LA PUISSANCE EN SENS INVERSE */

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Tableau trié:");
                Console.WriteLine("---");
                for (int i = 0; i < TableauVoitures.Length; i++)
                {
                    Console.WriteLine(TableauVoitures[i].ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Impossible de faire le tri du tableau. Quelle critère de comparaison?");             
            }
            try
            {
                /* UTILISEZ LINQ POUR TRIER LA LISTE SELON LA PUISSANCE EN SENS INVERSE */

                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Liste trié:");
                Console.WriteLine("---");
                foreach (var item in ListeVoitures)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Impossible de faire le tri du tableau. Quelle critère de comparaison?");
            } 

        }
    }
}
