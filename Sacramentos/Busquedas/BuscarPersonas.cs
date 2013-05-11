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
    public partial class BuscarPersonas : Form
    {
        TextBox code;
        TextBox persona;
        ListBox padrinos;
        string tipo;

        public BuscarPersonas(TextBox code, TextBox persona, ListBox padrinos, string tipo)
        {
            InitializeComponent();
            this.code = code;
            this.persona = persona;
            this.padrinos = padrinos;
            this.tipo = tipo;
        }

        private void BuscarPersonas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.personas' table. You can move, or remove it, as needed.
            this.personasTableAdapter.Fill(this.bd_iglesiaDataSet.personas);

        }

        private void tbx_idbuscar_TextChanged(object sender, EventArgs e)
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

                        personasBindingSource.Filter = "id LIKE '%" + id + "%' AND nombre LIKE '%" + name + "%'";
                        dgv_personas.Update();
                        dgv_personas.Refresh();

                    } break;

            }
        }

        private void dgv_personas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                string codigo = dgv_personas.Rows[row].Cells[0].Value.ToString();
                string nombre = dgv_personas.Rows[row].Cells[2].Value.ToString();

                if (tipo.Equals("persona"))
                {
                    code.Text = codigo;
                    persona.Text = nombre;
                }
                else {
                    padrinos.Items.Add(codigo + "~" + nombre);
                
                }

            }

            this.Dispose();
            this.Close();
        }

        private void tbx_nombrebuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

    }
}
