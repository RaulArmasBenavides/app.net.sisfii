namespace CapaPresentacion.View.CERSEU
{
    partial class FrmCursosCERSEU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursosCERSEU));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtidCurso = new System.Windows.Forms.TextBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.LblLimpiar = new System.Windows.Forms.PictureBox();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProgramas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 129);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(420, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(721, 121);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnExcel
            // 
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = global::CapaPresentacion.Properties.Resources.excel_pequeno;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(511, 23);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(97, 74);
            this.btnExcel.TabIndex = 53;
            this.btnExcel.Text = "A Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(616, 23);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 74);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(411, 23);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 74);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(311, 23);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 74);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(211, 23);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 74);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtidCurso
            // 
            this.txtidCurso.Location = new System.Drawing.Point(117, 103);
            this.txtidCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidCurso.Name = "txtidCurso";
            this.txtidCurso.Size = new System.Drawing.Size(220, 22);
            this.txtidCurso.TabIndex = 9;
            this.txtidCurso.Visible = false;
            this.txtidCurso.TextChanged += new System.EventHandler(this.txtidCurso_TextChanged);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(420, 25);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(721, 334);
            this.dgvCursos.TabIndex = 10;
            this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.ErrorImage = null;
            this.LblLimpiar.Image = global::CapaPresentacion.Properties.Resources.Clean_2;
            this.LblLimpiar.Location = new System.Drawing.Point(376, 98);
            this.LblLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(24, 24);
            this.LblLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblLimpiar.TabIndex = 50;
            this.LblLimpiar.TabStop = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click_1);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(344, 98);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 24);
            this.LblBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblBuscar.TabIndex = 49;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nombre";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cboProgramas
            // 
            this.cboProgramas.FormattingEnabled = true;
            this.cboProgramas.Items.AddRange(new object[] {
            "(TODOS)",
            "Tecnología e Informática ( Cursos Libres)",
            "Cursos de Gestión y Especializaciones",
            "Moda y Confección Textil"});
            this.cboProgramas.Location = new System.Drawing.Point(117, 27);
            this.cboProgramas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProgramas.Name = "cboProgramas";
            this.cboProgramas.Size = new System.Drawing.Size(283, 24);
            this.cboProgramas.TabIndex = 10018;
            this.cboProgramas.SelectedIndexChanged += new System.EventHandler(this.cboProgramas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 10019;
            this.label7.Text = "Programas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "",
            "Tecnología e Informática ( Cursos Libres)",
            "Cursos de Gestión y Especializaciones",
            "Moda y Confección Textil"});
            this.cboTipo.Location = new System.Drawing.Point(117, 156);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(220, 24);
            this.cboTipo.TabIndex = 10020;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10021;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmCursosCERSEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1187, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboProgramas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.txtidCurso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCursosCERSEU";
            this.Text = ":: CURSOS CERSEU ::";
            this.Load += new System.EventHandler(this.FrmCursosCERSEU_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtidCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox LblLimpiar;
        private System.Windows.Forms.PictureBox LblBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProgramas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label2;
    }
}