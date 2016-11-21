using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Serwis
{
    class Wyszukaj
    {
        private string select;
        private DataTable datatable;
        //private DataTable backupDataTable;
        private DateTimePicker dtp;
        private DataGridView dgv;
        private DateCell datecell;
        private BindingSource bindingsource;
        private Control f_parent;
        private object dataSourceDgv;

        private struct DateCell
        {
            public int row;
            public int column;
        }

        public Wyszukaj(DataTable datatable, DataGridView dgv_klientWyszukaj, BindingSource bindingsource)
        {
            // TODO: Complete member initialization
            dgv = dgv_klientWyszukaj;
            this.datatable = datatable;
            this.bindingsource = bindingsource;
            //backupDataTable = datatable;
            f_parent = dgv_klientWyszukaj.Parent;
            f_parent.SizeChanged+=new EventHandler(f_parent_SizeChanged);

            dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Visible = false;
            //dtp.Width = 100;
            dgv_klientWyszukaj.Controls.Add(dtp);
            dtp.ValueChanged += new EventHandler(dtp_ValueChanged);
            dtp.KeyUp += new KeyEventHandler(dtp_KeyUp);

        }

        private void f_parent_SizeChanged(object sender, EventArgs e)
        { 
            dtp.Location = dgv.GetCellDisplayRectangle(datecell.column, datecell.row, false).Location;
            dtp.Width = dgv.GetCellDisplayRectangle(datecell.column, datecell.row, false).Width;
        }
        private void dtp_KeyUp(object sender, KeyEventArgs e)
        {
            DateTimePicker dtpS = (DateTimePicker)sender;
            if (e.KeyCode == Keys.Back)
            {
                dgv.Controls.Remove(dtpS);
                dgv[datecell.column, datecell.row].Value = null;
            }
        }

        internal void DodajKolumny(DataGridView dgv_klientWybierz, DataGridView dgv_klientWyszukaj)
        {
            foreach (DataGridViewColumn dgvc in dgv_klientWybierz.Columns)
            {
                dgv_klientWyszukaj.Columns.Add(dgvc.DataPropertyName, dgvc.HeaderText);
                dgv_klientWyszukaj.Columns[dgv_klientWyszukaj.ColumnCount - 1].ValueType = dgvc.ValueType;
                //if (dgvc.Name == "DateTime")
                //{
                //    dgv_klientWyszukaj[dgv_klientWyszukaj.Columns.Count - 1, 0];
                //}

            }
            dgv_klientWyszukaj.Columns.RemoveAt(0);
            dgv_klientWyszukaj.Rows.Add();
            dgv_klientWyszukaj.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgv_klientWyszukaj_CellBeginEdit);
            dgv_klientWyszukaj.CellEndEdit += new DataGridViewCellEventHandler(dgv_klientWyszukaj_CellEndEdit);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            dgv[datecell.column, datecell.row].Value = dtp.Text;
        }

        private void dgv_klientWyszukaj_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv.Columns[dgv.CurrentCell.ColumnIndex].ValueType.Name == "DateTime")
            {
                if (!dgv.Controls.Contains(dtp))
                    dgv.Controls.Add(dtp);
                dtp.Location = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                dtp.Width = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Width;
                datecell.row = e.RowIndex;
                datecell.column = e.ColumnIndex;
                dtp.Visible = true;
                if (dgv.CurrentCell.Value != null)
                {
                    dtp.Value = (DateTime)dgv.CurrentCell.Value;
                }
                else
                {
                    dtp.Value = DateTime.Today;
                }
            }
            else
            {
                dtp.Visible = false;
            }
        }

        private void dgv_klientWyszukaj_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Columns[dgv.CurrentCell.ColumnIndex].ValueType.Name == "DateTime" && dgv.Controls.Contains(dtp))
            {
                dgv[e.ColumnIndex,e.RowIndex].Value = dtp.Value.Date;
            }
            Filtruj(dgv,bindingsource);

        }

        internal void Filtruj(DataGridView dataGridView, BindingSource zgloszenieSerwisoweBindingSource)
        {
            DateTime dt;
            //datatable = backupDataTable;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView[i, 0].Value != null)
                {

                    if (datatable.Columns[dataGridView.Columns[i].Name].DataType.Name == "Int32")
                    {
                        select += dataGridView.Columns[i].Name + " = " + dataGridView[i, 0].Value + " AND ";
                    }
                    else if (datatable.Columns[dataGridView.Columns[i].Name].DataType.Name == "DateTime")
                    {
                        if (DateTime.TryParse(dataGridView[i, 0].Value.ToString(), out dt))
                        {
                            select += dataGridView.Columns[i].Name + " = #" + dt + "# AND ";
                        }
                        else
                        {
                            dataGridView[i, 0].Value = null;
                        }
                    }
                    else
                    {
                        select += dataGridView.Columns[i].Name + " LIKE \'" + dataGridView[i, 0].Value.ToString() + "%\' AND ";
                    }
                }
            }
            if (!string.IsNullOrWhiteSpace(select))
            {
                select = select.Remove(select.Length - 5);
                zgloszenieSerwisoweBindingSource.DataSource = datatable.Select(select);
                select = "";
            }
            else
            {
                zgloszenieSerwisoweBindingSource.DataSource = datatable;
            }
        }


        //internal void Filtruj(DataTable datatable, DataGridView dataGridView, BindingSource zgloszenieSerwisoweBindingSource)
        //{
        //    //DateTime dt;
        //    //for (int i = 0; i < dataGridView.Columns.Count; i++)
        //    //{
        //    //    if (dataGridView[i, 0].Value != null)
        //    //    {

        //    //        if (datatable.Columns[dataGridView.Columns[i].Name].DataType.Name == "Int32")
        //    //        {
        //    //            select += dataGridView.Columns[i].Name + " = " + dataGridView[i, 0].Value + " AND ";
        //    //        }
        //    //        else if (datatable.Columns[dataGridView.Columns[i].Name].DataType.Name == "DateTime")
        //    //        {
        //    //            if (DateTime.TryParse(dataGridView[i, 0].Value.ToString(), out dt))
        //    //            {
        //    //                select += dataGridView.Columns[i].Name + " = #" + dt + "# AND ";
        //    //            }
        //    //            else
        //    //            {
        //    //                dataGridView[i, 0].Value = null;
        //    //            }
        //    //        }
        //    //        else
        //    //        {
        //    //            select += dataGridView.Columns[i].Name + " LIKE \'" + dataGridView[i, 0].Value.ToString() + "%\' AND ";
        //    //        }
        //    //    }
        //    //}
        //    //if (!string.IsNullOrWhiteSpace(select))
        //    //{
        //    //    select = select.Remove(select.Length - 5);
        //    //    dataSourceDgv = dgv_klientWybierz.DataSource;
        //    //    //dgv_klientWybierz.BeginEdit(true);
        //    //    bindingSource1.DataSource = datatable.Select(select);
        //    //    dgv_klientWybierz.AutoGenerateColumns = true;
        //    //    dgv_klientWybierz.DataSource = bindingSource1;
        //    //    //dgv_klientWybierz.EndEdit();
        //    //    select = "";
        //    //}
        //    //else
        //    //{
        //        bindingsource.DataSource = datatable;
        //    //}
        //}
    }
}
