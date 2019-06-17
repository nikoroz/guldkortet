using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Guldkortet_Klient
{
    //TCP-Klient//
    public class TcpClientClass
    {
        private static readonly TcpClient Klient = new TcpClient();
        private const int ServerPort = 12345;

        public static void CloseConnection()
        {
            Klient.Dispose();
        }
        public static bool IsConnected()
        {
            return Klient.Connected;
        }

        //ASYNKRON METOD som skapar en anslutning till servern
        public static async void StartaAnslutning()
        {
            try
            {
                Klient.NoDelay = true;
                await Klient.ConnectAsync("127.0.0.1", ServerPort);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text.Plain);
            }
        }
        //ASYNKRON METOD som skickar en sträng till servern och startar läsning av inkommande meddelanden från servern
        public static async void StartaSändning(string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(message);

            try
            {
                await Klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text.Plain);
                return;
            }
            StartaLäsning(Klient);
        }
        //ASYNKRON METOD som startar läsning av meddelanden mottagna av TCP-klienten i parametern
        public static async void StartaLäsning(TcpClient k)
        {
            //Byte-array som lagrar bytes från inkomna meddelanden
            byte[] buffert = new byte[1024];
            int n;
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

            Form1.ShowResult(incoming);
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
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());
        }
    }
}