namespace Sacramentos
{
    partial class Bautismos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bautismos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_bautizos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechabauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parroquiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sacerdoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bautizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_iglesiaDataSet = new Sacramentos.bd_iglesiaDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_codemadre = new System.Windows.Forms.TextBox();
            this.tbx_codepadre = new System.Windows.Forms.TextBox();
            this.tbx_codebautizado = new System.Windows.Forms.TextBox();
            this.tbx_codesacerdote = new System.Windows.Forms.TextBox();
            this.tbx_codeparroquia = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminapadrino = new System.Windows.Forms.Button();
            this.btn_agregapadrino = new System.Windows.Forms.Button();
            this.list_padrinos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_buscarmadre = new System.Windows.Forms.Button();
            this.tbx_madre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscarpadre = new System.Windows.Forms.Button();
            this.tbx_padre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscarbautizado = new System.Windows.Forms.Button();
            this.tbx_bautizado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscarsacerdote = new System.Windows.Forms.Button();
            this.tbx_sacerdote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscarparroquia = new System.Windows.Forms.Button();
            this.tbx_parroquia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_codigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bautizosTableAdapter = new Sacramentos.bd_iglesiaDataSetTableAdapters.bautizosTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bautizos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_iglesiaDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1198, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_bautizos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(597, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existentes";
            // 
            // dgv_bautizos
            // 
            this.dgv_bautizos.AllowUserToDeleteRows = false;
            this.dgv_bautizos.AutoGenerateColumns = false;
            this.dgv_bautizos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bautizos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bautizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bautizos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.fechabauDataGridViewTextBoxColumn,
            this.parroquiaDataGridViewTextBoxColumn,
            this.sacerdoteDataGridViewTextBoxColumn,
            this.bautizadoDataGridViewTextBoxColumn,
            this.padreDataGridViewTextBoxColumn,
            this.madreDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn});
            this.dgv_bautizos.DataSource = this.bindingSource1;
            this.dgv_bautizos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bautizos.Location = new System.Drawing.Point(3, 16);
            this.dgv_bautizos.Name = "dgv_bautizos";
            this.dgv_bautizos.ReadOnly = true;
            this.dgv_bautizos.RowHeadersVisible = false;
            this.dgv_bautizos.Size = new System.Drawing.Size(584, 451);
            this.dgv_bautizos.TabIndex = 1;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechabauDataGridViewTextBoxColumn
            // 
            this.fechabauDataGridViewTextBoxColumn.DataPropertyName = "fecha_bau";
            this.fechabauDataGridViewTextBoxColumn.HeaderText = "fecha_bau";
            this.fechabauDataGridViewTextBoxColumn.Name = "fechabauDataGridViewTextBoxColumn";
            this.fechabauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parroquiaDataGridViewTextBoxColumn
            // 
            this.parroquiaDataGridViewTextBoxColumn.DataPropertyName = "parroquia";
            this.parroquiaDataGridViewTextBoxColumn.HeaderText = "parroquia";
            this.parroquiaDataGridViewTextBoxColumn.Name = "parroquiaDataGridViewTextBoxColumn";
            this.parroquiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sacerdoteDataGridViewTextBoxColumn
            // 
            this.sacerdoteDataGridViewTextBoxColumn.DataPropertyName = "sacerdote";
            this.sacerdoteDataGridViewTextBoxColumn.HeaderText = "sacerdote";
            this.sacerdoteDataGridViewTextBoxColumn.Name = "sacerdoteDataGridViewTextBoxColumn";
            this.sacerdoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bautizadoDataGridViewTextBoxColumn
            // 
            this.bautizadoDataGridViewTextBoxColumn.DataPropertyName = "bautizado";
            this.bautizadoDataGridViewTextBoxColumn.HeaderText = "bautizado";
            this.bautizadoDataGridViewTextBoxColumn.Name = "bautizadoDataGridViewTextBoxColumn";
            this.bautizadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // padreDataGridViewTextBoxColumn
            // 
            this.padreDataGridViewTextBoxColumn.DataPropertyName = "padre";
            this.padreDataGridViewTextBoxColumn.HeaderText = "padre";
            this.padreDataGridViewTextBoxColumn.Name = "padreDataGridViewTextBoxColumn";
            this.padreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // madreDataGridViewTextBoxColumn
            // 
            this.madreDataGridViewTextBoxColumn.DataPropertyName = "madre";
            this.madreDataGridViewTextBoxColumn.HeaderText = "madre";
            this.madreDataGridViewTextBoxColumn.Name = "madreDataGridViewTextBoxColumn";
            this.madreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "bautizos";
            this.bindingSource1.DataSource = this.bd_iglesiaDataSet;
            // 
            // bd_iglesiaDataSet
            // 
            this.bd_iglesiaDataSet.DataSetName = "bd_iglesiaDataSet";
            this.bd_iglesiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_codemadre);
            this.groupBox1.Controls.Add(this.tbx_codepadre);
            this.groupBox1.Controls.Add(this.tbx_codebautizado);
            this.groupBox1.Controls.Add(this.tbx_codesacerdote);
            this.groupBox1.Controls.Add(this.tbx_codeparroquia);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.btn_eliminapadrino);
            this.groupBox1.Controls.Add(this.btn_agregapadrino);
            this.groupBox1.Controls.Add(this.list_padrinos);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btn_buscarmadre);
            this.groupBox1.Controls.Add(this.tbx_madre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_buscarpadre);
            this.groupBox1.Controls.Add(this.tbx_padre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_buscarbautizado);
            this.groupBox1.Controls.Add(this.tbx_bautizado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_buscarsacerdote);
            this.groupBox1.Controls.Add(this.tbx_sacerdote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscarparroquia);
            this.groupBox1.Controls.Add(this.tbx_parroquia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_codigo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // tbx_codemadre
            // 
            this.tbx_codemadre.Enabled = false;
            this.tbx_codemadre.Location = new System.Drawing.Point(109, 209);
            this.tbx_codemadre.Name = "tbx_codemadre";
            this.tbx_codemadre.Size = new System.Drawing.Size(100, 20);
            this.tbx_codemadre.TabIndex = 85;
            // 
            // tbx_codepadre
            // 
            this.tbx_codepadre.Enabled = false;
            this.tbx_codepadre.Location = new System.Drawing.Point(109, 177);
            this.tbx_codepadre.Name = "tbx_codepadre";
            this.tbx_codepadre.Size = new System.Drawing.Size(100, 20);
            this.tbx_codepadre.TabIndex = 84;
            // 
            // tbx_codebautizado
            // 
            this.tbx_codebautizado.Enabled = false;
            this.tbx_codebautizado.Location = new System.Drawing.Point(109, 145);
            this.tbx_codebautizado.Name = "tbx_codebautizado";
            this.tbx_codebautizado.Size = new System.Drawing.Size(100, 20);
            this.tbx_codebautizado.TabIndex = 83;
            // 
            // tbx_codesacerdote
            // 
            this.tbx_codesacerdote.Enabled = false;
            this.tbx_codesacerdote.Location = new System.Drawing.Point(109, 113);
            this.tbx_codesacerdote.Name = "tbx_codesacerdote";
            this.tbx_codesacerdote.Size = new System.Drawing.Size(100, 20);
            this.tbx_codesacerdote.TabIndex = 82;
            // 
            // tbx_codeparroquia
            // 
            this.tbx_codeparroquia.Enabled = false;
            this.tbx_codeparroquia.Location = new System.Drawing.Point(109, 81);
            this.tbx_codeparroquia.Name = "tbx_codeparroquia";
            this.tbx_codeparroquia.Size = new System.Drawing.Size(100, 20);
            this.tbx_codeparroquia.TabIndex = 81;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(498, 405);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(76, 32);
            this.btn_agregar.TabIndex = 80;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminapadrino
            // 
            this.btn_eliminapadrino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminapadrino.BackgroundImage")));
            this.btn_eliminapadrino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminapadrino.Location = new System.Drawing.Point(416, 305);
            this.btn_eliminapadrino.Name = "btn_eliminapadrino";
            this.btn_eliminapadrino.Size = new System.Drawing.Size(30, 32);
            this.btn_eliminapadrino.TabIndex = 79;
            this.btn_eliminapadrino.UseVisualStyleBackColor = true;
            // 
            // btn_agregapadrino
            // 
            this.btn_agregapadrino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregapadrino.BackgroundImage")));
            this.btn_agregapadrino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregapadrino.Location = new System.Drawing.Point(416, 272);
            this.btn_agregapadrino.Name = "btn_agregapadrino";
            this.btn_agregapadrino.Size = new System.Drawing.Size(30, 32);
            this.btn_agregapadrino.TabIndex = 78;
            this.btn_agregapadrino.UseVisualStyleBackColor = true;
            // 
            // list_padrinos
            // 
            this.list_padrinos.FormattingEnabled = true;
            this.list_padrinos.Location = new System.Drawing.Point(39, 272);
            this.list_padrinos.Name = "list_padrinos";
            this.list_padrinos.Size = new System.Drawing.Size(371, 121);
            this.list_padrinos.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Padrinos";
            // 
            // btn_buscarmadre
            // 
            this.btn_buscarmadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarmadre.BackgroundImage")));
            this.btn_buscarmadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarmadre.Location = new System.Drawing.Point(523, 203);
            this.btn_buscarmadre.Name = "btn_buscarmadre";
            this.btn_buscarmadre.Size = new System.Drawing.Size(30, 32);
            this.btn_buscarmadre.TabIndex = 74;
            this.btn_buscarmadre.UseVisualStyleBackColor = true;
            // 
            // tbx_madre
            // 
            this.tbx_madre.Enabled = false;
            this.tbx_madre.Location = new System.Drawing.Point(215, 209);
            this.tbx_madre.Name = "tbx_madre";
            this.tbx_madre.Size = new System.Drawing.Size(302, 20);
            this.tbx_madre.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Madre";
            // 
            // btn_buscarpadre
            // 
            this.btn_buscarpadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarpadre.BackgroundImage")));
            this.btn_buscarpadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarpadre.Location = new System.Drawing.Point(523, 171);
            this.btn_buscarpadre.Name = "btn_buscarpadre";
            this.btn_buscarpadre.Size = new System.Drawing.Size(30, 32);
            this.btn_buscarpadre.TabIndex = 71;
            this.btn_buscarpadre.UseVisualStyleBackColor = true;
            // 
            // tbx_padre
            // 
            this.tbx_padre.Enabled = false;
            this.tbx_padre.Location = new System.Drawing.Point(215, 177);
            this.tbx_padre.Name = "tbx_padre";
            this.tbx_padre.Size = new System.Drawing.Size(302, 20);
            this.tbx_padre.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 69;
            this.label7.Text = "Padre";
            // 
            // btn_buscarbautizado
            // 
            this.btn_buscarbautizado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarbautizado.BackgroundImage")));
            this.btn_buscarbautizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarbautizado.Location = new System.Drawing.Point(523, 139);
            this.btn_buscarbautizado.Name = "btn_buscarbautizado";
            this.btn_buscarbautizado.Size = new System.Drawing.Size(30, 32);
            this.btn_buscarbautizado.TabIndex = 68;
            this.btn_buscarbautizado.UseVisualStyleBackColor = true;
            // 
            // tbx_bautizado
            // 
            this.tbx_bautizado.Enabled = false;
            this.tbx_bautizado.Location = new System.Drawing.Point(215, 145);
            this.tbx_bautizado.Name = "tbx_bautizado";
            this.tbx_bautizado.Size = new System.Drawing.Size(302, 20);
            this.tbx_bautizado.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Bautizado";
            // 
            // btn_buscarsacerdote
            // 
            this.btn_buscarsacerdote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarsacerdote.BackgroundImage")));
            this.btn_buscarsacerdote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarsacerdote.Location = new System.Drawing.Point(523, 107);
            this.btn_buscarsacerdote.Name = "btn_buscarsacerdote";
            this.btn_buscarsacerdote.Size = new System.Drawing.Size(30, 32);
            this.btn_buscarsacerdote.TabIndex = 65;
            this.btn_buscarsacerdote.UseVisualStyleBackColor = true;
            // 
            // tbx_sacerdote
            // 
            this.tbx_sacerdote.Enabled = false;
            this.tbx_sacerdote.Location = new System.Drawing.Point(215, 113);
            this.tbx_sacerdote.Name = "tbx_sacerdote";
            this.tbx_sacerdote.Size = new System.Drawing.Size(302, 20);
            this.tbx_sacerdote.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Sacerdote";
            // 
            // btn_buscarparroquia
            // 
            this.btn_buscarparroquia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarparroquia.BackgroundImage")));
            this.btn_buscarparroquia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarparroquia.Location = new System.Drawing.Point(523, 75);
            this.btn_buscarparroquia.Name = "btn_buscarparroquia";
            this.btn_buscarparroquia.Size = new System.Drawing.Size(30, 32);
            this.btn_buscarparroquia.TabIndex = 62;
            this.btn_buscarparroquia.UseVisualStyleBackColor = true;
            this.btn_buscarparroquia.Click += new System.EventHandler(this.btn_buscarparroquia_Click);
            // 
            // tbx_parroquia
            // 
            this.tbx_parroquia.Enabled = false;
            this.tbx_parroquia.Location = new System.Drawing.Point(215, 81);
            this.tbx_parroquia.Name = "tbx_parroquia";
            this.tbx_parroquia.Size = new System.Drawing.Size(302, 20);
            this.tbx_parroquia.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Parroquia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // tbx_codigo
            // 
            this.tbx_codigo.Enabled = false;
            this.tbx_codigo.Location = new System.Drawing.Point(375, 19);
            this.tbx_codigo.Name = "tbx_codigo";
            this.tbx_codigo.Size = new System.Drawing.Size(120, 20);
            this.tbx_codigo.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha Bautizo";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(157, 47);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(338, 20);
            this.dtp_fecha.TabIndex = 35;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(584, 451);
            this.shapeContainer1.TabIndex = 75;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 13;
            this.lineShape1.X2 = 545;
            this.lineShape1.Y1 = 236;
            this.lineShape1.Y2 = 236;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1190, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bautizosTableAdapter
            // 
            this.bautizosTableAdapter.ClearBeforeFill = true;
            // 
            // Bautismos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 502);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bautismos";
            this.Text = "Bautizos";
            this.Load += new System.EventHandler(this.Bautismos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bautizos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_iglesiaDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView dgv_bautizos;
        private System.Windows.Forms.TextBox tbx_parroquia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_eliminapadrino;
        private System.Windows.Forms.Button btn_agregapadrino;
        private System.Windows.Forms.ListBox list_padrinos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_buscarmadre;
        private System.Windows.Forms.TextBox tbx_madre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscarpadre;
        private System.Windows.Forms.TextBox tbx_padre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buscarbautizado;
        private System.Windows.Forms.TextBox tbx_bautizado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscarsacerdote;
        private System.Windows.Forms.TextBox tbx_sacerdote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscarparroquia;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox tbx_codemadre;
        private System.Windows.Forms.TextBox tbx_codepadre;
        private System.Windows.Forms.TextBox tbx_codebautizado;
        private System.Windows.Forms.TextBox tbx_codesacerdote;
        private System.Windows.Forms.TextBox tbx_codeparroquia;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bd_iglesiaDataSet bd_iglesiaDataSet;
        private bd_iglesiaDataSetTableAdapters.bautizosTableAdapter bautizosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechabauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parroquiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sacerdoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bautizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn padreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
    }
}