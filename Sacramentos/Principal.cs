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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_persona_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.MdiParent = this;
            p.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.MdiParent = this;
            p.Show();
        }

        private void btn_sacerdotes_Click(object sender, EventArgs e)
        {
            Sacerdotes p = new Sacerdotes();
            p.MdiParent = this;
            p.Show();
        }

        private void sacerdotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sacerdotes p = new Sacerdotes();
            p.MdiParent = this;
            p.Show();
        }

        private void btn_parroquias_Click(object sender, EventArgs e)
        {
            Parroquias p = new Parroquias();
            p.MdiParent = this;
            p.Show();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parroquias p = new Parroquias();
            p.MdiParent = this;
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bautismos p = new Bautismos();
            p.MdiParent = this;
            p.Show();
        }
    }
}
