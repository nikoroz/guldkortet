using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Guldkortet
{
    //GENERISK KLASS som skapar en lista där datatypen som ska lagras anges mellan "<" och ">"
    public class EgenLista<T>
    {
        protected int Buffert;
        protected T[] Lista;
        protected int Längd;
        protected int Antal;

        //KONSTRUKTOR för klassen. Anger standardvärden för listan
        public EgenLista()
        {
            Buffert = 25;
            Antal = 0;
            Längd = 25;
            Lista = new T[Längd];
        }

        //METOD som lägger till ett element i listan
        public void LäggTill(T e)
        {
            //OM antalet platser + 1 är större än längden på listan, expandera listan
            if (Antal + 1 > Längd)
            {
                Expandera(1 + Buffert);
            }

            Lista[Antal++] = e;
        }

        //METOD som tar bort ett element ur listan. Används inte just nu.
        public T TaBort(int index)
        {
            T temp = Lista[index];

            //Flyttar alla element efter det borttagna indexet till "vänster"
            for (int i = index; i < Antal - 1; i++)
            {
                Lista[i] = Lista[i + 1];
            }

            Antal--;

            //OM antal tomma platser i listan är större än bufferten, reducera listan
            if (Längd - Antal > Buffert)
            {
                Reducera();
            }

            return temp;
        }

        //METOD som expanderar listan med tomma platser
        protected void Expandera(int storlek)
        {
            //OM listan är tom, gör ingenting
            if (storlek < 1)
            {
                return;
            }

            T[] temp = new T[Längd + storlek]; //Skapar ett större fält

            //Kopierar över alla element från den mindre listan till den större
            for (int i = 0; i < Antal; i++)
            {
                temp[i] = Lista[i];
            }

            Lista = temp; //Ersätter den mindre listan med den större
            Längd += storlek;
        }

        //METOD som krymper antalet tomma platser i listan
        protected void Reducera()
        {
            T[] temp = new T[Antal];

            //Kopierar över alla element från den större listan till den mindre
            for (int i = 0; i < Antal; i++)
            {
                temp[i] = Lista[i];
            }

            Lista = temp; //Ersätter den större listan med den mindre
            Längd = Antal;
        }

        //METOD som returnerar antalet lagrade element
        public int AntalLagradeElement()
        {
            return Antal;
        }

        //METOD som returnerar ett element som är lagrat på det angivna indexet
        public T this[int index] => Lista[index];
    }

    //ÖPPNA & SPARA FILER//
    public sealed class FileLoader
    {
        //METOD som öppnar och läser en textfil och importerar innehållet till Adminklassens Account-objektlista
        public static void OpenAccountFile(string filePath)
        {
            List<string[]> accountsToImport = new List<string[]>();

            try
            {
                //Skapar en ny lista som håller i vanliga strängar
                List<string> itemSaver = new List<string>();

                //Skapar en ny FileStream som öppnar filen och en StreamReader som läser av vad som matas in i FileStreamen
                FileStream inStröm = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader läsare = new StreamReader(inStröm, Encoding.Default))
                {
                    string filText = "";

                    //Sålänge vad StreamReader skriver till variabeln "filText" inte
                    //är lika med null så läggs strängen till i stränglistan itemSaver.
                    //Returnerar variabeln null innebär det att vi nått slutet av listan.
                    //Loopen bryts och StreamWritern går till garbage collection.
                    while ((filText = läsare.ReadLine()) != null)
                    {
                        itemSaver.Add(filText);
                    }
                }

                //För varje sträng i listan "itemSaver" skapas en ny strängvektor som sedan
                //läggs till i strängvektorlistan "accountsToImport". Splitmetoden bestämmer var
                //strängarna ska kapas för att sedan lagras separat.
                foreach (string a in itemSaver)
                {
                    string[] vektor = a.Split(new string[] { "###" }, StringSplitOptions.None);
                    accountsToImport.Add(vektor);
                }

                //För varje strängvektor i listan; skapa ett Account-objekt.
                foreach (string[] item in accountsToImport)
                {
                    Admin.AddAccount(item[0], item[1], item[2]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ogiltigt filformat för lagrade konton...\n\nFilen måste ha filändelsen \".txt\" och vara formaterad på följande sätt:\n\n" +
                    "string###string###string\n" +
                    "Id###Namn###Stad\n" +
                    "A723682791###Astrid Lindgren###Bullerbyn", "Whoops!", MessageBoxButtons.OK);
            }
        }
        //METOD som öppnar och läser en textfil och importerar innehållet till Adminklassens Vinstkort-objektlista
        public static void OpenCardFile(string filePath)
        {
            List<string[]> cardsToImport = new List<string[]>();

            try
            {
                //Skapar en ny lista som håller i vanliga strängar
                List<string> itemSaver = new List<string>();

                //Skapar en ny FileStream som öppnar filen och en StreamReader som läser av vad som matas in i FileStreamen
                FileStream inStröm = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using (StreamReader läsare = new StreamReader(inStröm, Encoding.Default))
                {
                    string filText = "";

                    //Sålänge vad StreamReader skriver till variabeln "filText" inte
                    //är lika med null så läggs strängen till i stränglistan itemSaver.
                    //Returnerar variabeln null innebär det att vi nått slutet av listan.
                    //Loopen bryts och StreamWritern går till garbage collection.
                    while ((filText = läsare.ReadLine()) != null)
                    {
                        itemSaver.Add(filText);
                    }
                }

                //För varje sträng i listan "itemSaver" skapas en ny strängvektor som sedan
                //läggs till i strängvektorlistan "cardsToImport". Splitmetoden bestämmer var
                //strängarna ska kapas för att sedan lagras separat.
                foreach (string a in itemSaver)
                {
                    string[] vektor = a.Split(new string[] { "###" }, StringSplitOptions.None);
                    cardsToImport.Add(vektor);
                }

                //För varje strängvektor i listan; skapa ett Kort-objekt.
                foreach (string[] item in cardsToImport)
                {
                    Admin.ImportCard(item[0], item[1]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Ogiltigt filformat för lagrade kort...\n\nFilen måste ha filändelsen \".txt\" och vara formaterad på följande sätt:\n\n" +
                    "string###string\n" +
                    "Id###Typ\n" +
                    "A723682791###Superdjur", "Whoops!", MessageBoxButtons.OK);
            }
        }

        //METOD som skriver Adminklassens Account-objektlista till en textfilfs
        public static void SaveAccountFile(string filePath)
        {
            try
            {
                FileStream utStröm = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                using (StreamWriter skrivare = new StreamWriter(utStröm, Encoding.Default))
                {
                    skrivare.Write(Admin.ExportList(Admin.GetAccountList()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ogiltigt namn eller filformat...\n\nSpara filen med filändelsen \".txt\"", "", MessageBoxButtons.OK);
                throw;
            }
        }
        //METOD som skriver Adminklassens Vinstkort-objektlista till en textfil
        public static void SaveCardFile(string filePath)
        {
            try
            {
                FileStream utStröm = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                using (StreamWriter skrivare = new StreamWriter(utStröm, Encoding.Default))
                {
                    skrivare.Write(Admin.ExportList(Admin.GetCardList()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ogiltigt namn eller filformat...\n\nSpara filen med filändelsen \".txt\"", "", MessageBoxButtons.OK);
                throw;
            }
        }
    }

    //SERVER//
    public sealed class TcpServer
    {
        //Deklaration av en lista som lagrar TCP-klienter, en TCP-lyssnare och en int som lagrar serverns portnummer
        private static readonly List<TcpClient> KlientList = new List<TcpClient>();
        private static TcpListener _lyssnare;
        private const int Port = 12345;


        //METOD som startar en ny TCP-lyssnare och sedan kallar på metoden StartaMottagning()
        public static void StartaServer()
        {
            try
            {
                _lyssnare = new TcpListener(IPAddress.Any, Port);
                _lyssnare.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            StartaMottagning();
        }
        //METOD som stänger ned alla anslutningar i klientlistan.
        public static void StängNedServer()
        {
            foreach (TcpClient client in KlientList)
            {
                try
                {
                    if (client.Connected)
                    {
                        client.GetStream().Close();
                        client.Dispose();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }
            }
                KlientList.Clear();
                _lyssnare.Stop();
        }

        //ASYNKRON METOD som skapar och lägger till en ny TCP-klient i TCP-klientlistan när lyssnaren har tagit emot en kontakt.
        public static async void StartaMottagning()
        {
            try
            {
                //Klienten läggs till i TCP-klientlistan och metoden StartaLäsning() blir kallad med den senast tillagda TCP-klienten i klientlistan som parameter
                TcpClient klient = await _lyssnare.AcceptTcpClientAsync();
                klient.NoDelay = true;
                KlientList.Add(klient);
                StartaLäsning(KlientList[KlientList.Count - 1]);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            //Metoden kallar på sig själv igen för att kunna acceptera en ny TCP-klientanslutning
            StartaMottagning();
        }

        //ASYNKRON METOD som startar läsning av meddelanden mottagna av en önskad TCP-klient
        public static async void StartaLäsning(TcpClient k)
        {
            //Byte-array som lagrar bytes från inkomna meddelanden
            byte[] buffert = new byte[1024];

            //Int som lagar antalet inkomna bytes
            int n = 0;

            try
            {
                //Väntar på inkommande bytes och skriver dem till buffert. Antalet inkomna bytes lagras i n
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
            //Konverterar alla bytes i buffert till en sträng
            string incoming = Encoding.Unicode.GetString(buffert, 0, n);
            
            StartaSändning(Admin.CheckForWin(incoming), k);
            StartaLäsning(k);
        }

        //ASYNKRON METOD som konverterar en sträng till bytes och skickar den vidare till den anslutna klienten
        public static async void StartaSändning(string message, TcpClient client)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);

            try
            {
                await client.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }
        }
    }

    //ADMIN//
    internal sealed class Admin
    {
        //Deklaration av en lista som lagrar account-objekt
        private static readonly EgenLista<Account> AccountList = new EgenLista<Account>();
        //Deklaration av en lista som lagrar vinstkort-objekt
        private static readonly EgenLista<Vinstkort> CardList = new EgenLista<Vinstkort>();
        
        //METOD som lägger till ett konto med känt id
        public static void AddAccount(string id, string name, string city)
        {
            AccountList.LäggTill(new Account(id, name, city));
        }
        //METOD som lägger till ett nytt konto i kontolistan med okänt id. Skulle användas för kontoregistrering
        public static void AddAccount(string name, string city)
        {
            bool accountExists = true;
            Random rnd = new Random();

            while (accountExists)
            {
                string randomAccountNumber = "A" + rnd.Next(1000000, 9999999).ToString();
                if (!AccountExists(randomAccountNumber))
                {
                    accountExists = false;
                    AccountList.LäggTill(new Account(randomAccountNumber, name, city));
                }
            }
        }

        //METOD som lägger till ett nytt kort i kortlistan
        public static void ImportCard(string id, string typ)
        {
            switch (typ)
            {
                case "Dunderkatt":
                    CardList.LäggTill(new Vinstkort.Dunderkatt(id));
                    break;
                case "Kristallhäst":
                    CardList.LäggTill(new Vinstkort.Kristallhäst(id));
                    break;
                case "Överpanda":
                    CardList.LäggTill(new Vinstkort.Överpanda(id));
                    break;
                case "Eldtomat":
                    CardList.LäggTill(new Vinstkort.Eldtomat(id));
                    break;
                default:
                    break;
            }
        }

        //METOD som returnerar true eller false beroende på om det specifika konto-id't existerar i kontolistan
        public static bool AccountExists(string id) {
            bool accountExists = false;
            for (int i = 0; i <= AccountList.AntalLagradeElement(); i++)
            {
                if (AccountList[i].UserId == id)
                {
                    accountExists = true;
                }
            }
            return accountExists;
        }

        //METOD som tar emot ett meddelande från klienten och returnerar en sträng som sedan skickas tillbaka till klienten
        public static string CheckForWin(string recievedData)
        {
            bool accountExists = false;
            bool cardExists = false;
            string name = "n/a";
            string city = "n/a";
            string typeOfCard = "n/a";
            
            try
            {
                string[] inboundData = recievedData.Split(new string[] { "-" }, StringSplitOptions.None);

                //Loopar igenom kontolistan
                for (int i = 0; i < AccountList.AntalLagradeElement(); i++)
                {
                    if (inboundData[0] == AccountList[i].UserId)
                    {
                        accountExists = true;
                        name = AccountList[i].Name;
                        city = AccountList[i].City;
                    }
                }
                //Loopar igenom kortlistan
                for (int i = 0; i < CardList.AntalLagradeElement(); i++)
                {
                    if (inboundData[1] == CardList[i].Id)
                    {
                        cardExists = true;
                        typeOfCard = CardList[i].Typ;
                    }
                }
                
                //Uppdaterar loggen
                if (accountExists && cardExists)
                {
                    Form1.UpdateLog("\r\nKundnummer: " + inboundData[0] +
                                    "\r\nNamn: " + name +
                                    "\r\nStad: " + city +
                                    "\r\nKortnummer: " + inboundData[1] +
                                    "\r\nVinst: " + typeOfCard + "\r\n");
                }
                
                return accountExists.ToString().ToLower() + "###" + cardExists.ToString().ToLower() + "###" + name + "###" + city + "###" + typeOfCard;
            }
            catch (Exception)
           {
                MessageBox.Show(
                    "Ett fel uppstod när någon kontrollerade efter vinst...", "Whoops!", MessageBoxButtons.OK);
                return "Whoops, något gick fel. Försök igen.";
            }
        }

        //GENERISK METOD som tar emot en objektlista och returnerar en sträng med alla elements ToString() i ett format som går att exportera till en textfil
        public static string ExportList<T>(EgenLista<T> exportera)
        {
            string attExportera = "";
            int currentIndex = 0;

            for (int i = 0; i < exportera.AntalLagradeElement(); i++)
            {
                attExportera += exportera[i].ToString();
                if (currentIndex < exportera.AntalLagradeElement() - 1)
                {
                    attExportera += "\r\n";
                }
                currentIndex++;
            }
            return attExportera;
        }

        //METOD som returnerar kontolistan
        public static EgenLista<Account> GetAccountList()
        {
            return AccountList;
        }
        //METOD som returnerar kortlistan
        public static EgenLista<Vinstkort> GetCardList()
        {
            return CardList;
        }
    }

    //ACCOUNT//
    internal sealed class Account
    {
        internal string UserId;
        internal string Name;
        internal string City;

        internal Account(string indataUserId, string indataName, string indataCity) {
            UserId = indataUserId;
            Name = indataName;
            City = indataCity;
        }
        public override string ToString()
        {
            return UserId + "###" + Name + "###" + City;
        }
    }

    //ABSTRAKT SUPERKLASS Vinstkort + UNDERKLASSER//
    public abstract class Vinstkort
    {
        internal string Id;
        internal string Typ;
        internal bool Claimed;

        internal Vinstkort(string indataId)
        {
            Id = indataId;
            Claimed = false;
        }

        //UNDERKLASS Dunderkatt
        internal sealed class Dunderkatt : Vinstkort
        {
            internal Dunderkatt(string indataId) :
                base(indataId)
            {
                Typ = "Dunderkatt";
            }

            public override string ToString()
            {
                return Id + "###" + Typ + "###" + Claimed;
            }
        }

        //UNDERKLASS Kristallhäst
        internal sealed class Kristallhäst : Vinstkort
        {
            internal Kristallhäst(string indataId) :
                base(indataId)
            {
                Typ = "Kristallhäst";
            }

            public override string ToString()
            {
                return Id + "###" + Typ + "###" + Claimed;
            }
        }

        //UNDERKLASS Överpanda
        internal sealed class Överpanda : Vinstkort
        {
            internal Överpanda(string indataId) :
                base(indataId)
            {
                Typ = "Överpanda";
            }

            public override string ToString()
            {
                return Id + "###" + Typ + "###" + Claimed;
            }
        }

        //UNDERKLASS Eldtomat
        internal sealed class Eldtomat : Vinstkort
        {
            internal Eldtomat(string indataId) :
                base(indataId)
            {
                Typ = "Eldtomat";
            }

            public override string ToString()
            {
                return Id + "###" + Typ + "###" + Claimed;
            }
        }
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
