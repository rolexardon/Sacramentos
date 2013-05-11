using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Sacramentos
{
    public partial class Sacerdotes : Form
    {
        public Sacerdotes()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sacerdotes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.sacerdotes' table. You can move, or remove it, as needed.
            try
            {
                this.sacerdotesTableAdapter.Fill(this.bd_iglesiaDataSet.sacerdotes);
            }
            catch (Exception exp) { 
            
            
            }
                tbx_nextpk.Text = (sacerdotesTableAdapter.LAST_ID()).ToString();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validar_datos(1))
            {
                sacerdotesTableAdapter.InsertQuery(Convert.ToDateTime(dtp_nacimiento.Text), tbx_correo.Text, tbx_id.Text, tbx_nombre.Text, Convert.ToInt32(tbx_tel.Text));
                sacerdotesTableAdapter.Fill(bd_iglesiaDataSet.sacerdotes);
                dgv_sacerdotes.Update();
                dgv_sacerdotes.Refresh();
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
                        if (tbx_id.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_id, "Ingrese la identidad");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_id, "");
                        }
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
                        if (!tbx_correo.Text.Equals(""))
                        {
                            if (!IsValidMail(tbx_correo.Text))
                            {
                                ret = false;
                                errorProvider1.SetError(tbx_correo, "Ingrese formato de correo correcto");
                            }
                            else
                            {
                                errorProvider1.SetError(tbx_correo, "");
                            }
                        }

                    } break;
                case 2:
                    {
                        if (tbx_id2.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(tbx_id2, "Ingrese la identidad");
                        }
                        else
                        {
                            errorProvider1.SetError(tbx_id2, "");
                        }
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
                        if (!tbx_correo2.Text.Equals(""))
                        {
                            if (!IsValidMail(tbx_correo2.Text))
                            {
                                ret = false;
                                errorProvider1.SetError(tbx_correo2, "Ingrese formato de correo correcto");
                            }
                            else
                            {
                                errorProvider1.SetError(tbx_correo2, "");
                            }
                        }

                    } break;
            }

            return ret;
        }

        public bool IsValidMail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void LimpiarDatos(int caso)
        {

            switch (caso)
            {
                case 1:
                    {

                        tbx_nextpk.Text = (sacerdotesTableAdapter.LAST_ID()).ToString();

                        tbx_id.Clear();
                        tbx_nombre.Clear();
                        tbx_tel.Clear();
                        tbx_correo.Clear();

                    } break;
                case 2:
                    {
                        tbx_nextpk2.Clear();
                        tbx_id2.Clear();
                        tbx_nombre2.Clear();
                        tbx_tel2.Clear();
                        tbx_correo2.Clear();

                    } break;

            }

        }

        private void dgv_sacerdotes2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                string codigo = dgv_sacerdotes2.Rows[row].Cells[0].Value.ToString();
                string identidad = dgv_sacerdotes2.Rows[row].Cells[1].Value.ToString();
                string nombre = dgv_sacerdotes2.Rows[row].Cells[2].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgv_sacerdotes2.Rows[row].Cells[3].Value.ToString());
                string tel = dgv_sacerdotes2.Rows[row].Cells[4].Value.ToString();
                string correo = dgv_sacerdotes2.Rows[row].Cells[5].Value.ToString();

                tbx_nextpk2.Text = codigo;
                tbx_id2.Text = identidad;
                tbx_nombre2.Text = nombre;
                dtp_nacimiento2.Value = fecha;
                tbx_tel2.Text = tel;
                tbx_correo2.Text = correo;

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que deseea eliminar el registro?", "Confirmar Transacción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sacerdotesTableAdapter.DeleteQuery(Convert.ToInt32(tbx_nextpk2.Text));
                sacerdotesTableAdapter.Fill(bd_iglesiaDataSet.sacerdotes);
                dgv_sacerdotes2.Update();
                dgv_sacerdotes2.Refresh();
                MessageBox.Show("Registro eliminado", "Transacción existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos(2);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (validar_datos(2))
            {
                sacerdotesTableAdapter.UpdateQuery(Convert.ToDateTime(dtp_nacimiento2.Text), tbx_correo2.Text, tbx_id2.Text, tbx_nombre2.Text, Convert.ToInt32(tbx_tel2.Text), Convert.ToInt32(tbx_nextpk2.Text));
                sacerdotesTableAdapter.Fill(bd_iglesiaDataSet.sacerdotes);
                dgv_sacerdotes2.Update();
                dgv_sacerdotes2.Refresh();
                MessageBox.Show("Datos modificados correctamente", "Transacción existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatos(2);
            }
        }

        private void tbx_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tbx_tel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
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

                        bindingSource1.Filter = "id LIKE '%" + id + "%' AND nombre LIKE '%" + name + "%'";
                        dgv_sacerdotes2.Update();
                        dgv_sacerdotes2.Refresh();

                    } break;

            }
        }

        private void tbx_idbuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

        private void tbx_nombrebuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro(1);
        }

    }
}
