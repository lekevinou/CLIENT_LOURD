using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaBibliotheque;
namespace TestsGamilon
{
    [TestClass]
    public class TestClient
    {
        private client clientATester;
        
        [TestMethod]
        public void EstCeQueLeConstructeurEnregistrebienLeNomDuClient()
        {
            string nom_client = "BASSE";
            string prenom_client = "Kévin";
            string adr_client_l1 = "monAdresseL1";
            string ville_client = "Léognan";
            string cp_client = "33850";
            string adr_client_l2 = "monAdresseL2";
            string tel_client = "0539405968";
            string mail_client = "kevin.base@epsi.fr";

            clientATester = new client(0, nom_client, prenom_client, adr_client_l1, ville_client, cp_client, adr_client_l2, tel_client, mail_client);

            Assert.IsTrue(clientATester.Nom == "BASSE");
        }
    }
}
