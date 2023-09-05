using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
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
            //   MessageBox.Show(cariGridView.Columns["Firma_Adi"].ToString());
            cariGridView.OptionsBehavior.Editable = false;  
            cariGridView.Columns[0].Caption = "Firma Adı";
            cariGridView.Columns["Yetkili_Ad_Soyad"].Caption = "Yetkili Ad Soyad";
            cariGridView.Columns[2].Visible = false;    



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

        private void cariGridView_DoubleClick(object sender, EventArgs e)
        {
            List<int> row = cariGridView.GetSelectedRows().Where(c => c >= 0).ToList();
            row.ForEach(d =>
            {

                    txtAdSoyad.Text = cariGridView.GetRowCellValue(d, "Yetkili_Ad_Soyad").ToString();
                    txtFirmaAdi.Text = cariGridView.GetRowCellValue(d, "Firma_Adi").ToString();
                    txtVergiNo.Text = cariGridView.GetRowCellValue(d, "Vergi_No").ToString();
                    txtVergiDaire.Text = cariGridView.GetRowCellValue(d, "Vergi_Dairesi").ToString();
                    rcAdres.Text = cariGridView.GetRowCellValue(d, "Adres").ToString();

                
               

            });

        }
    }
}