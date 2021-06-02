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
    public partial class Update : Form
    {
        TSQL dbcontext = new TSQL();
        public Update()
        {
            InitializeComponent();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtUKlijentID.Text);
                Klijent updateKlijenta = dbcontext.klijenti.SingleOrDefault(k => k.klijentID == id);
                updateKlijenta.klijentID = id;
                updateKlijenta.registarskiBroj = txtURegBroj.Text;
                updateKlijenta.Kontakt = txtUKontakt.Text;
                updateKlijenta.dodatniKomentar = txtUKomentar.Text;
                dbcontext.SaveChanges();
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
