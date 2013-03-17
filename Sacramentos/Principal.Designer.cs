namespace Sacramentos
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacerdotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_parroquias = new System.Windows.Forms.Button();
            this.btn_sacerdotes = new System.Windows.Forms.Button();
            this.btn_persona = new System.Windows.Forms.Button();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.sacerdotesToolStripMenuItem,
            this.pToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sToolStripMenuItem.Text = "Sistema";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // sacerdotesToolStripMenuItem
            // 
            this.sacerdotesToolStripMenuItem.Name = "sacerdotesToolStripMenuItem";
            this.sacerdotesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sacerdotesToolStripMenuItem.Text = "Sacerdotes";
            this.sacerdotesToolStripMenuItem.Click += new System.EventHandler(this.sacerdotesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btn_parroquias);
            this.panel1.Controls.Add(this.btn_sacerdotes);
            this.panel1.Controls.Add(this.btn_persona);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 725);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 71);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bautizo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_parroquias
            // 
            this.btn_parroquias.Location = new System.Drawing.Point(6, 159);
            this.btn_parroquias.Name = "btn_parroquias";
            this.btn_parroquias.Size = new System.Drawing.Size(75, 71);
            this.btn_parroquias.TabIndex = 2;
            this.btn_parroquias.Text = "Parroquias";
            this.btn_parroquias.UseVisualStyleBackColor = true;
            this.btn_parroquias.Click += new System.EventHandler(this.btn_parroquias_Click);
            // 
            // btn_sacerdotes
            // 
            this.btn_sacerdotes.Image = ((System.Drawing.Image)(resources.GetObject("btn_sacerdotes.Image")));
            this.btn_sacerdotes.Location = new System.Drawing.Point(6, 82);
            this.btn_sacerdotes.Name = "btn_sacerdotes";
            this.btn_sacerdotes.Size = new System.Drawing.Size(75, 71);
            this.btn_sacerdotes.TabIndex = 1;
            this.btn_sacerdotes.Text = "Sacerdotes";
            this.btn_sacerdotes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sacerdotes.UseVisualStyleBackColor = true;
            this.btn_sacerdotes.Click += new System.EventHandler(this.btn_sacerdotes_Click);
            // 
            // btn_persona
            // 
            this.btn_persona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_persona.Image = ((System.Drawing.Image)(resources.GetObject("btn_persona.Image")));
            this.btn_persona.Location = new System.Drawing.Point(6, 7);
            this.btn_persona.Name = "btn_persona";
            this.btn_persona.Size = new System.Drawing.Size(75, 71);
            this.btn_persona.TabIndex = 0;
            this.btn_persona.Text = "Personas";
            this.btn_persona.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_persona.UseVisualStyleBackColor = true;
            this.btn_persona.Click += new System.EventHandler(this.btn_persona_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pToolStripMenuItem.Text = "Parroquias";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Sacramentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_parroquias;
        private System.Windows.Forms.Button btn_sacerdotes;
        private System.Windows.Forms.Button btn_persona;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacerdotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
    }
}

