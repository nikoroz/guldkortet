using System;
using System.Windows.Forms;

namespace Guldkortet_Klient
{
    public partial class Form2 : Form
    {
        //Standardvärden för vinstmeddelande, uppdateras innan Form2 visas
        private static string _name = "n/a";
        private static string _city = "n/a";
        private static string _typeOfCard = "n/a";
        private static string _winMessage = "";

        //Uppdaterar vinstinformationen till egenskaperna ovan
        public static void GetWinInfo(string[] winInfo)
        {
            _name = winInfo[2];
            _city = winInfo[3];
            _typeOfCard = winInfo[4];

            _winMessage = "     " + "Gratulerar " + _name + " från " + _city + "!" + "\r\n\t" +
                         "Ni har vunnit en " + _typeOfCard + "!";
        }

        public Form2()
        {
            InitializeComponent();
        }

        //Innan Form2 visas ändras vinstmedellandet och den matchande bilden läggs i det översta lagret
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxWinMsg.Text = _winMessage;
            switch (_typeOfCard)
            {
                case "Eldtomat":
                    pictureEldtomat.BringToFront();
                    break;
                case "Överpanda":
                    pictureÖverpanda.BringToFront();
                    break;
                case "Kristallhäst":
                    pictureKristallhäst.BringToFront();
                    break;
                case "Dunderkatt":
                    pictureDunderkatt.BringToFront();
                    break;
                default:
                    break;
            }
        }
    }
}