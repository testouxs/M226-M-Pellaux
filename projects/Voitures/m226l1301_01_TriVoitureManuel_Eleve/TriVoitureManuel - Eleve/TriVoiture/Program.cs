using System;
using System.Collections.Generic;

namespace TriVoiture
{
    class Program
    {

        static void TriABulle(Voiture[] TableauVoiture)
        {
            /*
            tri_à_bulles_optimisé(Tableau T)
                pour i allant de (taille de T)-1 à 1
                    tableau_trié := vrai
                    pour j allant de 0 à i-1
                        si T[j+1] < T[j]
                            (T[j+1], T[j]) = (T[j], T[j+1])
                            tableau_trié := faux
                    si tableau_trié
                        fin tri_à_bulles_optimisé
            */
            for (int i = (TableauVoiture.Length - 1); i >= 1; i--)
            {
                bool tableauTrie = true;
                for (int j = 0; j <= (i - 1); j++)
                {
                    if (TableauVoiture[j+1].Puissance < TableauVoiture[j].Puissance)
                    {
                        Voiture tableauJ = TableauVoiture[j];
                        Voiture tableauJ1 = TableauVoiture[j + 1];
                        TableauVoiture[j] = tableauJ1;
                        TableauVoiture[j + 1] = tableauJ;
                        tableauTrie = false;
                    }
                }
                if (tableauTrie)
	            {
                    break; // plus grand que 1, donc on sort
	            }
            }
        }

        static List<Voiture> TriParInsertion(List<Voiture> ListeVoitures)
        {
            List<Voiture> tmp = new List<Voiture>();
            /*
            procédure tri_insertion(tableau T)
                   n ← taille(T)
                   pour i de 1 à n - 1
            
                        # mémoriser T[i] dans x
                        x ← T[i]                            

                        # décaler vers la droite les éléments de T[0]..T[i-1] qui sont plus grands que x en partant de T[i-1]
                        j ← i                               
                        tant que j > 0 et T[j - 1] > x
                                 T[j] ← T[j - 1]
                                 j ← j - 1

                        # placer x dans le "trou" laissé par le décalage
                        T[j] ← x
            */
            int n = ListeVoitures.Count;
            for (int i = 1; i < ListeVoitures.Count; i++)
            {
                Voiture x = ListeVoitures[i];
                int j = i;
                while (j > 0 && ListeVoitures[j - 1 ].Puissance > x.Puissance) 
                {
                    ListeVoitures[j] = ListeVoitures[j - 1];
                    j = j - 1;
                }
                ListeVoitures[j] = x;
            }

            tmp = ListeVoitures;
            return tmp;
        }

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

            try
            {
                Console.WriteLine("Testetetst");
                Array.Sort(TableauVoitures);
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
                TriABulle(TableauVoitures);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Tableau trié:");
                Console.WriteLine("---");
                
                for (int i = 0; i < TableauVoitures.Length; i++)
                {
                    Console.WriteLine(TableauVoitures[i].ToString());
                }
            }
            try
            {
                ListeVoitures.Sort();
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

                ListeVoitures = TriParInsertion(ListeVoitures);
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Liste trié:");
                Console.WriteLine("---");
                foreach (var item in ListeVoitures)
                {
                    Console.WriteLine(item.ToString());
                }
            } 

        }
    }
}
