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
    public partial class BuscarParroquias : Form
    {
        TextBox code;
        TextBox parroquia;

        public BuscarParroquias(TextBox code,TextBox parroquia)
        {
            InitializeComponent();
            this.code = code;
            this.parroquia = parroquia;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void BuscarParroquias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.parroquias' table. You can move, or remove it, as needed.
            this.parroquiasTableAdapter.Fill(this.bd_iglesiaDataSet.parroquias);

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
                        string name, direccion;

                        name = tbx_nombrebuscar.Text;
                        direccion = tbx_direccionbuscar.Text;

                        bindingSource1.Filter = "nombre LIKE '%" + name + "%' AND direccion LIKE '%" + direccion + "%'";
                        dgv_parroquias.Update();
                        dgv_parroquias.Refresh();

                    } break;

            }
        }

        private void dgv_parroquias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                string codigo = dgv_parroquias.Rows[row].Cells[0].Value.ToString();
                string nombre = dgv_parroquias.Rows[row].Cells[1].Value.ToString();

                code.Text = codigo;
                parroquia.Text = nombre;

            }

            this.Dispose();
            this.Close();
        }

        private void tbx_direccionbuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }
    }
}
