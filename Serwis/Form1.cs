using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;

namespace Serwis
{
    public partial class f_serwisOknoGlowne : Form
    {
        private Ustawienia ustawienia;
        private KlientDodaj klientdodaj;
        private SerwisDodaj seriwsdodaj;
        private KlientWybierz klientwybierz;
        private SerwisWybierz serwiswybierz;
        private SqlConnection sc = new SqlConnection(Properties.Settings.Default["SerwisConnectionString"].ToString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private string nrZgloszenia;
        private TextBox[] TABKlientTB, TABSerwisTB;
        private Label[] TABKlientL, TABSerwisL;
        internal static string indexKlient, indexSerwis;
        private ZgloszeniePrzegladaj zgloszenieprzegladaj;
        public static string[] Statusy = { "Zrealizowane", "Wysłane do serwisu", "Oczekuje" };

        public f_serwisOknoGlowne()
        {
            InitializeComponent();
            TABKlientTB = new TextBox[] { tb_nazwisko, tb_imie, tb_nrDomu, tb_nrMieszkania, tb_ulica, tb_kodPocztowy, tb_miasto, tb_adresEmail, tb_telefon };
            TABKlientL = new Label[] { l_nazwisko, l_imie, l_nrDomu, l_nrMieszkania, l_ulica, l_kodPocztowy, l_miasto, l_adresEmail, l_telefon };
            TABSerwisTB = new TextBox[] { tb_NazwaFirmy, tb_NazwiskoOsobyDoKontaktu, tb_ImieOsobyDoKontaktu, tb_AdresEMailS, tb_TelefonS, tb_NrDomuS, tb_NrMieszkaniaS, tb_UlicaS, tb_KodPocztowyS, tb_MiastoS };
            TABSerwisL = new Label[] { l_NazwaFirmy, l_NazwiskoOsobyDoKontaktu, l_ImieOsobyDoKontaktu, l_AdresEMailS, l_TelefonS, l_NrDomuS, l_NrMieszkaniaS, l_UlicaS, l_KodPocztowyS, l_MiastoS };
            cb_StatusZgloszenia.Items.AddRange(Statusy);
            LadujUstawienia();
        }

        private void LadujUstawienia()
        {
            Properties.Settings settings = new Properties.Settings();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = settings.Host;
            builder.InitialCatalog = settings.NazwaBazy;
            builder.PersistSecurityInfo = true;
            builder.UserID = settings.Login;
            builder.Password = settings.Haslo;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["Serwis.Properties.Settings.SerwisConnectionString"].ConnectionString = builder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified, true);
            Properties.Settings.Default["SerwisConnectionString"] = builder.ConnectionString;
            settings.Save();
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ustawienia == null)
            {
                ustawienia = new Ustawienia();
                ustawienia.Owner = this;
                ustawienia.FormClosed += (s, ee) => { ustawienia = null; };
                ustawienia.Show();
            }
            else
            {
                ustawienia.Activate();
                ustawienia.WindowState = FormWindowState.Normal;
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (klientdodaj == null)
            {
                klientdodaj = new KlientDodaj();
                klientdodaj.Owner = this;
                klientdodaj.FormClosed += (s, ee) => { klientdodaj = null; };
                klientdodaj.Show();
            }
            else
            {
                klientdodaj.Activate();
                klientdodaj.WindowState = FormWindowState.Normal;
            }
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seriwsdodaj == null)
            {
                seriwsdodaj = new SerwisDodaj();
                seriwsdodaj.Owner = this;
                seriwsdodaj.FormClosed += (s, ee) => { seriwsdodaj = null; };
                seriwsdodaj.Show();
            }
            else
            {
                seriwsdodaj.Activate();
                seriwsdodaj.WindowState = FormWindowState.Normal;
            }
        }

        private void tsb_dodajKlienta_Click(object sender, EventArgs e)
        {
            dodajToolStripMenuItem_Click(sender, e);
        }

        private void tsb_dodajSerwis_Click(object sender, EventArgs e)
        {
            dodajToolStripMenuItem1_Click(sender, e);
        }

