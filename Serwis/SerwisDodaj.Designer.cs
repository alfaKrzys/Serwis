namespace Serwis
{
    partial class SerwisDodaj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerwisDodaj));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_NazwaFirmy = new System.Windows.Forms.TextBox();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Telefon = new System.Windows.Forms.TextBox();
            this.tb_NrDomu = new System.Windows.Forms.TextBox();
            this.tb_AdresEMail = new System.Windows.Forms.TextBox();
            this.tb_NrMieszkania = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Ulica = new System.Windows.Forms.TextBox();
            this.tb_Miasto = new System.Windows.Forms.TextBox();
            this.tb_NazwiskoOsobyDoKontaktu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ImieOsobyDoKontaktu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_KodPocztowy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieOsobyDoKontaktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrMieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punktSerwisowyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwisDataSet = new Serwis.SerwisDataSet();
            this.punktSerwisowyTableAdapter = new Serwis.SerwisDataSetTableAdapters.PunktSerwisowyTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punktSerwisowyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_NazwaFirmy);
            this.groupBox1.Controls.Add(this.b_dodaj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Telefon);
            this.groupBox1.Controls.Add(this.tb_NrDomu);
            this.groupBox1.Controls.Add(this.tb_AdresEMail);
            this.groupBox1.Controls.Add(this.tb_NrMieszkania);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Ulica);
            this.groupBox1.Controls.Add(this.tb_Miasto);
            this.groupBox1.Controls.Add(this.tb_NazwiskoOsobyDoKontaktu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ImieOsobyDoKontaktu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_KodPocztowy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(20, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Nazwa firmy*:";
            // 
            // tb_NazwaFirmy
            // 
            this.tb_NazwaFirmy.Location = new System.Drawing.Point(89, 19);
            this.tb_NazwaFirmy.Name = "tb_NazwaFirmy";
            this.tb_NazwaFirmy.Size = new System.Drawing.Size(157, 20);
            this.tb_NazwaFirmy.TabIndex = 0;
            // 
            // b_dodaj
            // 
            this.b_dodaj.Location = new System.Drawing.Point(337, 153);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(143, 23);
            this.b_dodaj.TabIndex = 10;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nr domu*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nr mieszkania:";
            // 
            // tb_Telefon
            // 
            this.tb_Telefon.Location = new System.Drawing.Point(89, 124);
            this.tb_Telefon.Name = "tb_Telefon";
            this.tb_Telefon.Size = new System.Drawing.Size(157, 20);
            this.tb_Telefon.TabIndex = 4;
            // 
            // tb_NrDomu
            // 
            this.tb_NrDomu.Location = new System.Drawing.Point(335, 19);
            this.tb_NrDomu.Name = "tb_NrDomu";
            this.tb_NrDomu.Size = new System.Drawing.Size(64, 20);
            this.tb_NrDomu.TabIndex = 5;
            // 
            // tb_AdresEMail
            // 
            this.tb_AdresEMail.Location = new System.Drawing.Point(89, 98);
            this.tb_AdresEMail.Name = "tb_AdresEMail";
            this.tb_AdresEMail.Size = new System.Drawing.Size(157, 20);
            this.tb_AdresEMail.TabIndex = 3;
            // 
            // tb_NrMieszkania
            // 
            this.tb_NrMieszkania.Location = new System.Drawing.Point(335, 45);
            this.tb_NrMieszkania.Name = "tb_NrMieszkania";
            this.tb_NrMieszkania.Size = new System.Drawing.Size(64, 20);
            this.tb_NrMieszkania.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ulica*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nazwisko:";
            // 
            // tb_Ulica
            // 
            this.tb_Ulica.Location = new System.Drawing.Point(335, 71);
            this.tb_Ulica.Name = "tb_Ulica";
            this.tb_Ulica.Size = new System.Drawing.Size(143, 20);
            this.tb_Ulica.TabIndex = 7;
            // 
            // tb_Miasto
            // 
            this.tb_Miasto.Location = new System.Drawing.Point(335, 124);
            this.tb_Miasto.Name = "tb_Miasto";
            this.tb_Miasto.Size = new System.Drawing.Size(143, 20);
            this.tb_Miasto.TabIndex = 9;
            // 
            // tb_NazwiskoOsobyDoKontaktu
            // 
            this.tb_NazwiskoOsobyDoKontaktu.Location = new System.Drawing.Point(89, 45);
            this.tb_NazwiskoOsobyDoKontaktu.Name = "tb_NazwiskoOsobyDoKontaktu";
            this.tb_NazwiskoOsobyDoKontaktu.Size = new System.Drawing.Size(157, 20);
            this.tb_NazwiskoOsobyDoKontaktu.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Adres e-mail*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Imię:";
            // 
            // tb_ImieOsobyDoKontaktu
            // 
            this.tb_ImieOsobyDoKontaktu.Location = new System.Drawing.Point(89, 71);
            this.tb_ImieOsobyDoKontaktu.Name = "tb_ImieOsobyDoKontaktu";
            this.tb_ImieOsobyDoKontaktu.Size = new System.Drawing.Size(157, 20);
            this.tb_ImieOsobyDoKontaktu.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Miasto*:";
            // 
            // tb_KodPocztowy
            // 
            this.tb_KodPocztowy.Location = new System.Drawing.Point(335, 98);
            this.tb_KodPocztowy.Name = "tb_KodPocztowy";
            this.tb_KodPocztowy.Size = new System.Drawing.Size(64, 20);
            this.tb_KodPocztowy.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Kod pocztowy*:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "* Pole musi zostać wypełnione";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazwaFirmyDataGridViewTextBoxColumn,
            this.nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn,
            this.imieOsobyDoKontaktuDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrDomuDataGridViewTextBoxColumn,
            this.nrMieszkaniaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.adresEMailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.punktSerwisowyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaFirmyDataGridViewTextBoxColumn
            // 
            this.nazwaFirmyDataGridViewTextBoxColumn.DataPropertyName = "NazwaFirmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.HeaderText = "NazwaFirmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.Name = "nazwaFirmyDataGridViewTextBoxColumn";
            // 
            // nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn
            // 
            this.nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn.DataPropertyName = "NazwiskoOsobyDoKontaktu";
            this.nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn.HeaderText = "NazwiskoOsobyDoKontaktu";
            this.nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn.Name = "nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn";
            // 
            // imieOsobyDoKontaktuDataGridViewTextBoxColumn
            // 
            this.imieOsobyDoKontaktuDataGridViewTextBoxColumn.DataPropertyName = "ImieOsobyDoKontaktu";
            this.imieOsobyDoKontaktuDataGridViewTextBoxColumn.HeaderText = "ImieOsobyDoKontaktu";
            this.imieOsobyDoKontaktuDataGridViewTextBoxColumn.Name = "imieOsobyDoKontaktuDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // nrDomuDataGridViewTextBoxColumn
            // 
            this.nrDomuDataGridViewTextBoxColumn.DataPropertyName = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.HeaderText = "NrDomu";
            this.nrDomuDataGridViewTextBoxColumn.Name = "nrDomuDataGridViewTextBoxColumn";
            // 
            // nrMieszkaniaDataGridViewTextBoxColumn
            // 
            this.nrMieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.HeaderText = "NrMieszkania";
            this.nrMieszkaniaDataGridViewTextBoxColumn.Name = "nrMieszkaniaDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            this.kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            // 
            // adresEMailDataGridViewTextBoxColumn
            // 
            this.adresEMailDataGridViewTextBoxColumn.DataPropertyName = "AdresEMail";
            this.adresEMailDataGridViewTextBoxColumn.HeaderText = "AdresEMail";
            this.adresEMailDataGridViewTextBoxColumn.Name = "adresEMailDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // punktSerwisowyBindingSource
            // 
            this.punktSerwisowyBindingSource.DataMember = "PunktSerwisowy";
            this.punktSerwisowyBindingSource.DataSource = this.serwisDataSet;
            // 
            // serwisDataSet
            // 
            this.serwisDataSet.DataSetName = "SerwisDataSet";
            this.serwisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // punktSerwisowyTableAdapter
            // 
            this.punktSerwisowyTableAdapter.ClearBeforeFill = true;
            // 
            // SerwisDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerwisDodaj";
            this.ShowInTaskbar = false;
            this.Text = "Dodaj serwis naprawczy";
            this.Load += new System.EventHandler(this.SerwisDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punktSerwisowyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.TextBox tb_Telefon;
        private System.Windows.Forms.TextBox tb_AdresEMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Miasto;
        private System.Windows.Forms.TextBox tb_NazwiskoOsobyDoKontaktu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ImieOsobyDoKontaktu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Ulica;
        private System.Windows.Forms.TextBox tb_KodPocztowy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_NrMieszkania;
        private System.Windows.Forms.TextBox tb_NrDomu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_NazwaFirmy;
        private SerwisDataSet serwisDataSet;
        private System.Windows.Forms.BindingSource punktSerwisowyBindingSource;
        private SerwisDataSetTableAdapters.PunktSerwisowyTableAdapter punktSerwisowyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoOsobyDoKontaktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieOsobyDoKontaktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrMieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresEMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}