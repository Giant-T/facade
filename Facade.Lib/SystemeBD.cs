using System;

namespace Facade.Lib
{
    internal class SystemeBD
    {
        private string db;

        public SystemeBD(string database)
        {
            db = database;
        }

        public int InsertionDemandeService(string service, string payeur)
        {
            Random rnd = new Random();
            System.Console.WriteLine("{0} as ete enregistre au nom de {1}", service, payeur);
            return rnd.Next(1, 200);
        }

        public void ArchiverDemandeService(int id)
        {
            System.Console.WriteLine("La demande {0} a ete archive", id);
        }
    }
}