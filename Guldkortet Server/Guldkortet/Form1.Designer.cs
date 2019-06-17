namespace Guldkortet
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
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.buttonStartaServer = new System.Windows.Forms.Button();
            this.buttonStängNerServer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            Form1.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.DefaultExt = "txt";
            // 
            // dlgSparaFil
            // 
            this.dlgSparaFil.AddExtension = false;
            this.dlgSparaFil.CreatePrompt = true;
            this.dlgSparaFil.DefaultExt = "txt";
            this.dlgSparaFil.Filter = "Text files|*.txt";
            // 
            // buttonStartaServer
            // 
            this.buttonStartaServer.Location = new System.Drawing.Point(13, 13);
            this.buttonStartaServer.Name = "buttonStartaServer";
            this.buttonStartaServer.Size = new System.Drawing.Size(100, 50);
            this.buttonStartaServer.TabIndex = 0;
            this.buttonStartaServer.Text = "Starta server";
            this.buttonStartaServer.UseVisualStyleBackColor = true;
            this.buttonStartaServer.Click += new System.EventHandler(this.buttonStartaServer_Click);
            // 
            // buttonStängNerServer
            // 
            this.buttonStängNerServer.Enabled = false;
            this.buttonStängNerServer.Location = new System.Drawing.Point(119, 13);
            this.buttonStängNerServer.Name = "buttonStängNerServer";
            this.buttonStängNerServer.Size = new System.Drawing.Size(100, 50);
            this.buttonStängNerServer.TabIndex = 2;
            this.buttonStängNerServer.Text = "Stäng ner server";
            this.buttonStängNerServer.UseVisualStyleBackColor = true;
            this.buttonStängNerServer.Click += new System.EventHandler(this.buttonStängNerServer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guldkortet.Properties.Resources.nos;
            this.pictureBox1.Location = new System.Drawing.Point(25, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 143);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            Form1.richTextBox1.Location = new System.Drawing.Point(226, 32);
            Form1.richTextBox1.Name = "richTextBox1";
            Form1.richTextBox1.ReadOnly = true;
            Form1.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            Form1.richTextBox1.Size = new System.Drawing.Size(253, 180);
            Form1.richTextBox1.TabIndex = 4;
            Form1.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vinstlogg:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(Form1.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStängNerServer);
            this.Controls.Add(this.buttonStartaServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.Button buttonStartaServer;
        private System.Windows.Forms.Button buttonStängNerServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private static System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

