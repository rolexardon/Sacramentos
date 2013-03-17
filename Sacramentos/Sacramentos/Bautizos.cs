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
    }
}
