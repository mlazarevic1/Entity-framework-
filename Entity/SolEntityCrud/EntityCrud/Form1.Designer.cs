
namespace EntityCrud
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
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.gridKlijent = new System.Windows.Forms.DataGridView();
            this.gridServis = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.cboKlijent = new System.Windows.Forms.ComboBox();
            this.cboServis = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbServis = new System.Windows.Forms.GroupBox();
            this.txtUservisID = new System.Windows.Forms.TextBox();
            this.btnUService = new System.Windows.Forms.Button();
            this.dtUServis = new System.Windows.Forms.DateTimePicker();
            this.txtUOpis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbKlijent = new System.Windows.Forms.GroupBox();
            this.cboKlijentID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.txtUKomentar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUKontakt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURegBroj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServis)).BeginInit();
            this.gbServis.SuspendLayout();
            this.gbKlijent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(12, 12);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(121, 53);
            this.btnPrikaz.TabIndex = 0;
            this.btnPrikaz.Text = "Prikazi klijente i njihove servise";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // gridKlijent
            // 
            this.gridKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlijent.Location = new System.Drawing.Point(12, 99);
            this.gridKlijent.Name = "gridKlijent";
            this.gridKlijent.Size = new System.Drawing.Size(539, 194);
            this.gridKlijent.TabIndex = 1;
            // 
            // gridServis
            // 
            this.gridServis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServis.Location = new System.Drawing.Point(638, 99);
            this.gridServis.Name = "gridServis";
            this.gridServis.Size = new System.Drawing.Size(396, 194);
            this.gridServis.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 321);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(143, 44);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "KlijentID:";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(386, 17);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(121, 48);
            this.btnDeleteClient.TabIndex = 8;
            this.btnDeleteClient.Text = "Izbrisi klijenta";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // cboKlijent
            // 
            this.cboKlijent.FormattingEnabled = true;
            this.cboKlijent.Location = new System.Drawing.Point(259, 29);
            this.cboKlijent.Name = "cboKlijent";
            this.cboKlijent.Size = new System.Drawing.Size(121, 21);
            this.cboKlijent.TabIndex = 9;
            // 
            // cboServis
            // 
            this.cboServis.FormattingEnabled = true;
            this.cboServis.Location = new System.Drawing.Point(690, 29);
            this.cboServis.Name = "cboServis";
            this.cboServis.Size = new System.Drawing.Size(121, 21);
            this.cboServis.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Izbrisi servis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "servisID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(161, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 44);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbServis
            // 
            this.gbServis.Controls.Add(this.txtUservisID);
            this.gbServis.Controls.Add(this.btnUService);
            this.gbServis.Controls.Add(this.dtUServis);
            this.gbServis.Controls.Add(this.txtUOpis);
            this.gbServis.Controls.Add(this.label5);
            this.gbServis.Controls.Add(this.label7);
            this.gbServis.Controls.Add(this.label8);
            this.gbServis.Location = new System.Drawing.Point(690, 337);
            this.gbServis.Name = "gbServis";
            this.gbServis.Size = new System.Drawing.Size(378, 323);
            this.gbServis.TabIndex = 15;
            this.gbServis.TabStop = false;
            this.gbServis.Text = "Servis update";
            // 
            // txtUservisID
            // 
            this.txtUservisID.Location = new System.Drawing.Point(106, 37);
            this.txtUservisID.MaxLength = 5;
            this.txtUservisID.Name = "txtUservisID";
            this.txtUservisID.Size = new System.Drawing.Size(56, 20);
            this.txtUservisID.TabIndex = 12;
            // 
            // btnUService
            // 
            this.btnUService.Location = new System.Drawing.Point(138, 200);
            this.btnUService.Name = "btnUService";
            this.btnUService.Size = new System.Drawing.Size(113, 40);
            this.btnUService.TabIndex = 11;
            this.btnUService.Text = "Update service";
            this.btnUService.UseVisualStyleBackColor = true;
            this.btnUService.Click += new System.EventHandler(this.btnUService_Click);
            // 
            // dtUServis
            // 
            this.dtUServis.Location = new System.Drawing.Point(106, 66);
            this.dtUServis.Name = "dtUServis";
            this.dtUServis.Size = new System.Drawing.Size(200, 20);
            this.dtUServis.TabIndex = 10;
            // 
            // txtUOpis
            // 
            this.txtUOpis.Location = new System.Drawing.Point(106, 105);
            this.txtUOpis.MaxLength = 400;
            this.txtUOpis.Multiline = true;
            this.txtUOpis.Name = "txtUOpis";
            this.txtUOpis.Size = new System.Drawing.Size(222, 74);
            this.txtUOpis.TabIndex = 7;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Datum servisa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "servisID:";
            // 
            // gbKlijent
            // 
            this.gbKlijent.Controls.Add(this.cboKlijentID);
            this.gbKlijent.Controls.Add(this.label6);
            this.gbKlijent.Controls.Add(this.btnUpdateClient);
            this.gbKlijent.Controls.Add(this.txtUKomentar);
            this.gbKlijent.Controls.Add(this.label4);
            this.gbKlijent.Controls.Add(this.txtUKontakt);
            this.gbKlijent.Controls.Add(this.label3);
            this.gbKlijent.Controls.Add(this.txtURegBroj);
            this.gbKlijent.Controls.Add(this.label9);
            this.gbKlijent.Location = new System.Drawing.Point(329, 337);
            this.gbKlijent.Name = "gbKlijent";
            this.gbKlijent.Size = new System.Drawing.Size(355, 323);
            this.gbKlijent.TabIndex = 14;
            this.gbKlijent.TabStop = false;
            this.gbKlijent.Text = "Klijent update";
            // 
            // cboKlijentID
            // 
            this.cboKlijentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKlijentID.FormattingEnabled = true;
            this.cboKlijentID.Location = new System.Drawing.Point(106, 35);
            this.cboKlijentID.Name = "cboKlijentID";
            this.cboKlijentID.Size = new System.Drawing.Size(160, 21);
            this.cboKlijentID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Naziv klijenta:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Location = new System.Drawing.Point(130, 236);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(113, 40);
            this.btnUpdateClient.TabIndex = 8;
            this.btnUpdateClient.Text = "Update client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // txtUKomentar
            // 
            this.txtUKomentar.Location = new System.Drawing.Point(106, 141);
            this.txtUKomentar.MaxLength = 200;
            this.txtUKomentar.Multiline = true;
            this.txtUKomentar.Name = "txtUKomentar";
            this.txtUKomentar.Size = new System.Drawing.Size(222, 74);
            this.txtUKomentar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodatni komentar:";
            // 
            // txtUKontakt
            // 
            this.txtUKontakt.Location = new System.Drawing.Point(106, 105);
            this.txtUKontakt.MaxLength = 40;
            this.txtUKontakt.Name = "txtUKontakt";
            this.txtUKontakt.Size = new System.Drawing.Size(160, 20);
            this.txtUKontakt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kontakt:";
            // 
            // txtURegBroj
            // 
            this.txtURegBroj.Location = new System.Drawing.Point(106, 70);
            this.txtURegBroj.MaxLength = 20;
            this.txtURegBroj.Name = "txtURegBroj";
            this.txtURegBroj.Size = new System.Drawing.Size(160, 20);
            this.txtURegBroj.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Registarski broj:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 684);
            this.Controls.Add(this.gbServis);
            this.Controls.Add(this.gbKlijent);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboServis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKlijent);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gridServis);
            this.Controls.Add(this.gridKlijent);
            this.Controls.Add(this.btnPrikaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServis)).EndInit();
            this.gbServis.ResumeLayout(false);
            this.gbServis.PerformLayout();
            this.gbKlijent.ResumeLayout(false);
            this.gbKlijent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.DataGridView gridKlijent;
        private System.Windows.Forms.DataGridView gridServis;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ComboBox cboKlijent;
        private System.Windows.Forms.ComboBox cboServis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbServis;
        private System.Windows.Forms.TextBox txtUservisID;
        private System.Windows.Forms.Button btnUService;
        private System.Windows.Forms.DateTimePicker dtUServis;
        private System.Windows.Forms.TextBox txtUOpis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbKlijent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.TextBox txtUKomentar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUKontakt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURegBroj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboKlijentID;
    }
}

