using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sacramentos.Busquedas
{
    public partial class BuscarSacerdote : Form
    {

        TextBox code;
        TextBox sacerdote;


        public BuscarSacerdote(TextBox code, TextBox sacerdote)
        {
            InitializeComponent();
            this.code = code;
            this.sacerdote = sacerdote;
        }

        private void BuscarSacerdote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.sacerdotes' table. You can move, or remove it, as needed.
            this.sacerdotesTableAdapter.Fill(this.bd_iglesiaDataSet.sacerdotes);

        }

        private void tbx_nombrebuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

        private void AplicarFiltro(int p)
        {
            switch (p)
            {
                case 1:
                    {
                        string id, name;

                        id = tbx_idbuscar.Text;
                        name = tbx_nombrebuscar.Text;

                        sacerdotesBindingSource.Filter = "id LIKE '%" + id + "%' AND nombre LIKE '%" + name + "%'";
                        dgv_sacerdotes.Update();
                        dgv_sacerdotes.Refresh();

                    } break;

            }
        }

        private void tbx_nombrebuscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgv_sacerdotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                string codigo = dgv_sacerdotes.Rows[row].Cells[0].Value.ToString();
                string nombre = dgv_sacerdotes.Rows[row].Cells[2].Value.ToString();

                code.Text = codigo;
                sacerdote.Text = nombre;

            }

            this.Dispose();
            this.Close();
        }

    }

}
