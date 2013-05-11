namespace Sacramentos.Busquedas
{
    partial class BuscarSacerdote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarSacerdote));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_nombrebuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_idbuscar = new System.Windows.Forms.TextBox();
            this.dgv_sacerdotes = new System.Windows.Forms.DataGridView();
            this.bd_iglesiaDataSet = new Sacramentos.bd_iglesiaDataSet();
            this.sacerdotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacerdotesTableAdapter = new Sacramentos.bd_iglesiaDataSetTableAdapters.sacerdotesTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sacerdotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_iglesiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacerdotesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_sacerdotes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbx_nombrebuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbx_idbuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Sacerdotes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "doble clic para seleccionar al sacerdote ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nombre";
            // 
            // tbx_nombrebuscar
            // 
            this.tbx_nombrebuscar.Location = new System.Drawing.Point(95, 53);
            this.tbx_nombrebuscar.Name = "tbx_nombrebuscar";
            this.tbx_nombrebuscar.Size = new System.Drawing.Size(377, 20);
            this.tbx_nombrebuscar.TabIndex = 62;
            this.tbx_nombrebuscar.TextChanged += new System.EventHandler(this.tbx_nombrebuscar_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Identidad";
            // 
            // tbx_idbuscar
            // 
            this.tbx_idbuscar.Location = new System.Drawing.Point(95, 27);
            this.tbx_idbuscar.Name = "tbx_idbuscar";
            this.tbx_idbuscar.Size = new System.Drawing.Size(377, 20);
            this.tbx_idbuscar.TabIndex = 60;
            this.tbx_idbuscar.TextChanged += new System.EventHandler(this.tbx_nombrebuscar_TextChanged);
            // 
            // dgv_sacerdotes
            // 
            this.dgv_sacerdotes.AllowUserToAddRows = false;
            this.dgv_sacerdotes.AllowUserToDeleteRows = false;
            this.dgv_sacerdotes.AutoGenerateColumns = false;
            this.dgv_sacerdotes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sacerdotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sacerdotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sacerdotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgv_sacerdotes.DataSource = this.sacerdotesBindingSource;
            this.dgv_sacerdotes.Location = new System.Drawing.Point(12, 98);
            this.dgv_sacerdotes.Name = "dgv_sacerdotes";
            this.dgv_sacerdotes.ReadOnly = true;
            this.dgv_sacerdotes.RowHeadersVisible = false;
            this.dgv_sacerdotes.Size = new System.Drawing.Size(552, 302);
            this.dgv_sacerdotes.TabIndex = 64;
            this.dgv_sacerdotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sacerdotes_CellDoubleClick);
            // 
            // bd_iglesiaDataSet
            // 
            this.bd_iglesiaDataSet.DataSetName = "bd_iglesiaDataSet";
            this.bd_iglesiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacerdotesBindingSource
            // 
            this.sacerdotesBindingSource.DataMember = "sacerdotes";
            this.sacerdotesBindingSource.DataSource = this.bd_iglesiaDataSet;
            // 
            // sacerdotesTableAdapter
            // 
            this.sacerdotesTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "identidad";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 300;
            // 
            // BuscarSacerdote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 408);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarSacerdote";
            this.Text = "BuscarSacerdote";
            this.Load += new System.EventHandler(this.BuscarSacerdote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sacerdotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_iglesiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacerdotesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_nombrebuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_idbuscar;
        private System.Windows.Forms.DataGridView dgv_sacerdotes;
        private bd_iglesiaDataSet bd_iglesiaDataSet;
        private System.Windows.Forms.BindingSource sacerdotesBindingSource;
        private bd_iglesiaDataSetTableAdapters.sacerdotesTableAdapter sacerdotesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}