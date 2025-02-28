using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    public class Client
    {
        private string civClient;
        private string nomClient;
        private string prenomClient;
        private int NumClient;

        private List<Client> lesClients = new List<Client>();

        public Client()
        {
            NumClient = 1;
            civClient = "Mr";
            nomClient = "TirLudAleDan";
            prenomClient = "TLAD";

        }

        public Client(int NumC)
        {
            NumClient = NumC;
            civClient = "Mr";
            nomClient = "TirLudAleDan";
            prenomClient = "TLAD";
        }


        public Client(string CivCli)
        {
            civClient = CivCli;
            nomClient = "TirLudAleDan";
            prenomClient = "TLAD";
        }

        public Client(string CivCli, string nomCli)
        {
            civClient = CivCli;
            nomClient = nomCli;
            prenomClient = "TLAD";
        }

        public Client(string CivCli, string nomCli, string prenomCli)
        {
            civClient = CivCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public Client(int NumC, string CivCli, string nomCli, string prenomCli)
        {
            NumClient = NumC;
            civClient = CivCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }


        public void setClient(string CivCli, string nomCli, string prenomCli)
        {
            civClient = CivCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public string getCivClient() { return civClient; }
        public string getNomClient() { return nomClient; }
        public string getPrenomClient() { return prenomClient; }

        public string getInfoClients()
        {
            return civClient + " " + nomClient + " " + prenomClient;
        }

        public int getIDClient()
        {
            return NumClient;
        }

    }
}
