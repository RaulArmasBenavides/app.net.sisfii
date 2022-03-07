namespace CapaPresentacion.View
{
    partial class FrmOrganizadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrganizadores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvOrganizadores = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cboDNI = new System.Windows.Forms.ComboBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.LblApellido = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtidListaAsistencias = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.LblLimpiar = new System.Windows.Forms.PictureBox();
            this.LblBuscar = new System.Windows.Forms.PictureBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizadores)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de organizadores del evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // dgvOrganizadores
            // 
            this.dgvOrganizadores.AllowUserToAddRows = false;
            this.dgvOrganizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizadores.Location = new System.Drawing.Point(34, 146);
            this.dgvOrganizadores.Name = "dgvOrganizadores";
            this.dgvOrganizadores.RowHeadersWidth = 51;
            this.dgvOrganizadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizadores.Size = new System.Drawing.Size(492, 213);
            this.dgvOrganizadores.TabIndex = 5;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(317, 38);
            this.Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 9;
            this.Estado.Text = "Estado";
            this.Estado.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(361, 37);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(76, 20);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.Visible = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtnombre);
            this.GroupBox2.Controls.Add(this.cboDNI);
            this.GroupBox2.Controls.Add(this.LblDNI);
            this.GroupBox2.Controls.Add(this.txtappaterno);
            this.GroupBox2.Controls.Add(this.txtapmaterno);
            this.GroupBox2.Controls.Add(this.LblApellido);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(34, 53);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(524, 76);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Datos de los Organizadores";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(356, 41);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(153, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboDNI
            // 
            this.cboDNI.BackColor = System.Drawing.SystemColors.Info;
            this.cboDNI.Location = new System.Drawing.Point(16, 40);
            this.cboDNI.Name = "cboDNI";
            this.cboDNI.Size = new System.Drawing.Size(86, 21);
            this.cboDNI.TabIndex = 2;
            this.cboDNI.SelectedIndexChanged += new System.EventHandler(this.cboDNI_SelectedIndexChanged);
            this.cboDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDNI_KeyPress);
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(47, 23);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(26, 13);
            this.LblDNI.TabIndex = 2;
            this.LblDNI.Text = "DNI";
            // 
            // txtappaterno
            // 
            this.txtappaterno.BackColor = System.Drawing.SystemColors.Info;
            this.txtappaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtappaterno.Enabled = false;
            this.txtappaterno.Location = new System.Drawing.Point(106, 41);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.ReadOnly = true;
            this.txtappaterno.Size = new System.Drawing.Size(125, 20);
            this.txtappaterno.TabIndex = 0;
            this.txtappaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.BackColor = System.Drawing.SystemColors.Info;
            this.txtapmaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapmaterno.Enabled = false;
            this.txtapmaterno.Location = new System.Drawing.Point(237, 41);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.ReadOnly = true;
            this.txtapmaterno.Size = new System.Drawing.Size(113, 20);
            this.txtapmaterno.TabIndex = 1;
            this.txtapmaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(118, 23);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(83, 13);
            this.LblApellido.TabIndex = 1;
            this.LblApellido.Text = "Apellido paterno";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(255, 23);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 13);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Apellido Materno";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(406, 24);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 13);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Nombre";
            // 
            // txtidListaAsistencias
            // 
            this.txtidListaAsistencias.Enabled = false;
            this.txtidListaAsistencias.Location = new System.Drawing.Point(585, 10);
            this.txtidListaAsistencias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidListaAsistencias.Name = "txtidListaAsistencias";
            this.txtidListaAsistencias.Size = new System.Drawing.Size(76, 20);
            this.txtidListaAsistencias.TabIndex = 36;
            this.txtidListaAsistencias.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVolver.Location = new System.Drawing.Point(585, 321);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 38);
            this.btnVolver.TabIndex = 58;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(585, 155);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 32);
            this.btnAnular.TabIndex = 55;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(585, 112);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 37);
            this.btnActualizar.TabIndex = 54;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Image = global::CapaPresentacion.Properties.Resources.excel_pequeno;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(585, 193);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 59);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.Text = "A Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // LblLimpiar
            // 
            this.LblLimpiar.ErrorImage = null;
            this.LblLimpiar.Image = global::CapaPresentacion.Properties.Resources.Clean_2;
            this.LblLimpiar.Location = new System.Drawing.Point(179, 35);
            this.LblLimpiar.Name = "LblLimpiar";
            this.LblLimpiar.Size = new System.Drawing.Size(24, 24);
            this.LblLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblLimpiar.TabIndex = 35;
            this.LblLimpiar.TabStop = false;
            this.LblLimpiar.Click += new System.EventHandler(this.LblLimpiar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("LblBuscar.Image")));
            this.LblBuscar.Location = new System.Drawing.Point(155, 36);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(24, 24);
            this.LblBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LblBuscar.TabIndex = 34;
            this.LblBuscar.TabStop = false;
            this.LblBuscar.Click += new System.EventHandler(this.LblBuscar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.Save_as;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGrabar.Location = new System.Drawing.Point(585, 75);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(78, 32);
            this.btnGrabar.TabIndex = 10;
            this.btnGrabar.Text = "Grabar ";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(585, 258);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 57);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(532, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(26, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(532, 146);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(26, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmOrganizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(694, 436);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtidListaAsistencias);
            this.Controls.Add(this.LblLimpiar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvOrganizadores);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmOrganizadores";
            this.Text = ":: LISTA DE ORGANIZADORES::";
            this.Load += new System.EventHandler(this.FrmAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizadores)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtnombre;
        internal System.Windows.Forms.ComboBox cboDNI;
        internal System.Windows.Forms.Label LblDNI;
        internal System.Windows.Forms.TextBox txtappaterno;
        internal System.Windows.Forms.TextBox txtapmaterno;
        internal System.Windows.Forms.Label LblApellido;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.PictureBox LblLimpiar;
        private System.Windows.Forms.PictureBox LblBuscar;
        internal System.Windows.Forms.TextBox txtidListaAsistencias;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.DataGridView dgvOrganizadores;
    }
}