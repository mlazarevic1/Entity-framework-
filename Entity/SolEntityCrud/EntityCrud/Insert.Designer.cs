﻿
namespace EntityCrud
{
    partial class Insert
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
            this.gbKlijent = new System.Windows.Forms.GroupBox();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegBroj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivKlijenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dtServis = new System.Windows.Forms.DateTimePicker();
            this.gbServis = new System.Windows.Forms.GroupBox();
            this.txtKlijentID = new System.Windows.Forms.TextBox();
            this.btnService = new System.Windows.Forms.Button();
            this.gbKlijent.SuspendLayout();
            this.gbServis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKlijent
            // 
            this.gbKlijent.Controls.Add(this.btnInsert1);
            this.gbKlijent.Controls.Add(this.txtKomentar);
            this.gbKlijent.Controls.Add(this.label4);
            this.gbKlijent.Controls.Add(this.txtKontakt);
            this.gbKlijent.Controls.Add(this.label3);
            this.gbKlijent.Controls.Add(this.txtRegBroj);
            this.gbKlijent.Controls.Add(this.label2);
            this.gbKlijent.Controls.Add(this.txtNazivKlijenta);
            this.gbKlijent.Controls.Add(this.label1);
            this.gbKlijent.Location = new System.Drawing.Point(12, 27);
            this.gbKlijent.Name = "gbKlijent";
            this.gbKlijent.Size = new System.Drawing.Size(355, 276);
            this.gbKlijent.TabIndex = 4;
            this.gbKlijent.TabStop = false;
            this.gbKlijent.Text = "Klijent insert";
            // 
            // btnInsert1
            // 
            this.btnInsert1.Location = new System.Drawing.Point(141, 230);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(113, 40);
            this.btnInsert1.TabIndex = 8;
            this.btnInsert1.Text = "Insert";
            this.btnInsert1.UseVisualStyleBackColor = true;
            this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(106, 140);
            this.txtKomentar.MaxLength = 200;
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(222, 74);
            this.txtKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentar:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(106, 104);
            this.txtKontakt.MaxLength = 40;
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(160, 20);
            this.txtKontakt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt:";
            // 
            // txtRegBroj
            // 
            this.txtRegBroj.Location = new System.Drawing.Point(106, 69);
            this.txtRegBroj.MaxLength = 20;
            this.txtRegBroj.Name = "txtRegBroj";
            this.txtRegBroj.Size = new System.Drawing.Size(160, 20);
            this.txtRegBroj.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registarski broj:";
            // 
            // txtNazivKlijenta
            // 
            this.txtNazivKlijenta.Location = new System.Drawing.Point(106, 37);
            this.txtNazivKlijenta.MaxLength = 40;
            this.txtNazivKlijenta.Name = "txtNazivKlijenta";
            this.txtNazivKlijenta.Size = new System.Drawing.Size(160, 20);
            this.txtNazivKlijenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv klijenta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "KlijentID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum servisa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Opis usluga:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(106, 105);
            this.txtOpis.MaxLength = 400;
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(222, 74);
            this.txtOpis.TabIndex = 7;
            // 
            // dtServis
            // 
            this.dtServis.Location = new System.Drawing.Point(106, 66);
            this.dtServis.Name = "dtServis";
            this.dtServis.Size = new System.Drawing.Size(200, 20);
            this.dtServis.TabIndex = 10;
            // 
            // gbServis
            // 
            this.gbServis.Controls.Add(this.txtKlijentID);
            this.gbServis.Controls.Add(this.btnService);
            this.gbServis.Controls.Add(this.dtServis);
            this.gbServis.Controls.Add(this.txtOpis);
            this.gbServis.Controls.Add(this.label5);
            this.gbServis.Controls.Add(this.label7);
            this.gbServis.Controls.Add(this.label8);
            this.gbServis.Location = new System.Drawing.Point(469, 27);
            this.gbServis.Name = "gbServis";
            this.gbServis.Size = new System.Drawing.Size(378, 276);
            this.gbServis.TabIndex = 5;
            this.gbServis.TabStop = false;
            this.gbServis.Text = "Servis insert";
            // 
            // txtKlijentID
            // 
            this.txtKlijentID.Location = new System.Drawing.Point(106, 37);
            this.txtKlijentID.MaxLength = 5;
            this.txtKlijentID.Name = "txtKlijentID";
            this.txtKlijentID.Size = new System.Drawing.Size(56, 20);
            this.txtKlijentID.TabIndex = 12;
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(138, 200);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(113, 40);
            this.btnService.TabIndex = 11;
            this.btnService.Text = "Insert service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 493);
            this.Controls.Add(this.gbServis);
            this.Controls.Add(this.gbKlijent);
            this.Name = "Insert";
            this.Text = "Insert";
            this.gbKlijent.ResumeLayout(false);
            this.gbKlijent.PerformLayout();
            this.gbServis.ResumeLayout(false);
            this.gbServis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlijent;
        private System.Windows.Forms.Button btnInsert1;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegBroj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivKlijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dtServis;
        private System.Windows.Forms.GroupBox gbServis;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.TextBox txtKlijentID;
    }
}