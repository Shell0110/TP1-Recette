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
            string nbEnfants;
            string nbAdultes;

            int intEnfants;
            int intAdultes;

            float addEnf;
            float addAdu;


            // déclaration des constantes
            const float prix_enfants = 4.0f;
            const float prix_adultes = 5.5f;



            Console.Write("Veuillez saisir le nom du film: ");
            nomFilm = Console.ReadLine();
            


            Console.Write("Veuillez saisir le nombre de spectateurs enfant: ");
            nbEnfants = Console.ReadLine();
            int.TryParse(nbEnfants, out intEnfants);


            Console.Write("Veuillez saisir le nombre de spectateurs adulte: ");
            nbAdultes = Console.ReadLine();
            int.TryParse(nbAdultes, out intAdultes);

            addEnf = intEnfants * prix_enfants;
            addAdu = intAdultes * prix_adultes;

            Console.WriteLine("La recette est de :" + (addEnf + addAdu));
            Console.Write("pour les enfants: " + addEnf + " et pour les adultes: " + addAdu);
            

  
            Console.ReadLine();

        }
    }
}
