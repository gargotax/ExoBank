using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBank
{
    public interface ICompte
    {
        public string NumeroAgence { get; }
        public int NumeroCompte { get; }
        public decimal Solde { get; set; }

        public void Retrait(decimal montant);
        public void Depot(decimal montant);
    }
}
