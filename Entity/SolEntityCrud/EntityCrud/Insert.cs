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
    public partial class Insert : Form
    {
        TSQL dbcontext = new TSQL();
        public Insert()
        {
            InitializeComponent();
        }

       

        private void btnInsert1_Click(object sender, EventArgs e)
        {
            try
            {

                Klijent newKlijent = new Klijent { nazivKlijenta = txtNazivKlijenta.Text, registarskiBroj = txtRegBroj.Text, Kontakt = txtKontakt.Text, dodatniKomentar = txtKomentar.Text };
                dbcontext.klijenti.Add(newKlijent);
                dbcontext.SaveChanges();
                MessageBox.Show("Novi klijent je dodat");
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

        private void btnService_Click(object sender, EventArgs e)
        {
            try
            {

                Servis newServis = new Servis { klijentID =Convert.ToInt32(txtKlijentID.Text), datumServisa = dtServis.Value, opisUsluge = txtOpis.Text };
                dbcontext.servisi.Add(newServis);
                dbcontext.SaveChanges();
                MessageBox.Show("Novi servis je dodat");
                dbcontext.Dispose(); 
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
