using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Programme permettant de calculer des permutations, arrangements et combinaisons.
        /// </summary>
        static void Main(string[] args)
        {
            // Initialisation de la variable de choix
            int choix = 1;
            // Boucle principale du programme, jusqu'à ce que l'utilisateur choisisse de quitter
            while (choix != 0)
            {
                try
                {
                    // Affichage du menu des options disponibles
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    choix = int.Parse(Console.ReadLine());
                    // Si l'utilisateur choisit de quitter, on termine le programme
                    if (choix == 0)
                    {
                        Environment.Exit(0);
                    }
                    // Calcul de la permutation (si l'utilisateur choisit 1)
                    if (choix == 1)
                    {
                        int nombreTotalElements = GetTotalElements();
                        // calcul de r                                       
                        long r = 1;
                        for (int k = 1; k <= nombreTotalElements; k++)
                            r *= k;
                        Console.WriteLine(nombreTotalElements + "! = " + r);
                    }
                    // Calcul de l'arrangement (si l'utilisateur choisit 2)
                    if (choix == 2)
                    {
                        int nombreTotalElements = GetTotalElements();
                        int nombreSubsetElements = GetSubsetSize();
                        // calcul de r
                        long r = 1;
                        for (int k = (nombreTotalElements - nombreSubsetElements + 1); k <= nombreTotalElements; k++)
                            r *= k;
                        Console.WriteLine("A(" + nombreTotalElements + "/" + nombreSubsetElements + ") = " + r);
                    }
                    // Calcul de la combinaison (si l'utilisateur choisit 3)
                    if (choix == 3)
                    {
                        int nombreTotalElements = GetTotalElements();
                        int nombreSubsetElements = GetSubsetSize();
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (nombreTotalElements - nombreSubsetElements + 1); k <= nombreTotalElements; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= nombreSubsetElements; k++)
                            r2 *= k;
                        // calcul de r3
                        Console.WriteLine("C(" + nombreTotalElements + "/" + nombreSubsetElements + ") = " + (r1 / r2));
                    }
                    // Si l'utilisateur entre une valeur incorrecte
                    else if (choix > 3 || choix < 0 )
                    {
                        Console.WriteLine("Merci de répondre par 1;2;3 ou 0");
                    }
                }
                catch
                {
                    // Si une erreur se produit lors de la saisie
                    Console.WriteLine("Merci de répondre par 1;2;3 ou 0");
                }
            }
            // Attente de la saisie de l'utilisateur avant de quitter
            Console.ReadLine();
        }
        /// <summary>
        /// Fonction qui demande à l'utilisateur combien d'éléments il y a à gérer
        /// </summary>
        /// <returns>Le nombre total d'éléments à gérer.</returns>
        static int GetTotalElements()
        {
            // Demande du nombre total d'éléments à gérer
            Console.Write("nombre total d'éléments à gérer = ");
            int nombreTotalElements = int.Parse(Console.ReadLine());
            return nombreTotalElements;
        }
        /// <summary>
        /// Fonction qui demande à l'utilisateur combien d'éléments il y a dans le sous-ensemble
        /// </summary>
        /// <returns>Le nombre d'éléments dans le sous-ensemble.</returns>
        static int GetSubsetSize()
        {
            // Demande du nombre d'éléments dans le sous-ensemble
            Console.Write("nombre d'éléments dans le sous ensemble = ");
            int nombreSubsetElements = int.Parse(Console.ReadLine());
            return nombreSubsetElements;
        }
    }
}