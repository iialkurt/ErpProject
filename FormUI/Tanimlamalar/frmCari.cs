using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormUI.Tanimlamalar
{
    public partial class frmCari : DevExpress.XtraEditors.XtraForm
    {
        CariManager cariManager = new CariManager(new EfCariDal());
        public frmCari()
        {

            InitializeComponent();
            GridLoad(cariManager);
        }

        private void GridLoad(CariManager cariManager)
        {

            cariGridControl.DataSource = cariManager.GetCariList();
        }








        private void frmCari_Load(object sender, EventArgs e)
        {



        }

        private void btnCariEkle_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtFirmaAdi.Text))
            {
                cariManager.Add(new Cari
                {
                    Firma_Adi = txtFirmaAdi.Text,
                    Yetkili_Ad_Soyad = txtAdSoyad.Text,
                    Vergi_Dairesi = txtVergiDaire.Text,
                    Vergi_No = txtVergiNo.Text,
                    Adres = rcAdres.Text,
                    Ulke = cmbUlke.Text,
                    Sehir = cmbSehir.Text,
                    Ilce = cmbIlce.Text,
                    Telefon = txtTelefon.Text,
                    Mail = txtMail.Text
                });
                MessageBox.Show("cari eklendi.");
                txtFirmaAdi.Text = string.Empty;




                GridLoad(cariManager);
            }
            else
            {
                MessageBox.Show("Lütfen Firma İsmi Giriniz.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = string.Empty;
            }
        }
    }
}