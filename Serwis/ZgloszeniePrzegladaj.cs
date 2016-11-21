using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;

namespace Serwis
{
    public partial class ZgloszeniePrzegladaj : Form
    {
        private Wyszukaj wyszukaj;
        private SqlConnection sc = new SqlConnection(Properties.Settings.Default["SerwisConnectionString"].ToString());
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet dsKlient = new DataSet();
        private DataSet dsSerwis = new DataSet();
        //private SqlCommand sql_cmd;
        //private SqlDataAdapter sql_adapter;
        //private SqlCommandBuilder cmd_builder;

        public ZgloszeniePrzegladaj()
        {
            InitializeComponent();
            wyszukaj = new Wyszukaj(serwisDataSet.ZgloszenieSerwisowe, dgv_ZgloszenieSerwisoweWyszukaj, zgloszenieSerwisoweBindingSource);
            cb_StatusZgloszenia.Items.AddRange(f_serwisOknoGlowne.Statusy);
        }

        private void ZgloszeniePrzegladaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serwisDataSet.ZgloszenieSerwisowe' table. You can move, or remove it, as needed.
            try
            {
                this.zgloszenieSerwisoweTableAdapter.Fill(this.serwisDataSet.ZgloszenieSerwisowe);
                wyszukaj.DodajKolumny(dgv_ZgloszenieSerwisoweWybierz, dgv_ZgloszenieSerwisoweWyszukaj);
            }
            catch (SqlException err)
            {
                MessageBox.Show("Sprawdź poprawność ustawień połączenia z bazą \n" + err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void dgv_ZgloszenieSerwisoweWyszukaj_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            wyszukaj.Filtruj((DataGridView)sender, zgloszenieSerwisoweBindingSource);
        }

        private void b_drukuj_Click(object sender, EventArgs e)
        {
            if (dgv_ZgloszenieSerwisoweWybierz.CurrentCell != null)
            {
                bool scOK = true;
                try
                {
                    da.SelectCommand = new SqlCommand("SELECT IDKlient FROM dbo.ZgloszenieSerwisowe WHERE ID = @ID", sc);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = dgv_ZgloszenieSerwisoweWybierz[0, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value;
                    Int32 idKlient;

                    sc.Open();
                    idKlient = (Int32)da.SelectCommand.ExecuteScalar();
                    sc.Close();


                    da.SelectCommand = new SqlCommand("SELECT IDPunktSerwisowy FROM dbo.ZgloszenieSerwisowe WHERE ID = @ID", sc);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = dgv_ZgloszenieSerwisoweWybierz[0, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value;
                    Int32 idSerwis;
                    sc.Open();
                    idSerwis = (Int32)da.SelectCommand.ExecuteScalar();
                    sc.Close();

                    da.SelectCommand = new SqlCommand("SELECT * FROM dbo.Klient WHERE ID = @IDKlient", sc);
                    da.SelectCommand.Parameters.Add("@IDKlient", SqlDbType.Int).Value = idKlient;
                    sc.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    sc.Close();
                    da.Fill(dsKlient);

                    da.SelectCommand = new SqlCommand("SELECT * FROM dbo.PunktSerwisowy WHERE ID = @IDPunktSerwisowy", sc);
                    da.SelectCommand.Parameters.Add("@IDPunktSerwisowy", SqlDbType.Int).Value = idSerwis;
                    sc.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    sc.Close();
                    da.Fill(dsSerwis);
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    scOK = false;
                }

                if (scOK)
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
                    oPara1.Range.Text = "Raport dla zgłoszenia serwisowego nr: " + dgv_ZgloszenieSerwisoweWybierz[0, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oPara1.Range.Font.Bold = 1;
                    oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                    oPara1.Range.InsertParagraphAfter();
                    oPara1.LineSpacing = 10.0f;

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
                    oTable.Cell(3, 1).Range.Text = "Nazwisko";
                    oTable.Cell(4, 1).Range.Text = dgv_ZgloszenieSerwisoweWybierz[1, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(5, 1).Range.Text = "Imię";
                    oTable.Cell(6, 1).Range.Text = dgv_ZgloszenieSerwisoweWybierz[2, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(7, 1).Range.Text = "Nr domu";
                    oTable.Cell(8, 1).Range.Text = dsKlient.Tables[0].Rows[0][4].ToString();
                    oTable.Cell(9, 1).Range.Text = "Nr mieszkania";
                    oTable.Cell(10, 1).Range.Text = dsKlient.Tables[0].Rows[0][5].ToString();
                    oTable.Cell(11, 1).Range.Text = "Ulica";
                    oTable.Cell(12, 1).Range.Text = dsKlient.Tables[0].Rows[0][3].ToString();
                    oTable.Cell(3, 2).Range.Text = "Kod pocztowy";
                    oTable.Cell(4, 2).Range.Text = dsKlient.Tables[0].Rows[0][7].ToString();
                    oTable.Cell(5, 2).Range.Text = "Miasto";
                    oTable.Cell(6, 2).Range.Text = dsKlient.Tables[0].Rows[0][6].ToString();
                    oTable.Cell(7, 2).Range.Text = "Adres e-mail";
                    oTable.Cell(8, 2).Range.Text = dsKlient.Tables[0].Rows[0][8].ToString();
                    oTable.Cell(9, 2).Range.Text = "Telefon";
                    oTable.Cell(10, 2).Range.Text = dsKlient.Tables[0].Rows[0][9].ToString();

                    oTable.Cell(1, 4).Range.Text = "Serwis:";
                    oTable.Cell(3, 4).Range.Text = "Nazwa firmy";
                    oTable.Cell(4, 4).Range.Text = dgv_ZgloszenieSerwisoweWybierz[3, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(5, 4).Range.Text = "Nazwisko";
                    oTable.Cell(6, 4).Range.Text = dsSerwis.Tables[0].Rows[0][2].ToString();
                    oTable.Cell(7, 4).Range.Text = "Imię";
                    oTable.Cell(8, 4).Range.Text = dsSerwis.Tables[0].Rows[0][3].ToString();
                    oTable.Cell(9, 4).Range.Text = "Adres e-mail";
                    oTable.Cell(10, 4).Range.Text = dsSerwis.Tables[0].Rows[0][9].ToString();
                    oTable.Cell(11, 4).Range.Text = "Telefon";
                    oTable.Cell(12, 4).Range.Text = dsSerwis.Tables[0].Rows[0][10].ToString();
                    oTable.Cell(3, 5).Range.Text = "Nr domu";
                    oTable.Cell(4, 5).Range.Text = dsSerwis.Tables[0].Rows[0][5].ToString();
                    oTable.Cell(5, 5).Range.Text = "Nr mieszkania";
                    oTable.Cell(6, 5).Range.Text = dsSerwis.Tables[0].Rows[0][6].ToString();
                    oTable.Cell(7, 5).Range.Text = "Ulica";
                    oTable.Cell(8, 5).Range.Text = dsSerwis.Tables[0].Rows[0][4].ToString();
                    oTable.Cell(9, 5).Range.Text = "Kod pocztowy";
                    oTable.Cell(10, 5).Range.Text = dsSerwis.Tables[0].Rows[0][8].ToString();
                    oTable.Cell(11, 5).Range.Text = "Miasto";
                    oTable.Cell(12, 5).Range.Text = dsSerwis.Tables[0].Rows[0][7].ToString();

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

                    oTable.Cell(1, 1).Range.Text = "Nazwa urządzenia";
                    oTable.Cell(2, 1).Range.Text = dgv_ZgloszenieSerwisoweWybierz[4, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(1, 2).Range.Text = "Numer seryjny";
                    oTable.Cell(2, 2).Range.Text = dgv_ZgloszenieSerwisoweWybierz[5, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(1, 3).Range.Text = "Status zgłoszenia";
                    oTable.Cell(2, 3).Range.Text = dgv_ZgloszenieSerwisoweWybierz[8, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(3, 1).Range.Text = "Opis usterki";
                    oTable.Cell(3, 2).Borders[Word.WdBorderType.wdBorderLeft].LineStyle = Word.WdLineStyle.wdLineStyleNone;
                    oTable.Cell(3, 2).Borders[Word.WdBorderType.wdBorderRight].LineStyle = Word.WdLineStyle.wdLineStyleNone;
                    oTable.Cell(4, 1).Merge(oTable.Cell(4, 2));
                    oTable.Cell(4, 1).Merge(oTable.Cell(4, 2));
                    oTable.Cell(4, 1).Range.Text = dgv_ZgloszenieSerwisoweWybierz[6, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(5, 1).Range.Text = "Data zgłoszenia";
                    oTable.Cell(6, 1).Range.Text = dgv_ZgloszenieSerwisoweWybierz[7, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(5, 2).Range.Text = "Planowana data realizacji";
                    oTable.Cell(6, 2).Range.Text = dgv_ZgloszenieSerwisoweWybierz[9, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                    oTable.Cell(5, 3).Range.Text = "Data realizacji";
                    oTable.Cell(6, 3).Range.Text = dgv_ZgloszenieSerwisoweWybierz[10, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value.ToString();
                }
            }
        }

        private void b_modyfikuj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cb_StatusZgloszenia.Text) && dgv_ZgloszenieSerwisoweWybierz.CurrentCell != null)
            {
                //da.SelectCommand = new SqlCommand("Select * From dbo.ZgloszenieSerwisowe", sc);
                //dgv_ZgloszenieSerwisoweWybierz["statusZgloszeniaDataGridViewTextBoxColumn", dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value = cb_StatusZgloszenia.Text;
                //DataRow wiersz = serwisDataSet.ZgloszenieSerwisowe.Rows.Find(dgv_ZgloszenieSerwisoweWybierz[0, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value);
                //wiersz.BeginEdit();
                //wiersz["StatusZgloszenia"] = cb_StatusZgloszenia.Text;
                //wiersz.EndEdit();
                //SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(da);
                //da.Update(serwisDataSet, "ZgloszenieSerwisowe");

                //sql_cmd = sc.CreateCommand();
                //sql_cmd.CommandText = zgloszenieSerwisoweTableAdapter.Adapter.SelectCommand.CommandText;
                //sql_adapter = new SqlDataAdapter(sql_cmd);
                //cmd_builder = new SqlCommandBuilder(sql_adapter);
                //sql_adapter.UpdateCommand = cmd_builder.GetUpdateCommand();
                //sql_adapter.Fill(serwisDataSet.ZgloszenieSerwisowe);





                da.UpdateCommand = new SqlCommand("UPDATE ZgloszenieSerwisowe SET StatusZgloszenia = @StatusZgloszenia WHERE (ID = @Original_ID)", sc);
                da.UpdateCommand.Parameters.Add("@Original_ID", SqlDbType.Int).Value = dgv_ZgloszenieSerwisoweWybierz[0, dgv_ZgloszenieSerwisoweWybierz.CurrentCell.RowIndex].Value;
                da.UpdateCommand.Parameters.Add("@StatusZgloszenia", SqlDbType.Text).Value = cb_StatusZgloszenia.Text;
                try
                {
                    sc.Open();
                    da.UpdateCommand.ExecuteNonQuery();
                    sc.Close();
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message, "Błąd połączenia z bazą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //serwisDataSet.ZgloszenieSerwisowe.Clear();
                //serwisDataSet.ZgloszenieSerwisowe.Reset();
                //da.SelectCommand = new SqlCommand("SELECT ZgloszenieSerwisowe.ID, Klient.Nazwisko, Klient.Imie, PunktSerwisowy.NazwaFirmy, ZgloszenieSerwisowe.NazwaUrzadzenia, ZgloszenieSerwisowe.NrSeryjnyUrzadzenia, ZgloszenieSerwisowe.OpisUsterki, ZgloszenieSerwisowe.DataZgloszenia, ZgloszenieSerwisowe.StatusZgloszenia, ZgloszenieSerwisowe.PlanowanaDataRealizacji, ZgloszenieSerwisowe.DataRealizacji FROM ZgloszenieSerwisowe INNER JOIN Klient ON ZgloszenieSerwisowe.IDKlient = Klient.ID INNER JOIN PunktSerwisowy ON ZgloszenieSerwisowe.IDPunktSerwisowy = PunktSerwisowy.ID");
                //da.Fill(serwisDataSet.ZgloszenieSerwisowe);
                zgloszenieSerwisoweTableAdapter.Fill(serwisDataSet.ZgloszenieSerwisowe);
                zgloszenieSerwisoweBindingSource.ResetBindings(false);
                wyszukaj.Filtruj(dgv_ZgloszenieSerwisoweWyszukaj, zgloszenieSerwisoweBindingSource);

                //dgv_ZgloszenieSerwisoweWybierz.DataSource = serwisDataSet.ZgloszenieSerwisowe;
                //this.zgloszenieSerwisoweTableAdapter.Fill(this.serwisDataSet.ZgloszenieSerwisowe);
                //dgv_ZgloszenieSerwisoweWybierz.DataSource = serwisDataSet.ZgloszenieSerwisowe;

            }
        }
    }
}
