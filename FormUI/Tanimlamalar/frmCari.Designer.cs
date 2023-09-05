namespace FormUI.Tanimlamalar
{
    partial class frmCari
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
            components = new System.ComponentModel.Container();
            cariGridControl = new DevExpress.XtraGrid.GridControl();
            cariGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtFirmaAdi = new DevExpress.XtraEditors.TextEdit();
            btnCariEkle = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            txtVergiNo = new DevExpress.XtraEditors.TextEdit();
            label3 = new System.Windows.Forms.Label();
            txtVergiDaire = new DevExpress.XtraEditors.TextEdit();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtSemt = new DevExpress.XtraEditors.TextEdit();
            txtTelefon = new DevExpress.XtraEditors.TextEdit();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtMail = new DevExpress.XtraEditors.TextEdit();
            label11 = new System.Windows.Forms.Label();
            rcAdres = new System.Windows.Forms.RichTextBox();
            cmbUlke = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbSehir = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)cariGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cariGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirmaAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiDaire.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSemt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbUlke.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbSehir.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbIlce.Properties).BeginInit();
            SuspendLayout();
            // 
            // cariGridControl
            // 
            cariGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            cariGridControl.Location = new System.Drawing.Point(0, 294);
            cariGridControl.MainView = cariGridView;
            cariGridControl.Name = "cariGridControl";
            cariGridControl.Size = new System.Drawing.Size(1214, 338);
            cariGridControl.TabIndex = 0;
            cariGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { cariGridView });
            // 
            // cariGridView
            // 
            cariGridView.GridControl = cariGridControl;
            cariGridView.Name = "cariGridView";
            cariGridView.DoubleClick += cariGridView_DoubleClick;
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new System.Drawing.Point(153, 12);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new System.Drawing.Size(207, 22);
            txtFirmaAdi.TabIndex = 1;
            // 
            // btnCariEkle
            // 
            btnCariEkle.Location = new System.Drawing.Point(153, 223);
            btnCariEkle.Name = "btnCariEkle";
            btnCariEkle.Size = new System.Drawing.Size(118, 36);
            btnCariEkle.TabIndex = 12;
            btnCariEkle.Text = "Cari Ekle";
            btnCariEkle.Click += btnCariEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(81, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 16);
            label1.TabIndex = 0;
            label1.Text = "Firma Adı :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new System.Drawing.Point(153, 40);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new System.Drawing.Size(207, 22);
            txtAdSoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(110, 16);
            label2.TabIndex = 22;
            label2.Text = "Yetkili Adı Soyad :";
            // 
            // txtVergiNo
            // 
            txtVergiNo.Location = new System.Drawing.Point(153, 68);
            txtVergiNo.Name = "txtVergiNo";
            txtVergiNo.Size = new System.Drawing.Size(207, 22);
            txtVergiNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(85, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 16);
            label3.TabIndex = 14;
            label3.Text = "Vergi No :";
            // 
            // txtVergiDaire
            // 
            txtVergiDaire.Location = new System.Drawing.Point(153, 96);
            txtVergiDaire.Name = "txtVergiDaire";
            txtVergiDaire.Size = new System.Drawing.Size(207, 22);
            txtVergiDaire.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(63, 99);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(89, 16);
            label4.TabIndex = 3;
            label4.Text = "Vergi Dairesi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(81, 127);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 16);
            label5.TabIndex = 3;
            label5.Text = "Adres :";
            // 
            // txtSemt
            // 
            txtSemt.Location = new System.Drawing.Point(468, 96);
            txtSemt.Name = "txtSemt";
            txtSemt.Size = new System.Drawing.Size(207, 22);
            txtSemt.TabIndex = 9;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(468, 124);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(207, 22);
            txtTelefon.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(396, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(40, 16);
            label6.TabIndex = 3;
            label6.Text = "Ülke :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(396, 43);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 16);
            label7.TabIndex = 3;
            label7.Text = "Şehir :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(396, 71);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(36, 16);
            label8.TabIndex = 3;
            label8.Text = "İlçe :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(396, 99);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(46, 16);
            label9.TabIndex = 3;
            label9.Text = "Semt :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(396, 127);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(59, 16);
            label10.TabIndex = 3;
            label10.Text = "Telefon: ";
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(468, 155);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(207, 22);
            txtMail.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(396, 158);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 16);
            label11.TabIndex = 3;
            label11.Text = "E-Mail :";
            // 
            // rcAdres
            // 
            rcAdres.Location = new System.Drawing.Point(153, 127);
            rcAdres.Name = "rcAdres";
            rcAdres.Size = new System.Drawing.Size(207, 85);
            rcAdres.TabIndex = 5;
            rcAdres.Text = "";
            // 
            // cmbUlke
            // 
            cmbUlke.Location = new System.Drawing.Point(468, 11);
            cmbUlke.Name = "cmbUlke";
            cmbUlke.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbUlke.Size = new System.Drawing.Size(207, 22);
            cmbUlke.TabIndex = 6;
            // 
            // cmbSehir
            // 
            cmbSehir.Location = new System.Drawing.Point(468, 40);
            cmbSehir.Name = "cmbSehir";
            cmbSehir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbSehir.Size = new System.Drawing.Size(207, 22);
            cmbSehir.TabIndex = 7;
            // 
            // cmbIlce
            // 
            cmbIlce.Location = new System.Drawing.Point(468, 68);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbIlce.Size = new System.Drawing.Size(207, 22);
            cmbIlce.TabIndex = 8;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(318, 223);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(118, 36);
            btnClear.TabIndex = 23;
            btnClear.Text = "Temizle";
            btnClear.Click += btnClear_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmCari
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1214, 632);
            Controls.Add(btnClear);
            Controls.Add(cmbIlce);
            Controls.Add(cmbSehir);
            Controls.Add(cmbUlke);
            Controls.Add(rcAdres);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnCariEkle);
            Controls.Add(txtMail);
            Controls.Add(txtTelefon);
            Controls.Add(txtSemt);
            Controls.Add(txtVergiDaire);
            Controls.Add(txtVergiNo);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtFirmaAdi);
            Controls.Add(cariGridControl);
            Name = "frmCari";
            Text = "Firma Ekle";
            Load += frmCari_Load;
            ((System.ComponentModel.ISupportInitialize)cariGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)cariGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirmaAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiDaire.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSemt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbUlke.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbSehir.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbIlce.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl cariGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView cariGridView;
        private DevExpress.XtraEditors.TextEdit txtFirmaAdi;
        private DevExpress.XtraEditors.SimpleButton btnCariEkle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtVergiNo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtVergiDaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSemt;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rcAdres;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUlke;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSehir;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}