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
            float taxeDistrib;
            float benefice;
            float totalCharge;
            
           
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


            taxeCnc = recette * 6 / 100;
            taxeDistrib = recette / 2;
            totalCharge = taxeCnc + taxeDistrib + chargeFixe;
            benefice = recette - totalCharge;

            Console.WriteLine("");
            Console.Write("Nombre d'enfants: " + nbEnfants);
            Console.WriteLine("");
            Console.Write("Nombre d'adultes: " + nbAdultes);
            Console.WriteLine("");
            Console.Write("Nombre total de place: " + (nbEnfants + nbAdultes));
            Console.WriteLine("");
            Console.Write("Motant de la recette enfant: " + nbEnfants * prixEnfants);
            Console.WriteLine("");
            Console.Write("Montant de la recette adultes: " + nbAdultes * prixAdultes);
            Console.WriteLine("");
            Console.Write("Montant de la recette total: " + recette);
            Console.WriteLine("");
            Console.Write("Montant taxeCnc" + taxeCnc);
            Console.WriteLine("");
            Console.Write("Montant distributeur: " + taxeDistrib);
            Console.WriteLine("");
            Console.Write("Montant total des charges: " + totalCharge);
            Console.WriteLine("");
            Console.Write("Benefice: " + benefice);
            Console.WriteLine("");
            Console.Write("");






            









            Console.ReadLine();

        }
    }
}
