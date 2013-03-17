using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sacramentos
{
    public partial class Parroquias : Form
    {
        public Parroquias()
        {
            InitializeComponent();
        }

        private void Parroquias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.parroquias' table. You can move, or remove it, as needed.
            try
            {
                this.parroquiasTableAdapter.Fill(this.bd_iglesiaDataSet.parroquias);
            }
            catch { 
            
            
            }

            tbx_nextpk.Text = (parroquiasTableAdapter.NEXT_ID()).ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validar_datos(1))
            {
                parroquiasTableAdapter.InsertQuery(tbx_nombre.Text, tbx_direccion.Text, Convert.ToInt32(tbx_tel.Text));
                parroquiasTableAdapter.Fill(bd_iglesiaDataSet.parroquias);
                dgv_parroquias.Update();
                dgv_parroquias.Refresh();
                MessageBox.Show("Datos guardados correctamente", "Transacción existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos(1);
            }
        }

        private bool validar_datos(int p)
        {

            bool ret = true;
            switch (p)
            {
                case 1:
                    {
                        if (tbx_nombre.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_nombre, "Ingrese el nombre");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_nombre, "");
                        }
                        if (tbx_tel.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_tel, "Ingrese un contacto telefónico");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_tel, "");
                        }
                        if (tbx_direccion.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_direccion, "Ingrese la dirección exacta de la parroquia");
                            
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_direccion, "");
                        }
                    } break;
                case 2:
                    {
                        if (tbx_nombre2.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_nombre2, "Ingrese el nombre");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_nombre2, "");
                        }
                        if (tbx_tel2.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_tel2, "Ingrese un contacto telefónico");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_tel2, "");
                        }
                        if (tbx_direccion2.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_direccion2, "Ingrese la dirección exacta de la parroquia");

                        }
                        else
                        {
                            errorProvider1.SetError(tbx_direccion2, "");
                        }

                    } break;
            }

            return ret;
        }

        public void LimpiarDatos(int caso)
        {

            switch (caso)
            {
                case 1:
                    {

                        tbx_nextpk.Text = (parroquiasTableAdapter.NEXT_ID()).ToString();

                        
                        tbx_nombre.Clear();
                        tbx_tel.Clear();
                        tbx_direccion.Clear();

                    } break;
                case 2:
                    {
                        tbx_nombre2.Clear();
                        tbx_tel2.Clear();
                        tbx_direccion2.Clear();

                    } break;

            }

        }

        private void AplicarFiltro(int p)
        {
            switch (p)
            {
                case 1:
                    {
                        string name,direccion;
                        
                        name = tbx_nombrebuscar.Text;
                        direccion = tbx_direccionbuscar.Text;

                        parroquiasBindingSource1.Filter = "nombre LIKE '%" + name + "%' AND direccion LIKE '%" + direccion + "%'";
                        dgv_parroquias2.Update();
                        dgv_parroquias2.Refresh();

                    } break;

            }
        }

        private void tbx_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tbx_nombrebuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que deseea eliminar el registro?", "Confirmar Transacción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                parroquiasTableAdapter.DeleteQuery(Convert.ToInt32(tbx_nextpk2.Text));
                parroquiasTableAdapter.Fill(bd_iglesiaDataSet.parroquias);
                dgv_parroquias2.Update();
                dgv_parroquias2.Refresh();
                MessageBox.Show("Registro eliminado", "Transacción existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos(2);
            }
        }

        private void dgv_parroquias2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                string codigo = dgv_parroquias2.Rows[row].Cells[0].Value.ToString();
                string nombre = dgv_parroquias2.Rows[row].Cells[1].Value.ToString();
                string direccion = dgv_parroquias2.Rows[row].Cells[2].Value.ToString();
                string telefono = dgv_parroquias2.Rows[row].Cells[3].Value.ToString();

                tbx_nextpk2.Text = codigo;
                tbx_nombre2.Text = nombre;
                tbx_direccion2.Text = direccion;
                tbx_tel2.Text = telefono;

            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validar_datos(2))
            {
                parroquiasTableAdapter.UpdateQuery(tbx_nombre2.Text, tbx_direccion2.Text, Convert.ToInt32(tbx_tel2.Text), Convert.ToInt32(tbx_nextpk2.Text));
                parroquiasTableAdapter.Fill(bd_iglesiaDataSet.parroquias);
                dgv_parroquias2.Update();
                dgv_parroquias2.Refresh();
                MessageBox.Show("Datos modificados correctamente", "Transacción existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos(2);
            }
        }

        private void tbx_nombrebuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

        private void tbx_direccionbuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

        private void tbx_tel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
