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

            public Client()
            {
                civClient = "Mr";
                nomClient = "DanTiliLudAlex";
                prenomClient = "DTLA";

            }

            public Client(string CivCli)
            {
                civClient = CivCli;
                nomClient = "DanTiliLudAlex";
                prenomClient = "DTLA";
            }

            public Client(string CivCli, string nomCli)
            {
                civClient = CivCli;
                nomClient = nomCli;
                prenomClient = "DTLA";
            }


            public Client(string CivCli, string nomCli, string prenomCli)
            {
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


        }
 }
