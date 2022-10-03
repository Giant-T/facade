using System;

namespace Facade.Lib
{
    internal class SystemeCourriel
    {
        private string addresseCourriel;

        public SystemeCourriel(string addresse)
        {
            addresseCourriel = addresse;
        }

        public void EnvoyerCourrielDemandeService(string service)
        {
            System.Console.WriteLine("demande de {0} => envoye a {1}", service, addresseCourriel);
        }

        public void EnvoyerCourrielAnnulationService(int idDemande)
        {
            System.Console.WriteLine("annulation de demande id {0} => envoye a {1}", idDemande, addresseCourriel);
        }
    }
}