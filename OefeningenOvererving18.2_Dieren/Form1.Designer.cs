
namespace OefeningenOvererving18._2_Dieren
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
            this.rbtnKat = new System.Windows.Forms.RadioButton();
            this.rbtnPapegaai = new System.Windows.Forms.RadioButton();
            this.rbtnMens = new System.Windows.Forms.RadioButton();
            this.lblNaam = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.btnAanmaken = new System.Windows.Forms.Button();
            this.lblPraten = new System.Windows.Forms.Label();
            this.lblDieren = new System.Windows.Forms.Label();
            this.listBoxPraten = new System.Windows.Forms.ListBox();
            this.btnPraten = new System.Windows.Forms.Button();
            this.btnStrelen = new System.Windows.Forms.Button();
            this.btnEten = new System.Windows.Forms.Button();
            this.btnSluiten = new System.Windows.Forms.Button();
            this.lblHuidigDier = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnKat
            // 
            this.rbtnKat.AutoSize = true;
            this.rbtnKat.Location = new System.Drawing.Point(13, 52);
            this.rbtnKat.Name = "rbtnKat";
            this.rbtnKat.Size = new System.Drawing.Size(41, 17);
            this.rbtnKat.TabIndex = 0;
            this.rbtnKat.TabStop = true;
            this.rbtnKat.Text = "Kat";
            this.rbtnKat.UseVisualStyleBackColor = true;
            // 
            // rbtnPapegaai
            // 
            this.rbtnPapegaai.AutoSize = true;
            this.rbtnPapegaai.Location = new System.Drawing.Point(13, 76);
            this.rbtnPapegaai.Name = "rbtnPapegaai";
            this.rbtnPapegaai.Size = new System.Drawing.Size(70, 17);
            this.rbtnPapegaai.TabIndex = 1;
            this.rbtnPapegaai.TabStop = true;
            this.rbtnPapegaai.Text = "Papegaai";
            this.rbtnPapegaai.UseVisualStyleBackColor = true;
            // 
            // rbtnMens
            // 
            this.rbtnMens.AutoSize = true;
            this.rbtnMens.Location = new System.Drawing.Point(13, 100);
            this.rbtnMens.Name = "rbtnMens";
            this.rbtnMens.Size = new System.Drawing.Size(51, 17);
            this.rbtnMens.TabIndex = 2;
            this.rbtnMens.TabStop = true;
            this.rbtnMens.Text = "Mens";
            this.rbtnMens.UseVisualStyleBackColor = true;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(264, 27);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(114, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Geef je dier een naam:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(267, 65);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(147, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // btnAanmaken
            // 
            this.btnAanmaken.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAanmaken.Location = new System.Drawing.Point(525, 27);
            this.btnAanmaken.Name = "btnAanmaken";
            this.btnAanmaken.Size = new System.Drawing.Size(183, 95);
            this.btnAanmaken.TabIndex = 5;
            this.btnAanmaken.Text = "Aanmaken";
            this.btnAanmaken.UseVisualStyleBackColor = false;
            this.btnAanmaken.Click += new System.EventHandler(this.btnAanmaken_Click);
            // 
            // lblPraten
            // 
            this.lblPraten.AutoSize = true;
            this.lblPraten.Location = new System.Drawing.Point(13, 160);
            this.lblPraten.Name = "lblPraten";
            this.lblPraten.Size = new System.Drawing.Size(143, 13);
            this.lblPraten.TabIndex = 6;
            this.lblPraten.Text = "Kies een zin uit om te praten:";
            // 
            // lblDieren
            // 
            this.lblDieren.AutoSize = true;
            this.lblDieren.Location = new System.Drawing.Point(10, 27);
            this.lblDieren.Name = "lblDieren";
            this.lblDieren.Size = new System.Drawing.Size(38, 13);
            this.lblDieren.TabIndex = 7;
            this.lblDieren.Text = "Dieren";
            // 
            // listBoxPraten
            // 
            this.listBoxPraten.FormattingEnabled = true;
            this.listBoxPraten.Items.AddRange(new object[] {
            "Goeiemorgen",
            "Goeienavond",
            "Wat wil je eten?",
            "Ik ben moe.",
            "Het is hier nogal stil.",
            "Tot de volgende!"});
            this.listBoxPraten.Location = new System.Drawing.Point(13, 177);
            this.listBoxPraten.Name = "listBoxPraten";
            this.listBoxPraten.Size = new System.Drawing.Size(183, 95);
            this.listBoxPraten.TabIndex = 8;
            // 
            // btnPraten
            // 
            this.btnPraten.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPraten.Location = new System.Drawing.Point(267, 177);
            this.btnPraten.Name = "btnPraten";
            this.btnPraten.Size = new System.Drawing.Size(183, 95);
            this.btnPraten.TabIndex = 9;
            this.btnPraten.Text = "Praten";
            this.btnPraten.UseVisualStyleBackColor = false;
            this.btnPraten.Click += new System.EventHandler(this.btnPraten_Click);
            // 
            // btnStrelen
            // 
            this.btnStrelen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStrelen.Location = new System.Drawing.Point(13, 316);
            this.btnStrelen.Name = "btnStrelen";
            this.btnStrelen.Size = new System.Drawing.Size(183, 95);
            this.btnStrelen.TabIndex = 10;
            this.btnStrelen.Text = "Strelen";
            this.btnStrelen.UseVisualStyleBackColor = false;
            this.btnStrelen.Click += new System.EventHandler(this.btnStrelen_Click);
            // 
            // btnEten
            // 
            this.btnEten.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEten.Location = new System.Drawing.Point(267, 316);
            this.btnEten.Name = "btnEten";
            this.btnEten.Size = new System.Drawing.Size(183, 95);
            this.btnEten.TabIndex = 11;
            this.btnEten.Text = "Eten";
            this.btnEten.UseVisualStyleBackColor = false;
            this.btnEten.Click += new System.EventHandler(this.btnEten_Click);
            // 
            // btnSluiten
            // 
            this.btnSluiten.BackColor = System.Drawing.Color.Salmon;
            this.btnSluiten.Location = new System.Drawing.Point(525, 316);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(183, 95);
            this.btnSluiten.TabIndex = 12;
            this.btnSluiten.Text = "Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = false;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // lblHuidigDier
            // 
            this.lblHuidigDier.AutoSize = true;
            this.lblHuidigDier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuidigDier.Location = new System.Drawing.Point(537, 210);
            this.lblHuidigDier.Name = "lblHuidigDier";
            this.lblHuidigDier.Size = new System.Drawing.Size(137, 24);
            this.lblHuidigDier.TabIndex = 13;
            this.lblHuidigDier.Text = "Soort + Naam";
            this.lblHuidigDier.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHuidigDier);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnEten);
            this.Controls.Add(this.btnStrelen);
            this.Controls.Add(this.btnPraten);
            this.Controls.Add(this.listBoxPraten);
            this.Controls.Add(this.lblDieren);
            this.Controls.Add(this.lblPraten);
            this.Controls.Add(this.btnAanmaken);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.rbtnMens);
            this.Controls.Add(this.rbtnPapegaai);
            this.Controls.Add(this.rbtnKat);
            this.Name = "Form1";
            this.Text = "Dieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnKat;
        private System.Windows.Forms.RadioButton rbtnPapegaai;
        private System.Windows.Forms.RadioButton rbtnMens;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Button btnAanmaken;
        private System.Windows.Forms.Label lblPraten;
        private System.Windows.Forms.Label lblDieren;
        private System.Windows.Forms.ListBox listBoxPraten;
        private System.Windows.Forms.Button btnPraten;
        private System.Windows.Forms.Button btnStrelen;
        private System.Windows.Forms.Button btnEten;
        private System.Windows.Forms.Button btnSluiten;
        private System.Windows.Forms.Label lblHuidigDier;
    }
}

