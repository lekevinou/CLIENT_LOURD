using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MaBibliotheque;
namespace Gamilon_tests
{
    [TestClass]
    public class reservation
    {
        private reservationManager r;
        [TestInitialize()]
        public void Initialize()
        {
            r = new reservationManager();
        }

        [TestMethod]
        public void getUneReservationPourUneCertaineDate()
        {
            //On sait qu'il existe une réservation à 20h le 21/08/2015 en salle 1 et qu'elle porte le numéro 54
            //Vérifions si la méthode getId() fonctionne bien

            string date = "21/08/2015";
            string heure = "20:00:00";
            int salle = 1;

            Assert.AreEqual(54, r.getId(date, heure, salle));
        }


    }
}
