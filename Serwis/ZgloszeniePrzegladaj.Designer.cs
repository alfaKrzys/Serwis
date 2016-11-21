namespace Serwis
{
    partial class ZgloszeniePrzegladaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZgloszeniePrzegladaj));
            this.dgv_ZgloszenieSerwisoweWybierz = new System.Windows.Forms.DataGridView();
            this.zgloszenieSerwisoweBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serwisDataSet = new Serwis.SerwisDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.b_drukuj = new System.Windows.Forms.Button();
            this.zgloszenieSerwisoweTableAdapter = new Serwis.SerwisDataSetTableAdapters.ZgloszenieSerwisoweTableAdapter();
            this.dgv_ZgloszenieSerwisoweWyszukaj = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_modyfikuj = new System.Windows.Forms.Button();
            this.cb_StatusZgloszenia = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaFirmyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisUsterkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZgloszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusZgloszeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRealizacjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZgloszenieSerwisoweWybierz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszenieSerwisoweBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZgloszenieSerwisoweWyszukaj)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ZgloszenieSerwisoweWybierz
            // 
            this.dgv_ZgloszenieSerwisoweWybierz.AllowUserToAddRows = false;
            this.dgv_ZgloszenieSerwisoweWybierz.AllowUserToDeleteRows = false;
            this.dgv_ZgloszenieSerwisoweWybierz.AllowUserToOrderColumns = true;
            this.dgv_ZgloszenieSerwisoweWybierz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ZgloszenieSerwisoweWybierz.AutoGenerateColumns = false;
            this.dgv_ZgloszenieSerwisoweWybierz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ZgloszenieSerwisoweWybierz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ZgloszenieSerwisoweWybierz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwaFirmyDataGridViewTextBoxColumn,
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn,
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn,
            this.opisUsterkiDataGridViewTextBoxColumn,
            this.dataZgloszeniaDataGridViewTextBoxColumn,
            this.statusZgloszeniaDataGridViewTextBoxColumn,
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn,
            this.dataRealizacjiDataGridViewTextBoxColumn});
            this.dgv_ZgloszenieSerwisoweWybierz.DataSource = this.zgloszenieSerwisoweBindingSource;
            this.dgv_ZgloszenieSerwisoweWybierz.Location = new System.Drawing.Point(12, 97);
            this.dgv_ZgloszenieSerwisoweWybierz.MultiSelect = false;
            this.dgv_ZgloszenieSerwisoweWybierz.Name = "dgv_ZgloszenieSerwisoweWybierz";
            this.dgv_ZgloszenieSerwisoweWybierz.ReadOnly = true;
            this.dgv_ZgloszenieSerwisoweWybierz.Size = new System.Drawing.Size(590, 179);
            this.dgv_ZgloszenieSerwisoweWybierz.TabIndex = 9;
            // 
            // zgloszenieSerwisoweBindingSource
            // 
            this.zgloszenieSerwisoweBindingSource.DataMember = "ZgloszenieSerwisowe";
            this.zgloszenieSerwisoweBindingSource.DataSource = this.serwisDataSet;
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
            this.label1.TabIndex = 11;
            this.label1.Text = "Wyszukaj:";
            // 
            // b_drukuj
            // 
            this.b_drukuj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_drukuj.Location = new System.Drawing.Point(274, 282);
            this.b_drukuj.Name = "b_drukuj";
            this.b_drukuj.Size = new System.Drawing.Size(67, 23);
            this.b_drukuj.TabIndex = 10;
            this.b_drukuj.Text = "Drukuj";
            this.b_drukuj.UseVisualStyleBackColor = true;
            this.b_drukuj.Click += new System.EventHandler(this.b_drukuj_Click);
            // 
            // zgloszenieSerwisoweTableAdapter
            // 
            this.zgloszenieSerwisoweTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_ZgloszenieSerwisoweWyszukaj
            // 
            this.dgv_ZgloszenieSerwisoweWyszukaj.AllowUserToAddRows = false;
            this.dgv_ZgloszenieSerwisoweWyszukaj.AllowUserToDeleteRows = false;
            this.dgv_ZgloszenieSerwisoweWyszukaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ZgloszenieSerwisoweWyszukaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ZgloszenieSerwisoweWyszukaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ZgloszenieSerwisoweWyszukaj.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_ZgloszenieSerwisoweWyszukaj.Location = new System.Drawing.Point(75, 12);
            this.dgv_ZgloszenieSerwisoweWyszukaj.Name = "dgv_ZgloszenieSerwisoweWyszukaj";
            this.dgv_ZgloszenieSerwisoweWyszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv_ZgloszenieSerwisoweWyszukaj.Size = new System.Drawing.Size(526, 79);
            this.dgv_ZgloszenieSerwisoweWyszukaj.TabIndex = 12;
            this.dgv_ZgloszenieSerwisoweWyszukaj.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ZgloszenieSerwisoweWyszukaj_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.b_modyfikuj);
            this.groupBox1.Controls.Add(this.cb_StatusZgloszenia);
            this.groupBox1.Location = new System.Drawing.Point(608, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 50);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmiana stausu zgłoszenia";
            // 
            // b_modyfikuj
            // 
            this.b_modyfikuj.Location = new System.Drawing.Point(171, 18);
            this.b_modyfikuj.Name = "b_modyfikuj";
            this.b_modyfikuj.Size = new System.Drawing.Size(75, 23);
            this.b_modyfikuj.TabIndex = 1;
            this.b_modyfikuj.Text = "Modyfikuj";
            this.b_modyfikuj.UseVisualStyleBackColor = true;
            this.b_modyfikuj.Click += new System.EventHandler(this.b_modyfikuj_Click);
            // 
            // cb_StatusZgloszenia
            // 
            this.cb_StatusZgloszenia.Location = new System.Drawing.Point(7, 20);
            this.cb_StatusZgloszenia.Name = "cb_StatusZgloszenia";
            this.cb_StatusZgloszenia.Size = new System.Drawing.Size(158, 21);
            this.cb_StatusZgloszenia.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaFirmyDataGridViewTextBoxColumn
            // 
            this.nazwaFirmyDataGridViewTextBoxColumn.DataPropertyName = "NazwaFirmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.HeaderText = "Nazwa Firmy";
            this.nazwaFirmyDataGridViewTextBoxColumn.Name = "nazwaFirmyDataGridViewTextBoxColumn";
            this.nazwaFirmyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaUrzadzeniaDataGridViewTextBoxColumn
            // 
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn.DataPropertyName = "NazwaUrzadzenia";
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn.HeaderText = "Nazwa Urzadzenia";
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn.Name = "nazwaUrzadzeniaDataGridViewTextBoxColumn";
            this.nazwaUrzadzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn
            // 
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn.DataPropertyName = "NrSeryjnyUrzadzenia";
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn.HeaderText = "Nr Seryjny Urządzenia";
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn.Name = "nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn";
            this.nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisUsterkiDataGridViewTextBoxColumn
            // 
            this.opisUsterkiDataGridViewTextBoxColumn.DataPropertyName = "OpisUsterki";
            this.opisUsterkiDataGridViewTextBoxColumn.HeaderText = "Opis Usterki";
            this.opisUsterkiDataGridViewTextBoxColumn.Name = "opisUsterkiDataGridViewTextBoxColumn";
            this.opisUsterkiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataZgloszeniaDataGridViewTextBoxColumn
            // 
            this.dataZgloszeniaDataGridViewTextBoxColumn.DataPropertyName = "DataZgloszenia";
            this.dataZgloszeniaDataGridViewTextBoxColumn.HeaderText = "Data Zgłoszenia";
            this.dataZgloszeniaDataGridViewTextBoxColumn.Name = "dataZgloszeniaDataGridViewTextBoxColumn";
            this.dataZgloszeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusZgloszeniaDataGridViewTextBoxColumn
            // 
            this.statusZgloszeniaDataGridViewTextBoxColumn.DataPropertyName = "StatusZgloszenia";
            this.statusZgloszeniaDataGridViewTextBoxColumn.HeaderText = "Status Zgłoszenia";
            this.statusZgloszeniaDataGridViewTextBoxColumn.Name = "statusZgloszeniaDataGridViewTextBoxColumn";
            this.statusZgloszeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planowanaDataRealizacjiDataGridViewTextBoxColumn
            // 
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "PlanowanaDataRealizacji";
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn.HeaderText = "Planowana Data Realizacji";
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn.Name = "planowanaDataRealizacjiDataGridViewTextBoxColumn";
            this.planowanaDataRealizacjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataRealizacjiDataGridViewTextBoxColumn
            // 
            this.dataRealizacjiDataGridViewTextBoxColumn.DataPropertyName = "DataRealizacji";
            this.dataRealizacjiDataGridViewTextBoxColumn.HeaderText = "Data Realizacji";
            this.dataRealizacjiDataGridViewTextBoxColumn.Name = "dataRealizacjiDataGridViewTextBoxColumn";
            this.dataRealizacjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ZgloszeniePrzegladaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ZgloszenieSerwisoweWyszukaj);
            this.Controls.Add(this.dgv_ZgloszenieSerwisoweWybierz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_drukuj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZgloszeniePrzegladaj";
            this.ShowInTaskbar = false;
            this.Text = "Zgłoszenia w bazie";
            this.Load += new System.EventHandler(this.ZgloszeniePrzegladaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZgloszenieSerwisoweWybierz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zgloszenieSerwisoweBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serwisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ZgloszenieSerwisoweWyszukaj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ZgloszenieSerwisoweWybierz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_drukuj;
        private SerwisDataSet serwisDataSet;
        private System.Windows.Forms.BindingSource zgloszenieSerwisoweBindingSource;
        private SerwisDataSetTableAdapters.ZgloszenieSerwisoweTableAdapter zgloszenieSerwisoweTableAdapter;
        private System.Windows.Forms.DataGridView dgv_ZgloszenieSerwisoweWyszukaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_modyfikuj;
        private System.Windows.Forms.ComboBox cb_StatusZgloszenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaFirmyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaUrzadzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrSeryjnyUrzadzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisUsterkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZgloszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusZgloszeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planowanaDataRealizacjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRealizacjiDataGridViewTextBoxColumn;
    }
}