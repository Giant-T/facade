using System;

namespace Facade.Lib
{
    internal class SystemePaiement
    {
        private string username;
        private string mdp;   

        public SystemePaiement() {
            username = "boudreaultwilliam";
            mdp = "oupsJaiLeakMonMdp";
        }

        public void Payer(int prix, string service, string payeur) {
            System.Console.WriteLine("{0} a achete {1} pour {2}$", payeur, service, prix);
        }

        public void Rembourser(int idDemande) {
            System.Console.WriteLine("La demande {0} a ete rembourse.", idDemande);
        }
    }
}
