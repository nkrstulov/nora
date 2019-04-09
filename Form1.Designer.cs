namespace nk
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
            this.listBoxKategorija = new System.Windows.Forms.ListBox();
            this.textBoxTrosak = new System.Windows.Forms.TextBox();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.listBoxFilter = new System.Windows.Forms.ListBox();
            this.textBoxFiltrirani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxKategorija
            // 
            this.listBoxKategorija.FormattingEnabled = true;
            this.listBoxKategorija.Items.AddRange(new object[] {
            "Hrana",
            "Zabava",
            "Zdravlje",
            "Edukacija"});
            this.listBoxKategorija.Location = new System.Drawing.Point(41, 54);
            this.listBoxKategorija.Name = "listBoxKategorija";
            this.listBoxKategorija.Size = new System.Drawing.Size(125, 17);
            this.listBoxKategorija.TabIndex = 0;
            // 
            // textBoxTrosak
            // 
            this.textBoxTrosak.Location = new System.Drawing.Point(238, 51);
            this.textBoxTrosak.Name = "textBoxTrosak";
            this.textBoxTrosak.Size = new System.Drawing.Size(115, 20);
            this.textBoxTrosak.TabIndex = 1;
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(41, 170);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(312, 236);
            this.textBoxIspis.TabIndex = 2;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(133, 104);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(149, 42);
            this.buttonDodaj.TabIndex = 3;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.Location = new System.Drawing.Point(389, 226);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(127, 36);
            this.buttonFiltriraj.TabIndex = 4;
            this.buttonFiltriraj.Text = "Filter";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // listBoxFilter
            // 
            this.listBoxFilter.FormattingEnabled = true;
            this.listBoxFilter.Items.AddRange(new object[] {
            "Hrana",
            "Zabava",
            "Edukacija",
            "Zdravlje"});
            this.listBoxFilter.Location = new System.Drawing.Point(389, 190);
            this.listBoxFilter.Name = "listBoxFilter";
            this.listBoxFilter.Size = new System.Drawing.Size(127, 17);
            this.listBoxFilter.TabIndex = 5;
            // 
            // textBoxFiltrirani
            // 
            this.textBoxFiltrirani.Location = new System.Drawing.Point(383, 275);
            this.textBoxFiltrirani.Multiline = true;
            this.textBoxFiltrirani.Name = "textBoxFiltrirani";
            this.textBoxFiltrirani.Size = new System.Drawing.Size(165, 130);
            this.textBoxFiltrirani.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.textBoxFiltrirani);
            this.Controls.Add(this.listBoxFilter);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.textBoxTrosak);
            this.Controls.Add(this.listBoxKategorija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKategorija;
        private System.Windows.Forms.TextBox textBoxTrosak;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.ListBox listBoxFilter;
        private System.Windows.Forms.TextBox textBoxFiltrirani;
    }
}

