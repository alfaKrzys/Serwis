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
    public partial class SerwisDodaj : Form
    {
        private SqlConnection sc = new SqlConnection(Properties.Settings.Default["SerwisConnectionString"].ToString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        public SerwisDodaj()
        {
            InitializeComponent();
        }

        private void SerwisDodaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serwisDataSet1.PunktSerwisowy' table. You can move, or remove it, as needed.
            try
            {
                this.punktSerwisowyTableAdapter.Fill(this.serwisDataSet.PunktSerwisowy);
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
            Match test = reg.Match(tb_KodPocztowy.Text);
            Regex regEMail = new Regex(@"[a-z0-9_.-]+@[a-z0-9_.-]+\.\w{2,4}");
            Match test2 = regEMail.Match(tb_AdresEMail.Text);

            if (String.IsNullOrWhiteSpace(tb_NazwaFirmy.Text) || String.IsNullOrWhiteSpace(tb_Ulica.Text) || String.IsNullOrWhiteSpace(tb_NrDomu.Text) || String.IsNullOrWhiteSpace(tb_Miasto.Text) || String.IsNullOrWhiteSpace(tb_KodPocztowy.Text))
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
                da.InsertCommand = new SqlCommand("INSERT INTO PunktSerwisowy (NazwaFirmy, NazwiskoOsobyDoKontaktu, ImieOsobyDoKontaktu, Ulica, NrDomu, NrMieszkania, Miasto, KodPocztowy, AdresEMail, Telefon) VALUES (@NazwaFirmy, @NazwiskoOsobyDoKontaktu, @ImieOsobyDoKontaktu, @Ulica, @NrDomu, @NrMieszkania, @Miasto, @KodPocztowy, @AdresEMail, @Telefon)", sc);
                da.InsertCommand.Parameters.Add("@NazwaFirmy", SqlDbType.VarChar).Value = tb_NazwaFirmy.Text;
                da.InsertCommand.Parameters.Add("@NazwiskoOsobyDoKontaktu", SqlDbType.VarChar).Value = tb_NazwiskoOsobyDoKontaktu.Text;
                da.InsertCommand.Parameters.Add("@ImieOsobyDoKontaktu", SqlDbType.VarChar).Value = tb_ImieOsobyDoKontaktu.Text;
                da.InsertCommand.Parameters.Add("@Ulica", SqlDbType.VarChar).Value = tb_Ulica.Text;
                da.InsertCommand.Parameters.Add("@NrDomu", SqlDbType.VarChar).Value = tb_NrDomu.Text;
                da.InsertCommand.Parameters.Add("@NrMieszkania", SqlDbType.VarChar).Value = tb_NrMieszkania.Text;
                da.InsertCommand.Parameters.Add("@Miasto", SqlDbType.VarChar).Value = tb_Miasto.Text;
                da.InsertCommand.Parameters.Add("@KodPocztowy", SqlDbType.Char).Value = tb_KodPocztowy.Text;
                da.InsertCommand.Parameters.Add("@AdresEMail", SqlDbType.VarChar).Value = tb_AdresEMail.Text;
                da.InsertCommand.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = tb_Telefon.Text;

                sc.Open();
                da.InsertCommand.ExecuteNonQuery();
                sc.Close();
                this.punktSerwisowyTableAdapter.Fill(this.serwisDataSet.PunktSerwisowy);
                tb_AdresEMail.Clear();
                tb_ImieOsobyDoKontaktu.Clear();
                tb_KodPocztowy.Clear();
                tb_Miasto.Clear();
                tb_NazwaFirmy.Clear();
                tb_NazwiskoOsobyDoKontaktu.Clear();
                tb_NrDomu.Clear();
                tb_NrMieszkania.Clear();
                tb_Telefon.Clear();
                tb_Ulica.Clear();
            }
        }
    }
}
