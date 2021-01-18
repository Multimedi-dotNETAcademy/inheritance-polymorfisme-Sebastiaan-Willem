
namespace Overerving
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
            this.lblRekening = new System.Windows.Forms.Label();
            this.txtRekening = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblPrintRekening = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMinSR = new System.Windows.Forms.Button();
            this.lblPrintSpaarrekening = new System.Windows.Forms.Label();
            this.btnPlusSR = new System.Windows.Forms.Button();
            this.txtSpaarrekening = new System.Windows.Forms.TextBox();
            this.lblSpaarRekening = new System.Windows.Forms.Label();
            this.btnMinZR = new System.Windows.Forms.Button();
            this.lblPrintZR = new System.Windows.Forms.Label();
            this.btnPlusZR = new System.Windows.Forms.Button();
            this.txtZichtrekening = new System.Windows.Forms.TextBox();
            this.lblZichtrekening = new System.Windows.Forms.Label();
            this.btnRente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRekening
            // 
            this.lblRekening.AutoSize = true;
            this.lblRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRekening.Location = new System.Drawing.Point(13, 13);
            this.lblRekening.Name = "lblRekening";
            this.lblRekening.Size = new System.Drawing.Size(76, 17);
            this.lblRekening.TabIndex = 0;
            this.lblRekening.Text = "Rekening";
            // 
            // txtRekening
            // 
            this.txtRekening.Location = new System.Drawing.Point(16, 46);
            this.txtRekening.Name = "txtRekening";
            this.txtRekening.Size = new System.Drawing.Size(279, 20);
            this.txtRekening.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(319, 46);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblPrintRekening
            // 
            this.lblPrintRekening.AutoSize = true;
            this.lblPrintRekening.Location = new System.Drawing.Point(16, 82);
            this.lblPrintRekening.Name = "lblPrintRekening";
            this.lblPrintRekening.Size = new System.Drawing.Size(71, 13);
            this.lblPrintRekening.TabIndex = 4;
            this.lblPrintRekening.Text = "print rekening";
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(412, 46);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMinSR
            // 
            this.btnMinSR.Location = new System.Drawing.Point(415, 155);
            this.btnMinSR.Name = "btnMinSR";
            this.btnMinSR.Size = new System.Drawing.Size(75, 23);
            this.btnMinSR.TabIndex = 10;
            this.btnMinSR.Text = "-";
            this.btnMinSR.UseVisualStyleBackColor = true;
            this.btnMinSR.Click += new System.EventHandler(this.btnMinSR_Click);
            // 
            // lblPrintSpaarrekening
            // 
            this.lblPrintSpaarrekening.AutoSize = true;
            this.lblPrintSpaarrekening.Location = new System.Drawing.Point(19, 191);
            this.lblPrintSpaarrekening.Name = "lblPrintSpaarrekening";
            this.lblPrintSpaarrekening.Size = new System.Drawing.Size(71, 13);
            this.lblPrintSpaarrekening.TabIndex = 9;
            this.lblPrintSpaarrekening.Text = "print rekening";
            // 
            // btnPlusSR
            // 
            this.btnPlusSR.Location = new System.Drawing.Point(322, 155);
            this.btnPlusSR.Name = "btnPlusSR";
            this.btnPlusSR.Size = new System.Drawing.Size(75, 23);
            this.btnPlusSR.TabIndex = 8;
            this.btnPlusSR.Text = "+";
            this.btnPlusSR.UseVisualStyleBackColor = true;
            this.btnPlusSR.Click += new System.EventHandler(this.btnPlusSR_Click);
            // 
            // txtSpaarrekening
            // 
            this.txtSpaarrekening.Location = new System.Drawing.Point(19, 155);
            this.txtSpaarrekening.Name = "txtSpaarrekening";
            this.txtSpaarrekening.Size = new System.Drawing.Size(279, 20);
            this.txtSpaarrekening.TabIndex = 7;
            // 
            // lblSpaarRekening
            // 
            this.lblSpaarRekening.AutoSize = true;
            this.lblSpaarRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaarRekening.Location = new System.Drawing.Point(16, 122);
            this.lblSpaarRekening.Name = "lblSpaarRekening";
            this.lblSpaarRekening.Size = new System.Drawing.Size(114, 17);
            this.lblSpaarRekening.TabIndex = 6;
            this.lblSpaarRekening.Text = "Spaarrekening";
            // 
            // btnMinZR
            // 
            this.btnMinZR.Location = new System.Drawing.Point(415, 274);
            this.btnMinZR.Name = "btnMinZR";
            this.btnMinZR.Size = new System.Drawing.Size(75, 23);
            this.btnMinZR.TabIndex = 15;
            this.btnMinZR.Text = "-";
            this.btnMinZR.UseVisualStyleBackColor = true;
            this.btnMinZR.Click += new System.EventHandler(this.btnMinZR_Click);
            // 
            // lblPrintZR
            // 
            this.lblPrintZR.AutoSize = true;
            this.lblPrintZR.Location = new System.Drawing.Point(19, 310);
            this.lblPrintZR.Name = "lblPrintZR";
            this.lblPrintZR.Size = new System.Drawing.Size(71, 13);
            this.lblPrintZR.TabIndex = 14;
            this.lblPrintZR.Text = "print rekening";
            // 
            // btnPlusZR
            // 
            this.btnPlusZR.Location = new System.Drawing.Point(322, 274);
            this.btnPlusZR.Name = "btnPlusZR";
            this.btnPlusZR.Size = new System.Drawing.Size(75, 23);
            this.btnPlusZR.TabIndex = 13;
            this.btnPlusZR.Text = "+";
            this.btnPlusZR.UseVisualStyleBackColor = true;
            this.btnPlusZR.Click += new System.EventHandler(this.btnPlusZR_Click);
            // 
            // txtZichtrekening
            // 
            this.txtZichtrekening.Location = new System.Drawing.Point(19, 274);
            this.txtZichtrekening.Name = "txtZichtrekening";
            this.txtZichtrekening.Size = new System.Drawing.Size(279, 20);
            this.txtZichtrekening.TabIndex = 12;
            // 
            // lblZichtrekening
            // 
            this.lblZichtrekening.AutoSize = true;
            this.lblZichtrekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZichtrekening.Location = new System.Drawing.Point(16, 241);
            this.lblZichtrekening.Name = "lblZichtrekening";
            this.lblZichtrekening.Size = new System.Drawing.Size(107, 17);
            this.lblZichtrekening.TabIndex = 11;
            this.lblZichtrekening.Text = "Zichtrekening";
            // 
            // btnRente
            // 
            this.btnRente.Location = new System.Drawing.Point(497, 155);
            this.btnRente.Name = "btnRente";
            this.btnRente.Size = new System.Drawing.Size(75, 23);
            this.btnRente.TabIndex = 16;
            this.btnRente.Text = "Rente";
            this.btnRente.UseVisualStyleBackColor = true;
            this.btnRente.Click += new System.EventHandler(this.btnRente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 476);
            this.Controls.Add(this.btnRente);
            this.Controls.Add(this.btnMinZR);
            this.Controls.Add(this.lblPrintZR);
            this.Controls.Add(this.btnPlusZR);
            this.Controls.Add(this.txtZichtrekening);
            this.Controls.Add(this.lblZichtrekening);
            this.Controls.Add(this.btnMinSR);
            this.Controls.Add(this.lblPrintSpaarrekening);
            this.Controls.Add(this.btnPlusSR);
            this.Controls.Add(this.txtSpaarrekening);
            this.Controls.Add(this.lblSpaarRekening);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.lblPrintRekening);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtRekening);
            this.Controls.Add(this.lblRekening);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekening;
        private System.Windows.Forms.TextBox txtRekening;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblPrintRekening;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMinSR;
        private System.Windows.Forms.Label lblPrintSpaarrekening;
        private System.Windows.Forms.Button btnPlusSR;
        private System.Windows.Forms.TextBox txtSpaarrekening;
        private System.Windows.Forms.Label lblSpaarRekening;
        private System.Windows.Forms.Button btnMinZR;
        private System.Windows.Forms.Label lblPrintZR;
        private System.Windows.Forms.Button btnPlusZR;
        private System.Windows.Forms.TextBox txtZichtrekening;
        private System.Windows.Forms.Label lblZichtrekening;
        private System.Windows.Forms.Button btnRente;
    }
}