        private void b_wybierzKlient_Click(object sender, EventArgs e)
        {
            if (klientwybierz == null)
            {
                klientwybierz = new KlientWybierz(this);
                klientwybierz.Owner = this;
                klientwybierz.FormClosed += (s, ee) => { klientwybierz = null; };
                klientwybierz.Show();
            }
            else
            {
                klientwybierz.Activate();
                klientwybierz.WindowState = FormWindowState.Normal;
            }
        }

        private void b_wybierzSerwis_Click(object sender, EventArgs e)
        {
            if (serwiswybierz == null)
            {
                serwiswybierz = new SerwisWybierz(this);
                serwiswybierz.Owner = this;
                serwiswybierz.FormClosed += (s, ee) => { serwiswybierz = null; };
                serwiswybierz.Show();
            }
            else
            {
                serwiswybierz.Activate();
                serwiswybierz.WindowState = FormWindowState.Normal;
            }

        }

        private void b_dodajDoBazy_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int i = dtp_PlanowanaDataRealizacji.Value.CompareTo(dtp_DataZgloszenia.Value);
            int j = dtp_DataRealizacji.Value.CompareTo(dtp_DataZgloszenia.Value);
            if (String.IsNullOrWhiteSpace(tb_NazwaUrzadzenia.Text) || String.IsNullOrWhiteSpace(tb_NrSeryjnyUrzadzenia.Text) || String.IsNullOrWhiteSpace(tb_OpisUsterki.Text) || String.IsNullOrWhiteSpace(cb_StatusZgloszenia.Text) || b_wybierzKlient.Tag == null || b_wybierzSerwis.Tag == null)
            {
                MessageBox.Show("Pola oznaczone * muszą zostać wypełnione", "Uzupełnij pola", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (dtp_PlanowanaDataRealizacji.Value.Date.CompareTo(dtp_DataZgloszenia.Value.Date) < 0 || dtp_DataRealizacji.Value.Date.CompareTo(dtp_DataZgloszenia.Value.Date) < 0)
                MessageBox.Show("Planowana data realizacji i data realizacji muszą być późniejsze niż data zgłoszenia", "Błąd daty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else //if (valueChange)
            {
                da.SelectCommand = new SqlCommand("SELECT ID FROM dbo.ZgloszenieSerwisowe WHERE IDKlient = @IDKlient AND IDPunktSerwisowy = @IDPunktSerwisowy AND NazwaUrzadzenia = @NazwaUrzadzenia AND NrSeryjnyUrzadzenia = @NrSeryjnyUrzadzenia AND OpisUsterki = @OpisUsterki AND DataZgloszenia = @DataZgloszenia AND StatusZgloszenia = @StatusZgloszenia AND PlanowanaDataRealizacji = @PlanowanaDataRealizacji AND DataRealizacji = @DataRealizacji", sc);
                da.SelectCommand.Parameters.Add("@IDKlient", SqlDbType.Int).Value = b_wybierzKlient.Tag.ToString();
                da.SelectCommand.Parameters.Add("@IDPunktSerwisowy", SqlDbType.Int).Value = b_wybierzSerwis.Tag.ToString();
                da.SelectCommand.Parameters.Add("@NazwaUrzadzenia", SqlDbType.VarChar).Value = tb_NazwaUrzadzenia.Text;
                da.SelectCommand.Parameters.Add("@NrSeryjnyUrzadzenia", SqlDbType.VarChar).Value = tb_NrSeryjnyUrzadzenia.Text;
                da.SelectCommand.Parameters.Add("@OpisUsterki", SqlDbType.VarChar).Value = tb_OpisUsterki.Text;
                da.SelectCommand.Parameters.Add("@DataZgloszenia", SqlDbType.Date).Value = dtp_DataZgloszenia.Value;
                da.SelectCommand.Parameters.Add("@StatusZgloszenia", SqlDbType.VarChar).Value = cb_StatusZgloszenia.Text;
                da.SelectCommand.Parameters.Add("@PlanowanaDataRealizacji", SqlDbType.Date).Value = dtp_PlanowanaDataRealizacji.Value;
                da.SelectCommand.Parameters.Add("@DataRealizacji", SqlDbType.Date).Value = dtp_DataRealizacji.Value;
                int id;
                try
                {
                    if(sc.State!=ConnectionState.Open)
                    sc.Open();
                    id = (int)da.SelectCommand.ExecuteScalar();
                    sc.Close();
                }

                catch (SqlException err)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (NullReferenceException)
                {

                    da.InsertCommand = new SqlCommand("INSERT INTO ZgloszenieSerwisowe (IDKlient, IDPunktSerwisowy, NazwaUrzadzenia, NrSeryjnyUrzadzenia, OpisUsterki, DataZgloszenia, StatusZgloszenia, PlanowanaDataRealizacji, DataRealizacji) VALUES (@IDKlient, @IDPunktSerwisowy, @NazwaUrzadzenia, @NrSeryjnyUrzadzenia, @OpisUsterki, @DataZgloszenia, @StatusZgloszenia, @PlanowanaDataRealizacji, @DataRealizacji)", sc);
                    da.InsertCommand.Parameters.Add("@IDKlient", SqlDbType.Int).Value = b_wybierzKlient.Tag.ToString();
                    da.InsertCommand.Parameters.Add("@IDPunktSerwisowy", SqlDbType.Int).Value = b_wybierzSerwis.Tag.ToString();
                    da.InsertCommand.Parameters.Add("@NazwaUrzadzenia", SqlDbType.VarChar).Value = tb_NazwaUrzadzenia.Text;
                    da.InsertCommand.Parameters.Add("@NrSeryjnyUrzadzenia", SqlDbType.VarChar).Value = tb_NrSeryjnyUrzadzenia.Text;
                    da.InsertCommand.Parameters.Add("@OpisUsterki", SqlDbType.VarChar).Value = tb_OpisUsterki.Text;
                    da.InsertCommand.Parameters.Add("@DataZgloszenia", SqlDbType.Date).Value = dtp_DataZgloszenia.Value;
                    da.InsertCommand.Parameters.Add("@StatusZgloszenia", SqlDbType.VarChar).Value = cb_StatusZgloszenia.Text;
                    da.InsertCommand.Parameters.Add("@PlanowanaDataRealizacji", SqlDbType.Date).Value = dtp_PlanowanaDataRealizacji.Value;
                    da.InsertCommand.Parameters.Add("@DataRealizacji", SqlDbType.Date).Value = dtp_DataRealizacji.Value;
                    da.SelectCommand = new SqlCommand("SELECT MAX(ID) FROM dbo.ZgloszenieSerwisowe", sc);

                    if (sc.State != ConnectionState.Open)
                        sc.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    object idMAX = da.SelectCommand.ExecuteScalar();
                    sc.Close();
                    nrZgloszenia = Convert.ToString(idMAX);
                    tssl_dodanoDoBazy.Text = "Pomyślnie dodano rekord do bazy";
                    t_statusStrip.Enabled = true;
                    b_drukuj.Enabled = true;
                    Cursor.Current = Cursors.Default;
                }

            }
        }

        private void t_statusStrip_Tick(object sender, EventArgs e)
        {
            tssl_dodanoDoBazy.Text = "";
            t_statusStrip.Enabled = false;
        }

        private void b_drukuj_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

            //Insert a paragraph at the beginning of the document.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "Raport dla zgłoszenia serwisowego nr: " + nrZgloszenia;
            oPara1.Range.Font.Bold = 1;
            oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();
            oPara1.LineSpacing = 10.0f;

            //Insert a 3 x 5 table, fill it with data, and make the first row
            //bold and italic.

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 12, 5, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 0;
            oTable.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oTable.AllowAutoFit = true;
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            oTable.BottomPadding = 0.0f;
            oTable.TopPadding = 0.0f;
            //oTable
            oTable.Borders.Enable = 2;
            oTable.Columns[3].Borders[Word.WdBorderType.wdBorderTop].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Columns[3].Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Columns[3].Borders[Word.WdBorderType.wdBorderHorizontal].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[1].Borders[Word.WdBorderType.wdBorderTop].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[1].Borders[Word.WdBorderType.wdBorderVertical].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[1].Borders[Word.WdBorderType.wdBorderLeft].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[1].Borders[Word.WdBorderType.wdBorderRight].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[2].Borders[Word.WdBorderType.wdBorderVertical].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[2].Borders[Word.WdBorderType.wdBorderLeft].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Rows[2].Borders[Word.WdBorderType.wdBorderRight].LineStyle = Word.WdLineStyle.wdLineStyleNone;


            for (int i = 1; i <= oTable.Rows.Count; i = i + 2)
            {
                oTable.Rows[i].Range.Bold = 0;
                oTable.Rows[i].Range.Italic = 0;
                oTable.Rows[i].Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            }

            oTable.Cell(1, 1).Range.Text = "Zgłaszający:";
            oTable.Cell(3, 1).Range.Text = l_nazwisko.Text;
            oTable.Cell(4, 1).Range.Text = tb_nazwisko.Text;
            oTable.Cell(5, 1).Range.Text = l_imie.Text;
            oTable.Cell(6, 1).Range.Text = tb_imie.Text;
            oTable.Cell(7, 1).Range.Text = l_nrDomu.Text;
            oTable.Cell(8, 1).Range.Text = tb_nrDomu.Text;
            oTable.Cell(9, 1).Range.Text = l_nrMieszkania.Text;
            oTable.Cell(10, 1).Range.Text = tb_nrMieszkania.Text;
            oTable.Cell(11, 1).Range.Text = l_ulica.Text;
            oTable.Cell(12, 1).Range.Text = tb_ulica.Text;
            oTable.Cell(3, 2).Range.Text = l_kodPocztowy.Text;
            oTable.Cell(4, 2).Range.Text = tb_kodPocztowy.Text;
            oTable.Cell(5, 2).Range.Text = l_miasto.Text;
            oTable.Cell(6, 2).Range.Text = tb_miasto.Text;
            oTable.Cell(7, 2).Range.Text = l_adresEmail.Text;
            oTable.Cell(8, 2).Range.Text = tb_adresEmail.Text;
            oTable.Cell(9, 2).Range.Text = l_telefon.Text;
            oTable.Cell(10, 2).Range.Text = tb_telefon.Text;

            oTable.Cell(1, 4).Range.Text = "Serwis:";
            oTable.Cell(3, 4).Range.Text = l_NazwaFirmy.Text;
            oTable.Cell(4, 4).Range.Text = tb_NazwaFirmy.Text;
            oTable.Cell(5, 4).Range.Text = l_NazwiskoOsobyDoKontaktu.Text;
            oTable.Cell(6, 4).Range.Text = tb_NazwiskoOsobyDoKontaktu.Text;
            oTable.Cell(7, 4).Range.Text = l_ImieOsobyDoKontaktu.Text;
            oTable.Cell(8, 4).Range.Text = tb_ImieOsobyDoKontaktu.Text;
            oTable.Cell(9, 4).Range.Text = l_AdresEMailS.Text;
            oTable.Cell(10, 4).Range.Text = tb_AdresEMailS.Text;
            oTable.Cell(11, 4).Range.Text = l_TelefonS.Text;
            oTable.Cell(12, 4).Range.Text = tb_TelefonS.Text;
            oTable.Cell(3, 5).Range.Text = l_NrDomuS.Text;
            oTable.Cell(4, 5).Range.Text = tb_NrDomuS.Text;
            oTable.Cell(5, 5).Range.Text = l_NrMieszkaniaS.Text;
            oTable.Cell(6, 5).Range.Text = tb_NrMieszkaniaS.Text;
            oTable.Cell(7, 5).Range.Text = l_UlicaS.Text;
            oTable.Cell(8, 5).Range.Text = tb_UlicaS.Text;
            oTable.Cell(9, 5).Range.Text = l_KodPocztowyS.Text;
            oTable.Cell(10, 5).Range.Text = tb_KodPocztowyS.Text;
            oTable.Cell(11, 5).Range.Text = l_MiastoS.Text;
            oTable.Cell(12, 5).Range.Text = tb_MiastoS.Text;

            Word.Paragraph oPara4;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara4.Range.InsertParagraphBefore();
            oPara4.Format.SpaceAfter = 24;
            oPara4.Range.Text = "Opis zgłoszenia serwisowego:";
            oPara4.Range.InsertParagraphAfter();

            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 6, 3, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 0;
            oTable.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oTable.AllowAutoFit = true;
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            oTable.BottomPadding = 0.0f;
            oTable.TopPadding = 0.0f;
            oTable.Borders.Enable = 1;

            for (int i = 1; i <= oTable.Rows.Count; i = i + 2)
            {
                oTable.Rows[i].Range.Bold = 0;
                oTable.Rows[i].Range.Italic = 0;
                oTable.Rows[i].Borders[Word.WdBorderType.wdBorderBottom].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            }

            oTable.Cell(1, 1).Range.Text = l_NazwaUrzadzenia.Text.Replace('*', ' ');
            oTable.Cell(2, 1).Range.Text = tb_NazwaUrzadzenia.Text;
            oTable.Cell(1, 2).Range.Text = l_NumerSeryjny.Text.Replace('*', ' ');
            oTable.Cell(2, 2).Range.Text = tb_NrSeryjnyUrzadzenia.Text;
            oTable.Cell(1, 3).Range.Text = l_StatusZgloszenia.Text.Replace('*', ' ');
            oTable.Cell(2, 3).Range.Text = cb_StatusZgloszenia.Text;
            oTable.Cell(3, 1).Range.Text = l_OpisUsterki.Text.Replace('*', ' ');
            oTable.Cell(3, 2).Borders[Word.WdBorderType.wdBorderLeft].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Cell(3, 2).Borders[Word.WdBorderType.wdBorderRight].LineStyle = Word.WdLineStyle.wdLineStyleNone;
            oTable.Cell(4, 1).Merge(oTable.Cell(4, 2));
            oTable.Cell(4, 1).Merge(oTable.Cell(4, 2));
            oTable.Cell(4, 1).Range.Text = tb_OpisUsterki.Text;
            oTable.Cell(5, 1).Range.Text = l_DataZgloszenia.Text.Replace('*', ' ');
            oTable.Cell(6, 1).Range.Text = dtp_DataZgloszenia.Text;
            oTable.Cell(5, 2).Range.Text = l_PlanowanaDataRealizacji.Text.Replace('*', ' ');
            oTable.Cell(6, 2).Range.Text = dtp_PlanowanaDataRealizacji.Text;
            oTable.Cell(5, 3).Range.Text = l_DataRealizacji.Text.Replace('*', ' ');
            oTable.Cell(6, 3).Range.Text = dtp_DataRealizacji.Text;
        }

        private void b_czysc_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in TABKlientTB)
            {
                tb.Clear();
            }
            foreach (TextBox tb in TABSerwisTB)
            {
                tb.Clear();
            }
            tb_NazwaUrzadzenia.Clear();
            tb_NrSeryjnyUrzadzenia.Clear();
            tb_OpisUsterki.Clear();
            dtp_DataRealizacji.ResetText();
            dtp_DataZgloszenia.ResetText();
            dtp_PlanowanaDataRealizacji.ResetText();
            cb_StatusZgloszenia.ResetText();
            b_drukuj.Enabled = false;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            b_drukuj.Enabled = false;
        }

        private void przeglądajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zgloszenieprzegladaj == null)
            {
                zgloszenieprzegladaj = new ZgloszeniePrzegladaj();
                zgloszenieprzegladaj.Owner = this;
                zgloszenieprzegladaj.FormClosed += (s, ee) => { zgloszenieprzegladaj = null; };
                zgloszenieprzegladaj.Show();
            }
            else
            {
                zgloszenieprzegladaj.Activate();
                zgloszenieprzegladaj.WindowState = FormWindowState.Normal;
            }

        }
    }        
}
