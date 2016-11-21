namespace Serwis
{
    partial class SerwisWybierz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerwisWybierz));
            this.dgv_serwisWybierz = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_serwisWyszukaj = new System.Windows.Forms.DataGridView();
            this.b_wybierz = new System.Windows.Forms.Button();
            this.punktSerwisowyTableAdapter = new Serwis.SerwisDataSetTableAdapters.PunktSerwisowyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisWybierz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punktSerwisowyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisWyszukaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_serwisWybierz
            // 
            this.dgv_serwisWybierz.AllowUserToAddRows = false;
            this.dgv_serwisWybierz.AllowUserToDeleteRows = false;
            this.dgv_serwisWybierz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_serwisWybierz.AutoGenerateColumns = false;
            this.dgv_serwisWybierz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_serwisWybierz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serwisWybierz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_serwisWybierz.DataSource = this.punktSerwisowyBindingSource;
            this.dgv_serwisWybierz.Location = new System.Drawing.Point(12, 77);
            this.dgv_serwisWybierz.MultiSelect = false;
            this.dgv_serwisWybierz.Name = "dgv_serwisWybierz";
            this.dgv_serwisWybierz.Size = new System.Drawing.Size(598, 181);
            this.dgv_serwisWybierz.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Wyszukaj:";
            // 
            // dgv_serwisWyszukaj
            // 
            this.dgv_serwisWyszukaj.AllowUserToAddRows = false;
            this.dgv_serwisWyszukaj.AllowUserToDeleteRows = false;
            this.dgv_serwisWyszukaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_serwisWyszukaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_serwisWyszukaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_serwisWyszukaj.Location = new System.Drawing.Point(75, 11);
            this.dgv_serwisWyszukaj.Name = "dgv_serwisWyszukaj";
            this.dgv_serwisWyszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_serwisWyszukaj.Size = new System.Drawing.Size(535, 44);
            this.dgv_serwisWyszukaj.TabIndex = 4;
            this.dgv_serwisWyszukaj.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_serwisWyszukaj_CellValueChanged);
            // 
            // b_wybierz
            // 
            this.b_wybierz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_wybierz.Location = new System.Drawing.Point(274, 264);
            this.b_wybierz.Name = "b_wybierz";
            this.b_wybierz.Size = new System.Drawing.Size(75, 23);
            this.b_wybierz.TabIndex = 6;
            this.b_wybierz.Text = "Wybierz";
            this.b_wybierz.UseVisualStyleBackColor = true;
            this.b_wybierz.Click += new System.EventHandler(this.b_wybierz_Click);
            // 
            // punktSerwisowyTableAdapter
            // 
            this.punktSerwisowyTableAdapter.ClearBeforeFill = true;
            // 
            // SerwisWybierz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 299);
            this.Controls.Add(this.dgv_serwisWybierz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_serwisWyszukaj);
            this.Controls.Add(this.b_wybierz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerwisWybierz";
            this.ShowInTaskbar = false;
            this.Text = "SerwisWybierz";
            this.Load += new System.EventHandler(this.SerwisWybierz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisWybierz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punktSerwisowyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_serwisWyszukaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_serwisWybierz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_serwisWyszukaj;
        private System.Windows.Forms.Button b_wybierz;
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