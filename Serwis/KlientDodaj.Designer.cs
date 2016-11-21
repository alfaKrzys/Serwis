namespace Serwis
{
    partial class KlientDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientDodaj));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_imie = new System.Windows.Forms.TextBox();
            this.tb_ulica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nrDomu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nrMieszkania = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_kodPocztowy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_adresEmail = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_miasto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_dodaj = new System.Windows.Forms.Button();
            this.dgv_tabelaKlienci = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrDomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrMieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresEMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwisDataSet = new Serwis.SerwisDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.klientTableAdapter = new Serwis.SerwisDataSetTableAdapters.KlientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaKlienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwisko*:";
            // 
            // tb_nazwisko
            // 
            this.tb_nazwisko.AutoCompleteCustomSource.AddRange(new string[] {
            "Wolski"});
            this.tb_nazwisko.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_nazwisko.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nazwisko.Location = new System.Drawing.Point(91, 19);
            this.tb_nazwisko.Name = "tb_nazwisko";
            this.tb_nazwisko.Size = new System.Drawing.Size(157, 20);
            this.tb_nazwisko.TabIndex = 0;
            this.tb_nazwisko.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imię:";
            // 
            // tb_imie
            // 
            this.tb_imie.AutoCompleteCustomSource.AddRange(new string[] {
            "Wolsk",
            "Wolski",
            "Wol"});
            this.tb_imie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_imie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_imie.Location = new System.Drawing.Point(91, 45);
            this.tb_imie.Name = "tb_imie";
            this.tb_imie.Size = new System.Drawing.Size(157, 20);
            this.tb_imie.TabIndex = 1;
            this.tb_imie.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_ulica
            // 
            this.tb_ulica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_ulica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_ulica.Location = new System.Drawing.Point(91, 123);
            this.tb_ulica.Name = "tb_ulica";
            this.tb_ulica.Size = new System.Drawing.Size(157, 20);
            this.tb_ulica.TabIndex = 4;
            this.tb_ulica.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ulica*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nr domu*:";
            // 
            // tb_nrDomu
            // 
            this.tb_nrDomu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_nrDomu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nrDomu.Location = new System.Drawing.Point(91, 71);
            this.tb_nrDomu.Name = "tb_nrDomu";
            this.tb_nrDomu.Size = new System.Drawing.Size(64, 20);
            this.tb_nrDomu.TabIndex = 2;
            this.tb_nrDomu.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nr mieszkania:";
            // 
            // tb_nrMieszkania
            // 
            this.tb_nrMieszkania.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_nrMieszkania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_nrMieszkania.Location = new System.Drawing.Point(91, 97);
            this.tb_nrMieszkania.Name = "tb_nrMieszkania";
            this.tb_nrMieszkania.Size = new System.Drawing.Size(64, 20);
            this.tb_nrMieszkania.TabIndex = 3;
            this.tb_nrMieszkania.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kod pocztowy*:";
            // 
            // tb_kodPocztowy
            // 
            this.tb_kodPocztowy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_kodPocztowy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_kodPocztowy.Location = new System.Drawing.Point(337, 19);
            this.tb_kodPocztowy.Name = "tb_kodPocztowy";
            this.tb_kodPocztowy.Size = new System.Drawing.Size(64, 20);
            this.tb_kodPocztowy.TabIndex = 5;
            this.tb_kodPocztowy.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Miasto*:";
            // 
            // tb_adresEmail
            // 
            this.tb_adresEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_adresEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_adresEmail.Location = new System.Drawing.Point(337, 74);
            this.tb_adresEmail.Name = "tb_adresEmail";
            this.tb_adresEmail.Size = new System.Drawing.Size(143, 20);
            this.tb_adresEmail.TabIndex = 7;
            this.tb_adresEmail.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb_telefon
            // 
            this.tb_telefon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_telefon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_telefon.Location = new System.Drawing.Point(337, 100);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(143, 20);
            this.tb_telefon.TabIndex = 8;
            this.tb_telefon.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon:";
            // 
            // tb_miasto
            // 
            this.tb_miasto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_miasto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_miasto.Location = new System.Drawing.Point(337, 45);
            this.tb_miasto.Name = "tb_miasto";
            this.tb_miasto.Size = new System.Drawing.Size(143, 20);
            this.tb_miasto.TabIndex = 6;
            this.tb_miasto.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Adres e-mail*:";
            // 
            // b_dodaj
            // 
            this.b_dodaj.Location = new System.Drawing.Point(337, 153);
            this.b_dodaj.Name = "b_dodaj";
            this.b_dodaj.Size = new System.Drawing.Size(143, 23);
            this.b_dodaj.TabIndex = 9;
            this.b_dodaj.Text = "Dodaj";
            this.b_dodaj.UseVisualStyleBackColor = true;
            this.b_dodaj.Click += new System.EventHandler(this.b_dodaj_Click);
            // 
            // dgv_tabelaKlienci
            // 
            this.dgv_tabelaKlienci.AllowUserToAddRows = false;
            this.dgv_tabelaKlienci.AllowUserToDeleteRows = false;
            this.dgv_tabelaKlienci.AllowUserToOrderColumns = true;
            this.dgv_tabelaKlienci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tabelaKlienci.AutoGenerateColumns = false;
            this.dgv_tabelaKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabelaKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabelaKlienci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.nrDomuDataGridViewTextBoxColumn,
            this.nrMieszkaniaDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.adresEMailDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dgv_tabelaKlienci.DataSource = this.klientBindingSource;
            this.dgv_tabelaKlienci.Location = new System.Drawing.Point(13, 193);
            this.dgv_tabelaKlienci.Name = "dgv_tabelaKlienci";
            this.dgv_tabelaKlienci.Size = new System.Drawing.Size(1048, 207);
            this.dgv_tabelaKlienci.TabIndex = 1;
            this.dgv_tabelaKlienci.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
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
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.serwisDataSet;
            // 
            // serwisDataSet
            // 
            this.serwisDataSet.DataSetName = "SerwisDataSet";
            this.serwisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_dodaj);
            this.groupBox1.Controls.Add(this.tb_telefon);
            this.groupBox1.Controls.Add(this.tb_adresEmail);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_miasto);
            this.groupBox1.Controls.Add(this.tb_nazwisko);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_imie);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_ulica);
            this.groupBox1.Controls.Add(this.tb_kodPocztowy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_nrMieszkania);
            this.groupBox1.Controls.Add(this.tb_nrDomu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "* Pole musi zostać wypełnione";
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // KlientDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_tabelaKlienci);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientDodaj";
            this.ShowInTaskbar = false;
            this.Text = "Dodaj klienta";
            this.Load += new System.EventHandler(this.KlientDodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaKlienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_imie;
        private System.Windows.Forms.TextBox tb_ulica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nrDomu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nrMieszkania;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_kodPocztowy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_adresEmail;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_miasto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_dodaj;
        private System.Windows.Forms.DataGridView dgv_tabelaKlienci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private SerwisDataSet serwisDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private SerwisDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrDomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrMieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresEMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}