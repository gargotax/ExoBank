namespace ExoBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CompteCourant compteCourant = new CompteCourant();
            CompteEpargne compteEpargne = new CompteEpargne();
            Client client = new Client("client", compteCourant, compteEpargne);

            List<ICompte> comptesClient1 = new List<ICompte>();
            comptesClient1.Add(compteCourant);
            comptesClient1.Add(compteEpargne);
            //Client client = new Client("test", comptesClient1);

            client.CompteCourant.Depot(100);
            Console.WriteLine(compteCourant.Solde);
            client.VirementDeCourantVersEpargne(compteCourant, compteEpargne, 50);
            Console.WriteLine(compteCourant.Solde);
            Console.WriteLine(compteEpargne.Solde);

        }
    }
}
