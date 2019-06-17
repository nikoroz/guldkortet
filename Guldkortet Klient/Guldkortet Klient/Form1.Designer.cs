namespace Guldkortet_Klient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheckForWin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUserId = new System.Windows.Forms.ComboBox();
            this.textBoxCardId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontonummer (AXXXXXXX):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kortnummer (KXXXXXXXXX):";
            // 
            // buttonCheckForWin
            // 
            this.buttonCheckForWin.Enabled = false;
            this.buttonCheckForWin.Location = new System.Drawing.Point(13, 121);
            this.buttonCheckForWin.Name = "buttonCheckForWin";
            this.buttonCheckForWin.Size = new System.Drawing.Size(187, 39);
            this.buttonCheckForWin.TabIndex = 4;
            this.buttonCheckForWin.Text = "Kontrollera vinst";
            this.buttonCheckForWin.UseVisualStyleBackColor = true;
            this.buttonCheckForWin.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonConnectToServer);
            this.groupBox1.Location = new System.Drawing.Point(13, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anslutning till server:";
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.Location = new System.Drawing.Point(6, 22);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(175, 22);
            this.buttonConnectToServer.TabIndex = 0;
            this.buttonConnectToServer.Text = "Anslut";
            this.buttonConnectToServer.UseVisualStyleBackColor = true;
            this.buttonConnectToServer.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guldkortet_Klient.Properties.Resources.nos;
            this.pictureBox1.Location = new System.Drawing.Point(13, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.FormattingEnabled = true;
            this.textBoxUserId.Items.AddRange(new object[] {
            "A1044911",
            "A1084685",
            "A1098243",
            "A1245764",
            "A1405755",
            "A1683051",
            "A1900595",
            "A1931592",
            "A1971573",
            "A1986213",
            "A1999482",
            "A2196967",
            "A2300879",
            "A2737110",
            "A2781085",
            "A2986708",
            "A3268370",
            "A3374193",
            "A3400419",
            "A3438497",
            "A3507284",
            "A3592683",
            "A3715750",
            "A3741908",
            "A3801072",
            "A4909172",
            "A4968227",
            "A5201059",
            "A5238832",
            "A5358324",
            "A5454605",
            "A5879142",
            "A6122046",
            "A6155736",
            "A6288395",
            "A6487739",
            "A7079154",
            "A7097420",
            "A7110740",
            "A7325856",
            "A7736096",
            "A7748148",
            "A8100995",
            "A8531531",
            "A8543207",
            "A8656186",
            "A8688265",
            "A8909600",
            "A8959994",
            "A9454185"});
            this.textBoxUserId.Location = new System.Drawing.Point(13, 30);
            this.textBoxUserId.MaxDropDownItems = 50;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(187, 21);
            this.textBoxUserId.TabIndex = 7;
            // 
            // textBoxCardId
            // 
            this.textBoxCardId.FormattingEnabled = true;
            this.textBoxCardId.Items.AddRange(new object[] {
            "K117247315",
            "K132457414",
            "K144171384",
            "K152915327",
            "K161135470",
            "K209478647",
            "K242872563",
            "K284813933",
            "K284819759",
            "K303838339",
            "K311667009",
            "K325208482",
            "K353848019",
            "K355942503",
            "K449533271",
            "K478658462",
            "K519269524",
            "K535866685",
            "K549587658",
            "K574593993",
            "K598298903",
            "K599880106",
            "K616092046",
            "K620354764",
            "K634993396",
            "K657439566",
            "K669147621",
            "K695059897",
            "K715353871",
            "K719100736",
            "K733438926",
            "K736648364",
            "K741815436",
            "K742639121",
            "K784054851",
            "K834789453",
            "K852157464",
            "K854752475",
            "K858161987",
            "K858510023",
            "K859722150",
            "K861597278",
            "K873081558",
            "K873589343",
            "K879744392",
            "K909618038",
            "K959603624",
            "K966221891",
            "K974680568",
            "K996268086"});
            this.textBoxCardId.Location = new System.Drawing.Point(13, 89);
            this.textBoxCardId.MaxDropDownItems = 50;
            this.textBoxCardId.Name = "textBoxCardId";
            this.textBoxCardId.Size = new System.Drawing.Size(187, 21);
            this.textBoxCardId.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 337);
            this.Controls.Add(this.textBoxCardId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCheckForWin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Klient";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheckForWin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox textBoxUserId;
        private System.Windows.Forms.ComboBox textBoxCardId;
    }
}

