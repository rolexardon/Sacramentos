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
    public partial class Bautismos : Form
    {
        public Bautismos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bautismos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd_iglesiaDataSet.bautizos' table. You can move, or remove it, as needed.
            this.bautizosTableAdapter.Fill(this.bd_iglesiaDataSet.bautizos);

        }

        private void btn_buscarparroquia_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarParroquias bp = new Busquedas.BuscarParroquias(this.tbx_codeparroquia,this.tbx_parroquia);
            bp.Show();
        }

        private void btn_buscarsacerdote_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarSacerdote bs = new Busquedas.BuscarSacerdote(this.tbx_codesacerdote, this.tbx_sacerdote);
            bs.Show();
        }

        private void btn_buscarbautizado_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarPersonas bba = new Busquedas.BuscarPersonas(this.tbx_codebautizado, this.tbx_bautizado,null,"persona");
            bba.Show();
        }

        private void btn_buscarpadre_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarPersonas bpa = new Busquedas.BuscarPersonas(this.tbx_codepadre, this.tbx_padre,null,"persona");
            bpa.Show();
        }

        private void btn_buscarmadre_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarPersonas bma = new Busquedas.BuscarPersonas(this.tbx_codemadre, this.tbx_madre,null,"persona");
            bma.Show();
        }

        private void btn_agregapadrino_Click(object sender, EventArgs e)
        {
            Busquedas.BuscarPersonas bpad = new Busquedas.BuscarPersonas(null,null,this.list_padrinos,"padrino");
            bpad.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (validar_datos(1))
            {
                if (tbx_codepadre.Text != "" && tbx_codemadre.Text != "")  bautizosTableAdapter.InsertQuery(Convert.ToDateTime(dtp_fecha.Text), Convert.ToInt32(tbx_codeparroquia.Text), Convert.ToInt32(tbx_codesacerdote.Text), Convert.ToInt32(tbx_codebautizado.Text), Convert.ToInt32(tbx_codepadre.Text), Convert.ToInt32(tbx_codemadre.Text), tbx_observacion.Text);
                if (tbx_codepadre.Text != "" && tbx_codemadre.Text == "") bautizosTableAdapter.InsertQuery(Convert.ToDateTime(dtp_fecha.Text), Convert.ToInt32(tbx_codeparroquia.Text), Convert.ToInt32(tbx_codesacerdote.Text), Convert.ToInt32(tbx_codebautizado.Text), Convert.ToInt32(tbx_codepadre.Text),null, tbx_observacion.Text);
                if (tbx_codepadre.Text == "" && tbx_codemadre.Text != "") bautizosTableAdapter.InsertQuery(Convert.ToDateTime(dtp_fecha.Text), Convert.ToInt32(tbx_codeparroquia.Text), Convert.ToInt32(tbx_codesacerdote.Text), Convert.ToInt32(tbx_codebautizado.Text), null, Convert.ToInt32(tbx_codemadre.Text), tbx_observacion.Text);
                
                bautizosTableAdapter.Fill(bd_iglesiaDataSet.bautizos);




                dgv_bautizos.Update();
                dgv_bautizos.Refresh();
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
                        if (tbx_codeparroquia.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarparroquia, "Seleccione la parroquia");
                        }
                        else
                        {
                            errorProvider1.SetError(btn_buscarparroquia, "");
                        }
                        if (tbx_codesacerdote.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarsacerdote, "Seleccione el sacerdote");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_buscarsacerdote, "");
                        }
                        
                        if (tbx_codebautizado.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarbautizado, "Seleccione el bautizado");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_buscarbautizado, "");
                        }
                        if (list_padrinos.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_agregapadrino, "Seleccione al menos un padrino");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_agregapadrino, "");
                        }
                          

                    } break;
                case 2:
                    {
                        if (tbx_codeparroquia.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarparroquia, "Seleccione la parroquia");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_buscarparroquia, "");
                        }
                        if (tbx_codesacerdote.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarsacerdote, "Seleccione el sacerdote");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_buscarsacerdote, "");
                        }
                        if (tbx_codebautizado.Text.Equals(""))
                        {
                            ret = false;
                            errorProvider1.SetError(btn_buscarbautizado, "Seleccione el bautizado");
                        }
                         else
                        {
                            errorProvider1.SetError(btn_buscarbautizado, "");
                        }

                    } break;
            }

            return ret;
        }

        public void LimpiarDatos(int caso)
        {
            /*
            switch (caso)
            {
                case 1:
                    {

                        tbx_nextpk.Text = (bautizosTableAdapter.NEXT_ID()).ToString();

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
            */
            }

        }
    }

