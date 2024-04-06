using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBank
{
    public class Client
    {
        public string Nom { get; }
        public CompteCourant CompteCourant { get; set; }
        public CompteEpargne CompteEpargne { get; set; }

        List<ICompte> Comptes = new List<ICompte>();
        /* public Client(string nom, List<ICompte> comptes)
         {
             Nom = nom;
             Comptes = comptes;
         }*/

        public Client(string nom, CompteCourant compteCourant, CompteEpargne compteEpargne)
        {
            Nom = nom;
            CompteEpargne = compteEpargne;
            CompteCourant = compteCourant;
        }

        public void VirementDeCourantVersEpargne(CompteCourant compteCourant, CompteEpargne compteEpargne, decimal montant)
        {
            int prixTransaction = 2;
            decimal tauxInteret = 2.5M;
            decimal interet = montant * tauxInteret;
            if (compteCourant.Solde >= montant)
            {
                compteCourant.Retrait(montant);
                compteEpargne.Depot(montant);
                compteCourant.Solde -= prixTransaction;
                compteEpargne.Solde += interet;

            }
            else throw new Exception("pas assez de fonds");
        }

        /* public void VirementDeCourantVersEpargne(ICompte comptes, decimal montant)
         {
             int prixTransaction = 2;
             decimal tauxInteret = 2.5M;
             decimal interet = montant * tauxInteret;
             foreach (ICompte compte in Comptes)
             {
                 if(compte is CompteCourant && compte.Solde>=montant)
                 {
                     compte.Retrait(montant);
                     compte.Solde -= montant;
                     compte.Solde -= prixTransaction;


                 }
                 else if (compte is CompteEpargne)
                 {
                     compte.Depot(montant);
                     compte.Solde += montant;
                     compte.Solde += interet;

                 }
                 else throw new Exception("pas assez de fonds");

             }*/
    }

}

