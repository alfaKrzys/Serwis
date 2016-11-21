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
    public partial class KlientWybierz : Form
    {
        private Wyszukaj wyszukaj;
        private f_serwisOknoGlowne f_serwisOknoGlowne;

        public KlientWybierz()
        {
            InitializeComponent();
        }

        public KlientWybierz(f_serwisOknoGlowne f_serwisOknoGlowne)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.f_serwisOknoGlowne = f_serwisOknoGlowne;
            wyszukaj = new Wyszukaj(serwisDataSet.Klient, dgv_klientWyszukaj, klientBindingSource);
        }

        private void KlientWybierz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serwisDataSet.Klient' table. You can move, or remove it, as needed.
            try
            {
                this.klientTableAdapter.Fill(this.serwisDataSet.Klient);
                wyszukaj.DodajKolumny(dgv_klientWybierz, dgv_klientWyszukaj);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Sprawdź poprawność ustawień połączenia z bazą.\n" + err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dgv_klientWyszukaj_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            wyszukaj.Filtruj((DataGridView)sender, klientBindingSource);
        }

        private void b_wybierz_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(f_serwisOknoGlowne.indexKlient) || f_serwisOknoGlowne.indexKlient != dgv_klientWybierz[0, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString())
            {
                f_serwisOknoGlowne.indexKlient = dgv_klientWybierz[0, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
                f_serwisOknoGlowne.b_drukuj.Enabled = false;
            }
            if (dgv_klientWybierz[0, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.b_wybierzKlient.Tag = dgv_klientWybierz[0, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[1, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_nazwisko.Text = dgv_klientWybierz[1, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[2, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_imie.Text = dgv_klientWybierz[2, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[3, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_ulica.Text = dgv_klientWybierz[3, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[4, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_nrDomu.Text = dgv_klientWybierz[4, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[5, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_nrMieszkania.Text = dgv_klientWybierz[5, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[6, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_miasto.Text = dgv_klientWybierz[6, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[7, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_kodPocztowy.Text = dgv_klientWybierz[7, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[8, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_adresEmail.Text = dgv_klientWybierz[8, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            if (dgv_klientWybierz[9, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString() != null)
                f_serwisOknoGlowne.tb_telefon.Text = dgv_klientWybierz[9, dgv_klientWybierz.CurrentCell.RowIndex].Value.ToString();
            this.Close();
        }
    }
}
