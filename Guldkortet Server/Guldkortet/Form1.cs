using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guldkortet
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dlgÖppnaFil.InitialDirectory = Application.StartupPath;
            dlgSparaFil.InitialDirectory = Application.StartupPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileLoader.OpenAccountFile(dlgÖppnaFil.InitialDirectory = Application.StartupPath + "\\kundlista.txt");
            FileLoader.OpenCardFile(dlgÖppnaFil.InitialDirectory = Application.StartupPath + "\\kortlista.txt");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileLoader.SaveAccountFile(dlgÖppnaFil.InitialDirectory = Application.StartupPath + "\\kundlista.txt");
            FileLoader.SaveCardFile(dlgÖppnaFil.InitialDirectory = Application.StartupPath + "\\kortlista.txt");
        }

        private void buttonStartaServer_Click(object sender, EventArgs e)
        {
            TcpServer.StartaServer();
            buttonStängNerServer.Enabled = true;
            buttonStartaServer.Enabled = false;
            buttonStartaServer.Text = "Server Online";
            buttonStartaServer.BackColor = Color.Green;
        }

        private void buttonStängNerServer_Click(object sender, EventArgs e)
        {
            TcpServer.StängNedServer();
            buttonStartaServer.Enabled = true;
            buttonStängNerServer.Enabled = false;
            buttonStartaServer.BackColor = DefaultBackColor;
        }

        public static void UpdateLog(string logMessage)
        {
            richTextBox1.Text += (logMessage);
        }
    }
}
