using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guldkortet_Klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //METOD som tar emot resultatet från servern och meddelar användaren om eventuell vinst
        public static void ShowResult(string incomingMessage)
        {
            string[] winData = incomingMessage.Split(new[] {"###"}, StringSplitOptions.None);

            bool accountExists = false;
            bool cardExists = false;

            //OM servern säger att kontot existerar
            if (winData[0] == "true")
            {
                accountExists = true;
            }
            //OM servern säger att kortet existerar
            if (winData[1] == "true")
            {
                cardExists = true;
            }

            if (accountExists)
            {
                if (cardExists)
                {
                    //OM både konto och kort existerar
                    Form2.GetWinInfo(winData);      //Skickar vinstinformation till Form2
                    Form2 resultBox = new Form2();  //Skapar en ny instans av Form2
                    resultBox.Show();               //Visar Form2
                }
                else
                {
                    MessageBox.Show(@"Kortet gav ingen vinst...");
                }
            }
            else
            {
                MessageBox.Show(@"Felaktigt kontonummer!");
            }
        }

        //BUTTON för att ansluta till servern
        private void buttonConnectToServer_Click(object sender, EventArgs e)
        {
            TcpClientClass.StartaAnslutning();
            buttonConnectToServer.Enabled = false;
            buttonConnectToServer.BackColor = Color.Yellow;
            buttonConnectToServer.Text = @"Trying to connect...";
            timer1.Start();
        }

        //TIMER som kontrollerar om anslutningen lyckades
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TcpClientClass.IsConnected())
            {
                buttonConnectToServer.BackColor = Color.Green;
                buttonConnectToServer.Text = @"Connected!";
                buttonCheckForWin.Enabled = true;
                timer1.Dispose();
            }
            else
            {
                buttonConnectToServer.BackColor = DefaultBackColor;
                buttonConnectToServer.Enabled = true;
                buttonConnectToServer.Text = @"Anslut";
                timer1.Dispose();
            }
        }

        //BUTTON för att skicka konto- och kortinformation till servern
        private void button1_Click(object sender, EventArgs e)
        {
            if (TcpClientClass.IsConnected())
            {
                TcpClientClass.StartaSändning(textBoxUserId.Text + "-" + textBoxCardId.Text);
            }
            else
            {
                MessageBox.Show(@"Tappade anslutning till servern. Försök att ansluta på nytt..");
                buttonConnectToServer.BackColor = DefaultBackColor;
                buttonConnectToServer.Enabled = true;
                buttonConnectToServer.Text = @"Anslut";
                buttonCheckForWin.Enabled = false;
                TcpClientClass.CloseConnection();
            }
        }
    }
}