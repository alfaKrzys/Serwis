using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Serwis
{
    public partial class Ustawienia : Form
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void b_Testuj_Click(object sender, EventArgs e)
        {
            SqlConnection cs = new SqlConnection("Data Source = " + tb_host.Text + "; Initial Catalog = " + tb_nazwaBazy.Text + "; User Id = " + tb_login.Text + "; Password = " + tb_haslo.Text + ";");
            try
            {
                cs.Open();
                MessageBox.Show("Status połączenia: " + cs.State.ToString(), "Test połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cs.Close();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Test połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            Properties.Settings settings = new Properties.Settings();
            tb_host.Text = settings.Host;
            tb_nazwaBazy.Text = settings.NazwaBazy;
            tb_login.Text = settings.Login;
            tb_haslo.Text = settings.Haslo;
        }

        private void b_Zapisz_Click(object sender, EventArgs e)
        {
            Properties.Settings settings = new Properties.Settings();
            settings.Haslo = tb_haslo.Text;
            settings.Host = tb_host.Text;
            settings.Login = tb_login.Text;
            settings.NazwaBazy = tb_nazwaBazy.Text;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = tb_host.Text;
            builder.InitialCatalog = tb_nazwaBazy.Text;
            builder.PersistSecurityInfo = true;
            builder.UserID = tb_login.Text;
            builder.Password = tb_haslo.Text;
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Serwis.Properties.Settings.SerwisConnectionString"].ConnectionString = builder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified, true);
            Properties.Settings.Default["SerwisConnectionString"] = builder.ConnectionString;

            settings.Save();
            this.Close();
        }

        private void Ustawienia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }

        private void tb_host_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                b_Zapisz_Click(sender, e);
        }
    }
}
