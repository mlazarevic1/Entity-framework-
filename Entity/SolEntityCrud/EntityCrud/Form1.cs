using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityCrud
{
    public partial class Form1 : Form
    {
        TSQL dbcontext = new TSQL();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            gridKlijent.DataSource = dbcontext.klijenti.ToList<Klijent>();
            gridServis.DataSource = dbcontext.servisi.ToList<Servis>();

            cboKlijent.DataSource = gridKlijent.DataSource;
            cboKlijent.DisplayMember = "nazivKlijenta";
            cboKlijent.ValueMember = "klijentID";

            cboServis.DataSource = gridServis.DataSource;
            cboServis.DisplayMember = "servisID";
            cboServis.ValueMember = "servisID";
            Cursor = Cursors.Default;

            cboKlijentID.DataSource = gridKlijent.DataSource;
            cboKlijentID.DisplayMember = "nazivKlijenta";
            cboKlijentID.ValueMember = "klijentID";
        }

       

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.ShowDialog();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(cboKlijent.SelectedValue);
                Klijent a = dbcontext.klijenti.SingleOrDefault(x => x.klijentID == id);
                dbcontext.klijenti.Remove(a);
                dbcontext.SaveChanges();
                dbcontext.Dispose();
                dbcontext = new TSQL();
                btnPrikaz_Click(null, null);
                MessageBox.Show("Uspesno ste obrisali klijenta");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(cboServis.SelectedValue);
                Servis s = dbcontext.servisi.SingleOrDefault(x => x.servisID == id);
                dbcontext.servisi.Remove(s);
                dbcontext.SaveChanges();
                dbcontext.Dispose();
                dbcontext = new TSQL();
                btnPrikaz_Click(null, null);
                MessageBox.Show("Uspesno ste obrisali servis");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboKlijentID.SelectedValue);
                Klijent updateKlijenta = dbcontext.klijenti.SingleOrDefault(k => k.klijentID == id);
                updateKlijenta.klijentID = id;
                updateKlijenta.registarskiBroj = txtURegBroj.Text;
                updateKlijenta.Kontakt = txtUKontakt.Text;
                updateKlijenta.dodatniKomentar = txtUKomentar.Text;
                dbcontext.SaveChanges();
                btnPrikaz_Click(null, null);
                MessageBox.Show("Klijent je azuriran");
                dbcontext.Dispose(); // brisanje reference na objekat
                dbcontext = new TSQL();
                
            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }

                }
                dbcontext.Dispose(); // brisanje reference na objekat
                dbcontext = new TSQL();
            }
        }

        private void btnUService_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(txtUservisID.Text);
                Servis updateServis = dbcontext.servisi.SingleOrDefault(s => s.servisID == id);
                updateServis.servisID = id;
                updateServis.datumServisa = dtUServis.Value;
                updateServis.opisUsluge = txtUOpis.Text;
                dbcontext.SaveChanges();
                btnPrikaz_Click(null, null);
                MessageBox.Show("Servis je azuriran");
                dbcontext.Dispose(); // brisanje reference na objekat
                dbcontext = new TSQL();

            }
            catch (DbEntityValidationException efex)
            {
                foreach (DbEntityValidationResult s in efex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }

                }
                dbcontext.Dispose(); // brisanje reference na objekat
                dbcontext = new TSQL();
            }
        }
    }
}
