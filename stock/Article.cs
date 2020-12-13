using System;
using System.Collections.Generic;
using System.Text;

namespace stock
{
    class Article
    {
        //les attributs de l'article
        public string nom;
        public int numRéf;
        public double prixAchat;
        public double prixVente;

        //constrecteur de l'article
        public Article(string nom, int numRéf, double prixAchat, double prixVente)
        {
            this.nom = nom;
            this.numRéf = numRéf;
            this.prixAchat = prixAchat;
            this.prixVente = prixVente;
            if (prixVente < prixAchat)
            {
                throw new ArgumentException("il doit prix de vente supéreure prix d'achat!");
            }
            
        }

        //Méthode de l'affichage les attributs de l'Article
        public void afficher()
        {
            Console.WriteLine("le nom : {0} \nle numéro de référence: {1} \nle prix d'achat : {2} \nle prix de vente : {3}\n", nom, numRéf, prixAchat, prixVente);

        }


    }
}
