using System;
using System.Linq;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            var stok = new Stock();
            try
            {
                while (true)
                {
                    Console.WriteLine("Entrez l'action à effectuer");
                    Console.WriteLine("Presse a pour ajouter");
                    Console.WriteLine("Presse b pour  Afficher tous les Articles du magasin");
                    Console.WriteLine("Presse c pour Rechercher un Article");
                    Console.WriteLine("Presse d pour Afficher les Articles dont les prix d’achat est supérieur à une valeur saisi");
                    Console.WriteLine("Presse e pour Supprimer un Article");
                    Console.WriteLine("Presse f pour Modifier un Articl");
                    /*l'opération qui l'utilisateur choisir*/
                    string action = Console.ReadLine();

                    switch (action)
                    {
                        case "a":
                            {
                                Console.WriteLine("tapis le nom d'article");
                                string nom = Console.ReadLine();
                                Console.WriteLine("tapis le référence");
                                int numRéf = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("tapis le prix d'achat");
                                double prixAchat = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("tapis le prix de vente");
                                double prixVente = Convert.ToDouble(Console.ReadLine());

                                stok.ajoutArticle(nom, numRéf, prixAchat, prixVente);
                                Console.WriteLine(stok.stok.Count());




                            }
                            break;

                        case "b":
                            {
                                foreach (var item in stok.stok)
                                {
                                    item.afficher();
                                }
                            }
                            break;

                        case "c":
                            {
                                Console.WriteLine("tapis votre nom tu veux rechercher");
                                string nom = Console.ReadLine();
                                stok.Cherche(nom);

                            }
                            break;

                        case "d":
                            {
                                Console.WriteLine("tapis votre prix");
                                double prixSaisi = Convert.ToDouble(Console.ReadLine());
                                stok.saisi(prixSaisi);

                            }
                            break;
                        case "e":
                            {
                                Console.WriteLine("entrer votre produit tu veux supprimer:");
                                String ProdName = Console.ReadLine();
                                stok.supprimer(ProdName);
                            }
                            break;
                        case "f":
                            {
                                for (var i = 0; i < stok.stok.Count; i++)
                                {
                                    Console.WriteLine("product name :" + stok.stok[i].nom);
                                    Console.WriteLine("product index : " + i);

                                }
                                Console.WriteLine("tapis index de l'article tu veux modifier");
                                int index = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter name");
                                string nom = Console.ReadLine();
                                Console.WriteLine("enter ref number");
                                int numRéf = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter price");
                                double prixAchat = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("enter sell price");
                                double prixVente = Convert.ToDouble(Console.ReadLine());
                                stok.modifier(nom, numRéf, prixAchat, prixVente, index);
                            }
                            break;

                            default:
                            Console.WriteLine("Wrong action!! try again");
                            break;


                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
