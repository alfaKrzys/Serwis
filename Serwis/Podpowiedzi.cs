using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace Serwis
{
    class Podpowiedzi
    {
        private SqlConnection sc;
        private TextBoxBase textBoxBase;
        private GroupBox groupBox1;
        private ListBox listbox;
        private string p;
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        public Podpowiedzi(SqlConnection sc, TextBoxBase textBoxBase, GroupBox groupBox1, string p)
        {
            // TODO: Complete member initialization
            this.sc = sc;
            this.textBoxBase = textBoxBase;
            this.groupBox1 = groupBox1;
            this.p = p;
            textBoxBase.KeyDown += new KeyEventHandler(textBoxBase_KeyDown);
        }

        internal void Run()
        {
            if (listbox == null)
            {
                listbox = new ListBox();
                listbox.Location = new Point(textBoxBase.Location.X, textBoxBase.Location.Y + textBoxBase.Size.Height);
                listbox.Click += new EventHandler(listBox1_Click);
                listbox.KeyDown+=new KeyEventHandler(listbox_KeyDown);
            }
            if (!groupBox1.Contains(listbox))
            {
                groupBox1.Controls.Add(listbox);
                listbox.BringToFront();
            }
            da.SelectCommand = new SqlCommand("SELECT DISTINCT " + textBoxBase.Name.Substring(3) + " FROM " + p + " WHERE " + textBoxBase.Name.Substring(3) + " LIKE \'" + textBoxBase.Text + "%\'", sc);
            ds.Clear();
            listbox.Items.Clear();
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
                        listbox.Items.Add(row[column]);
                    }
                }
            }

            listbox.Height = (listbox.Items.Count + 1) * listbox.ItemHeight;
            if (listbox.Items.Count == 0)
                groupBox1.Controls.Remove(listbox);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBoxBase.Text = ((ListBox)sender).Text;
            groupBox1.Controls.Remove(listbox);
            listbox = null;
        }

        private void textBoxBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                if (listbox.SelectedIndex == -1)
                {
                    listbox.Select();
                    listbox.SetSelected(0, true);
                }
        }

        private void listbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && listbox.SelectedIndex == 0)
            {
                listbox.SelectedIndex = -1;
                textBoxBase.Select();
            }
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                textBoxBase.Text = ((ListBox)sender).Text;
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                groupBox1.Controls.Remove(listbox);
                listbox = null;

            }
        }
    }
}
