using System;
using Facade.Lib;

namespace Facade.App
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeService facade = new FacadeService();
            int idDemande = facade.AcheterService(20, "decoupe de feuille d'acier", "William");

            System.Console.WriteLine("AH non! Je ne veux plus ma decoupe");
            
            facade.AnnulerService(idDemande);
        }
    }
}
