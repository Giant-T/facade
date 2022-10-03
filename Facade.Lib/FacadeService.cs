using System;

namespace Facade.Lib
{
    public class FacadeService
    {
        private SystemeBD systemeBD;
        private SystemePaiement systemePaiement;
        private SystemeCourriel systemeCourriel;

        public FacadeService() {
            systemeBD = new SystemeBD("localhost:3213213/bd");
            systemePaiement = new SystemePaiement();
            systemeCourriel = new SystemeCourriel("demandeservice@courriel.com");
        }

        public int AcheterService(int prix, string service, string payeur) {
            systemePaiement.Payer(prix, service, payeur);
            systemeCourriel.EnvoyerCourrielDemandeService(service);
            return systemeBD.InsertionDemandeService(service, payeur);
        }

        public void AnnulerService(int idDemande) {
            systemePaiement.Rembourser(idDemande);
            systemeCourriel.EnvoyerCourrielAnnulationService(idDemande);
            systemeBD.ArchiverDemandeService(idDemande);
        }
    }
}