namespace Guldkortet_Klient
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureDunderkatt = new System.Windows.Forms.PictureBox();
            this.pictureEldtomat = new System.Windows.Forms.PictureBox();
            this.pictureKristallhäst = new System.Windows.Forms.PictureBox();
            this.pictureÖverpanda = new System.Windows.Forms.PictureBox();
            this.textBoxWinMsg = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunderkatt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEldtomat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKristallhäst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureÖverpanda)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureDunderkatt
            // 
            this.pictureDunderkatt.Image = global::Guldkortet_Klient.Properties.Resources.dunderkatt;
            this.pictureDunderkatt.Location = new System.Drawing.Point(63, 371);
            this.pictureDunderkatt.Name = "pictureDunderkatt";
            this.pictureDunderkatt.Size = new System.Drawing.Size(174, 150);
            this.pictureDunderkatt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDunderkatt.TabIndex = 1;
            this.pictureDunderkatt.TabStop = false;
            // 
            // pictureEldtomat
            // 
            this.pictureEldtomat.Image = global::Guldkortet_Klient.Properties.Resources.eldtomat;
            this.pictureEldtomat.Location = new System.Drawing.Point(63, 371);
            this.pictureEldtomat.Name = "pictureEldtomat";
            this.pictureEldtomat.Size = new System.Drawing.Size(174, 150);
            this.pictureEldtomat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEldtomat.TabIndex = 3;
            this.pictureEldtomat.TabStop = false;
            // 
            // pictureKristallhäst
            // 
            this.pictureKristallhäst.Image = global::Guldkortet_Klient.Properties.Resources.kristallhäst;
            this.pictureKristallhäst.Location = new System.Drawing.Point(63, 371);
            this.pictureKristallhäst.Name = "pictureKristallhäst";
            this.pictureKristallhäst.Size = new System.Drawing.Size(174, 150);
            this.pictureKristallhäst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureKristallhäst.TabIndex = 4;
            this.pictureKristallhäst.TabStop = false;
            // 
            // pictureÖverpanda
            // 
            this.pictureÖverpanda.Image = global::Guldkortet_Klient.Properties.Resources.överpanda;
            this.pictureÖverpanda.Location = new System.Drawing.Point(63, 372);
            this.pictureÖverpanda.Name = "pictureÖverpanda";
            this.pictureÖverpanda.Size = new System.Drawing.Size(174, 150);
            this.pictureÖverpanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureÖverpanda.TabIndex = 5;
            this.pictureÖverpanda.TabStop = false;
            // 
            // textBoxWinMsg
            // 
            this.textBoxWinMsg.AcceptsTab = true;
            this.textBoxWinMsg.AutoWordSelection = true;
            this.textBoxWinMsg.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWinMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWinMsg.DetectUrls = false;
            this.textBoxWinMsg.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWinMsg.Location = new System.Drawing.Point(12, 308);
            this.textBoxWinMsg.Name = "textBoxWinMsg";
            this.textBoxWinMsg.ReadOnly = true;
            this.textBoxWinMsg.ShowSelectionMargin = true;
            this.textBoxWinMsg.Size = new System.Drawing.Size(277, 57);
            this.textBoxWinMsg.TabIndex = 6;
            this.textBoxWinMsg.Text = "          Grattis Beng Larsson från Stockholm!\n\tNi har vunnit en Överpanda!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 534);
            this.Controls.Add(this.textBoxWinMsg);
            this.Controls.Add(this.pictureÖverpanda);
            this.Controls.Add(this.pictureKristallhäst);
            this.Controls.Add(this.pictureEldtomat);
            this.Controls.Add(this.pictureDunderkatt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Klient: Grattis!";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDunderkatt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEldtomat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKristallhäst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureÖverpanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureDunderkatt;
        private System.Windows.Forms.PictureBox pictureEldtomat;
        private System.Windows.Forms.PictureBox pictureKristallhäst;
        private System.Windows.Forms.PictureBox pictureÖverpanda;
        private System.Windows.Forms.RichTextBox textBoxWinMsg;
    }
}