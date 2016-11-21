using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Serwis
{
    public partial class SerwisWybierz : Form
    {
        private f_serwisOknoGlowne f_serwisOknoGlowne;
        private Wyszukaj wyszukaj;

        public SerwisWybierz()
        {
            InitializeComponent();
        }

        public SerwisWybierz(f_serwisOknoGlowne f_serwisOknoGlowne)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.f_serwisOknoGlowne = f_serwisOknoGlowne;
            wyszukaj = new Wyszukaj(serwisDataSet.PunktSerwisowy, dgv_serwisWyszukaj, punktSerwisowyBindingSource);
        }

        private void SerwisWybierz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serwisDataSet1.PunktSerwisowy' table. You can move, or remove it, as needed.
            try
            {
                this.punktSerwisowyTableAdapter.Fill(this.serwisDataSet.PunktSerwisowy);
                wyszukaj.DodajKolumny(dgv_serwisWybierz, dgv_serwisWyszukaj);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Sprawdź poprawność ustawień połączenia z bazą \n" + err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dgv_serwisWyszukaj_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            wyszukaj.Filtruj((DataGridView)sender, punktSerwisowyBindingSource);
        }

        private void b_wybierz_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(f_serwisOknoGlowne.indexSerwis) || f_serwisOknoGlowne.indexSerwis != dgv_serwisWybierz[0, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString())
            {
                f_serwisOknoGlowne.indexSerwis = dgv_serwisWybierz[0, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
                f_serwisOknoGlowne.b_drukuj.Enabled = false;
            }

            if (dgv_serwisWybierz[0, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.b_wybierzSerwis.Tag = dgv_serwisWybierz[0, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[1, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_NazwaFirmy.Text = dgv_serwisWybierz[1, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[2, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_NazwiskoOsobyDoKontaktu.Text = dgv_serwisWybierz[2, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[3, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_ImieOsobyDoKontaktu.Text = dgv_serwisWybierz[3, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[4, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_UlicaS.Text = dgv_serwisWybierz[4, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[5, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_NrDomuS.Text = dgv_serwisWybierz[5, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[6, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_NrMieszkaniaS.Text = dgv_serwisWybierz[6, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[7, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_MiastoS.Text = dgv_serwisWybierz[7, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[8, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_KodPocztowyS.Text = dgv_serwisWybierz[8, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[9, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_AdresEMailS.Text = dgv_serwisWybierz[9, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_serwisWybierz[10, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_TelefonS.Text = dgv_serwisWybierz[10, dgv_serwisWybierz.CurrentCell.RowIndex].Value.ToString();

            this.Close();
        }
    }
}
