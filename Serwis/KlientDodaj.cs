using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Serwis
{
    public partial class KlientDodaj : Form
    {
        private SqlConnection sc = new SqlConnection(Properties.Settings.Default["SerwisConnectionString1"].ToString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        public KlientDodaj()
        {
            InitializeComponent();
        }

        private void KlientDodaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serwisDataSet.Klient' table. You can move, or remove it, as needed.
            try
            {
                this.klientTableAdapter.Fill(this.serwisDataSet.Klient);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Sprawdź poprawność ustawień połączenia z bazą \n" + err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"[0-9]{2}-[0-9]{3}");
            Match test = reg.Match(tb_kodPocztowy.Text);
            Regex regEMail = new Regex(@"[a-z0-9_.-]+@[a-z0-9_.-]+\.\w{2,4}");
            Match test2 = regEMail.Match(tb_adresEmail.Text);

            if (String.IsNullOrWhiteSpace(tb_nazwisko.Text) || String.IsNullOrWhiteSpace(tb_ulica.Text) || String.IsNullOrWhiteSpace(tb_nrDomu.Text) || String.IsNullOrWhiteSpace(tb_miasto.Text) || String.IsNullOrWhiteSpace(tb_kodPocztowy.Text))
            {
                MessageBox.Show("Pola oznaczone * muszą zostać wypełnione", "Uzupełnij pola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (!test.Success)
            {
                MessageBox.Show("Kod pocztowy musi mieć postać xx-xxx", "Błąd kodu pocztowego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!test2.Success)
            {
                MessageBox.Show("Błędny adres e-mail", "Błąd adresu mailowego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                da.InsertCommand = new SqlCommand("INSERT INTO Klient (Nazwisko, Imie, Ulica, NrDomu, NrMieszkania, Miasto, KodPocztowy, AdresEMail, Telefon) VALUES (@Nazwisko, @Imie, @Ulica, @NrDomu, @NrMieszkania, @Miasto, @KodPocztowy, @AdresEMail, @Telefon)", sc);
                da.InsertCommand.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = tb_nazwisko.Text;
                da.InsertCommand.Parameters.Add("@Imie", SqlDbType.VarChar).Value = tb_imie.Text;
                da.InsertCommand.Parameters.Add("@Ulica", SqlDbType.VarChar).Value = tb_ulica.Text;
                da.InsertCommand.Parameters.Add("@NrDomu", SqlDbType.VarChar).Value = tb_nrDomu.Text;
                da.InsertCommand.Parameters.Add("@NrMieszkania", SqlDbType.VarChar).Value = tb_nrMieszkania.Text;
                da.InsertCommand.Parameters.Add("@Miasto", SqlDbType.VarChar).Value = tb_miasto.Text;
                da.InsertCommand.Parameters.Add("@KodPocztowy", SqlDbType.Char).Value = tb_kodPocztowy.Text;
                da.InsertCommand.Parameters.Add("@AdresEMail", SqlDbType.VarChar).Value = tb_adresEmail.Text;
                da.InsertCommand.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = tb_telefon.Text;

                sc.Open();
                da.InsertCommand.ExecuteNonQuery();
                sc.Close();
                this.klientTableAdapter.Fill(this.serwisDataSet.Klient);
                tb_adresEmail.Clear();
                tb_imie.Clear();
                tb_kodPocztowy.Clear();
                tb_miasto.Clear();
                tb_nazwisko.Clear();
                tb_nrDomu.Clear();
                tb_nrMieszkania.Clear();
                tb_telefon.Clear();
                tb_ulica.Clear();
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            da.SelectCommand = new SqlCommand("SELECT DISTINCT " + textbox.Name.Substring(3) + " FROM Klient WHERE " + textbox.Name.Substring(3) + " LIKE \'" + textbox.Text + "%\'", sc);
            ds.Clear();
            sc.Open();
            da.SelectCommand.ExecuteNonQuery();
            sc.Close();
            da.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        if (!textbox.AutoCompleteCustomSource.Contains(row[column].ToString()))
                            textbox.AutoCompleteCustomSource.Add(row[column].ToString());
                    }
                }
            }
        }
    }
}
