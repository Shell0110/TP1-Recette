using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoursRecette
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // déclaration variables
            string nomFilm;
            string valeurSaisie;

            int nbEnfants;
            int nbAdultes;

            float recette;
            float taxeCnc;
            float taxeDistributeur;
            float benefice;
            
           
            // déclaration des constantes
            const float prixEnfants = 4.0f;
            const float prixAdultes = 5.5f;
            const int chargeFixe = 135;

            
            Console.Write("Veuillez saisir le nom du film: ");
            nomFilm = Console.ReadLine();
            


            Console.Write("Veuillez saisir le nombre de spectateurs enfant: ");
            valeurSaisie = Console.ReadLine();
            int.TryParse(valeurSaisie, out nbEnfants);


            Console.Write("Veuillez saisir le nombre de spectateurs adulte: ");
            valeurSaisie = Console.ReadLine();
            int.TryParse(valeurSaisie, out nbAdultes);

            recette = nbEnfants * prixEnfants + nbAdultes * prixAdultes;


            // Formule

            
            taxeCnc = recette + (recette * 6 / 100);

            taxeDistributeur = taxeCnc / 2;

            benefice = taxeDistributeur - 135;

            Console.WriteLine(taxeCnc);
            Console.WriteLine(taxeDistributeur);
            Console.WriteLine(benefice);
            





            /*
            Console.WriteLine("");
            Console.WriteLine("Le nombre de places vendu des enfants est de: " + nbEnfants + " et le prix de la place est de: " + prixEnfants + " euro");
            Console.WriteLine("");
            Console.WriteLine("Le nombre de places vendu des adultes est de: " + nbAdultes + " et le prix de la place est de: " + prixAdultes + " euro");
            Console.WriteLine("");
            Console.WriteLine("Le montal total de la recette est de: " + recette);
            Console.WriteLine("");
            Console.WriteLine("Le montal total des places vendues des enfants est de: " + (nbEnfants * prixEnfants));
            Console.WriteLine("");
            Console.WriteLine("Le montal total des places vendues des adultes est de: " + (nbAdultes * prixAdultes));
            */









            Console.ReadLine();

        }
    }
}
