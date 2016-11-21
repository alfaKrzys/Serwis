namespace Serwis
{
    partial class KlientWybierz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KlientWybierz));
            this.dgv_klientWybierz = new System.Windows.Forms.DataGridView();
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
            this.dgv_klientWyszukaj = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.b_wybierz = new System.Windows.Forms.Button();
            this.klientTableAdapter = new Serwis.SerwisDataSetTableAdapters.KlientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klientWybierz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klientWyszukaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_klientWybierz
            // 
            this.dgv_klientWybierz.AllowUserToAddRows = false;
            this.dgv_klientWybierz.AllowUserToDeleteRows = false;
            this.dgv_klientWybierz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_klientWybierz.AutoGenerateColumns = false;
            this.dgv_klientWybierz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klientWybierz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klientWybierz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_klientWybierz.DataSource = this.klientBindingSource;
            this.dgv_klientWybierz.Location = new System.Drawing.Point(12, 78);
            this.dgv_klientWybierz.MultiSelect = false;
            this.dgv_klientWybierz.Name = "dgv_klientWybierz";
            this.dgv_klientWybierz.Size = new System.Drawing.Size(598, 181);
            this.dgv_klientWybierz.TabIndex = 1;
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
            // dgv_klientWyszukaj
            // 
            this.dgv_klientWyszukaj.AllowUserToAddRows = false;
            this.dgv_klientWyszukaj.AllowUserToDeleteRows = false;
            this.dgv_klientWyszukaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_klientWyszukaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klientWyszukaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klientWyszukaj.Location = new System.Drawing.Point(75, 12);
            this.dgv_klientWyszukaj.Name = "dgv_klientWyszukaj";
            this.dgv_klientWyszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_klientWyszukaj.Size = new System.Drawing.Size(535, 44);
            this.dgv_klientWyszukaj.TabIndex = 0;
            this.dgv_klientWyszukaj.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_klientWyszukaj_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wyszukaj:";
            // 
            // b_wybierz
            // 
            this.b_wybierz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_wybierz.Location = new System.Drawing.Point(274, 265);
            this.b_wybierz.Name = "b_wybierz";
            this.b_wybierz.Size = new System.Drawing.Size(75, 23);
            this.b_wybierz.TabIndex = 2;
            this.b_wybierz.Text = "Wybierz";
            this.b_wybierz.UseVisualStyleBackColor = true;
            this.b_wybierz.Click += new System.EventHandler(this.b_wybierz_Click);
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // KlientWybierz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 299);
            this.Controls.Add(this.b_wybierz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_klientWyszukaj);
            this.Controls.Add(this.dgv_klientWybierz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KlientWybierz";
            this.ShowInTaskbar = false;
            this.Text = "Wybierz Klienta";
            this.Load += new System.EventHandler(this.KlientWybierz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klientWybierz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klientWyszukaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_klientWybierz;
        private System.Windows.Forms.DataGridView dgv_klientWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_wybierz;
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