using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace stock
{
    class Stock
    {
        public List<Article> stok;
        public Stock()
        {
            stok = new List<Article>();
        }

        public void ajoutArticle(string nom, int numRéf, double prixAchat, double prixVente)
        {
            var article = new Article( nom, numRéf, prixAchat, prixVente);
            stok.Add(article);

        }

        public void Cherche(string nom)
        {
            var Nom = stok.Where(x => x.nom.Contains(nom));
            foreach (var item  in Nom)
            {
                item.afficher();
            }

        }

        public void saisi(double prixSaisi)
        {
            var items = stok.Where(x => x.prixAchat>prixSaisi);
            foreach (var item in items)
            {
                item.afficher();
            }
        }

        public void supprimer(string nom)
        {
            int Index = stok.FindIndex(x => x.nom.Contains(nom));
            stok.RemoveAt(Index);
        }

        public void modifier(string nom, int numRéf, double prixAchat, double prixVente, int index)
        {
            stok[index].nom = nom;
            stok[index].numRéf = numRéf;
            stok[index].prixAchat = prixAchat;
            stok[index].prixVente = prixVente;
        }
    }


}
