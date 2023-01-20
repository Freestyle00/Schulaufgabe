using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class CKomponente
    {
        private CKomponente.CSwitche schwitz = new CKomponente.CSwitche();
        private CKomponente.CFirewall firewall = new CKomponente.CFirewall();
        private CKomponente.CServer server = new CKomponente.CServer();
        private CKomponente.CKlimanlage klimaanlage = new CKomponente.CKlimanlage();
        private CKomponente.CNetzwerkkabel netzwerkkabel = new CKomponente.CNetzwerkkabel();
        private CKomponente.CWebserver webserver = new CKomponente.CWebserver();
        private CKomponente.CRechenzetrum rechenzentrum = new CKomponente.CRechenzetrum();

        public float Kostenrechnung()
        {
            rechenzentrum.Kosten = (schwitz.Kosten * schwitz.Anzahl) + (firewall.Kosten * firewall.Anzahl) + (server.Kosten * server.Anzahl) + (klimaanlage.Kosten * klimaanlage.Anzahl) + (netzwerkkabel.Kosten * netzwerkkabel.Anzahl) + (webserver.Kosten * webserver.Anzahl) + (rechenzentrum.Kosten * rechenzentrum.Anzahl);

            return rechenzentrum.Kosten;
        }
        public float Stromrechung()
        {
            rechenzentrum.Stromverbrauch = (schwitz.Stromverbrauch * schwitz.Anzahl) + (firewall.Stromverbrauch * firewall.Anzahl) + (server.Stromverbrauch * server.Anzahl) + (klimaanlage.Stromverbrauch * klimaanlage.Anzahl) + (netzwerkkabel.Stromverbrauch * netzwerkkabel.Anzahl) + (webserver.Stromverbrauch * webserver.Anzahl) + (rechenzentrum.Stromverbrauch * rechenzentrum.Anzahl);
            return rechenzentrum.Stromverbrauch;
        }

        public void Kostenzuweisung(string Komponent, float Kosten)
        {
            switch (Komponent)
            {
                case "Switche":
                    schwitz.Kosten = +Kosten;
                    break;
                case "Firewalls":
                    firewall.Kosten = +Kosten;
                    break;
                case "Server":
                    server.Kosten = +Kosten;
                    break;
                case "Klimaanlage":
                    klimaanlage.Kosten = +Kosten;
                    break;
                case "Netzwerkkabel":
                    netzwerkkabel.Kosten = +Kosten;
                    break;
                case "Webserver":
                    webserver.Kosten = +Kosten;
                    break;
                case "Rechenzentrum":
                    break;
            }
        }
        public void Stromzuweisung(string Komponent, float Stromverbrauch)
        {
            switch (Komponent)
            {
                case "Switche":
                    schwitz.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Firewalls":
                    firewall.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Server":
                    server.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Klimaanlage":
                    klimaanlage.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Netzwerkkabel":
                    netzwerkkabel.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Webserver":
                    webserver.Stromverbrauch = +Stromverbrauch;
                    break;
                case "Rechenzentrum":
                    break;
            }
        }
        public void Anzahlzuweisung(string Komponent, int Anzahl)
        {
            switch (Komponent)
            {
                case "Switche":
                    schwitz.Anzahl = +Anzahl;
                    break;
                case "Firewalls":
                    firewall.Anzahl = +Anzahl;
                    break;
                case "Server":
                    server.Anzahl = +Anzahl;
                    break;
                case "Klimaanlage":
                    klimaanlage.Anzahl = +Anzahl;
                    break;
                case "Netzwerkkabel":
                    netzwerkkabel.Anzahl = +Anzahl;
                    break;
                case "Webserver":
                    webserver.Anzahl = +Anzahl;
                    break;
                case "Rechenzentrum":
                    break;
            }
        }
        public class CSwitche
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CFirewall
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CServer
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CKlimanlage
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CNetzwerkkabel
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CWebserver
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }
        public class CRechenzetrum
        {
            public float Kosten = 0;
            public float Stromverbrauch = 0;
            public int Anzahl = 0;
        }

    }

    public static class Speicher
    {
        public static float kosten = 0;
        public static float strom = 0;
        public static CKomponente RechenKomponente = new CKomponente();
    }
}
