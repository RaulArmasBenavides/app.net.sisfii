namespace CapaDatos.View
{
    partial class FrmListaCursos
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
            this.dgvListaCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCursos
            // 
            this.dgvListaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCursos.Location = new System.Drawing.Point(38, 74);
            this.dgvListaCursos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaCursos.Name = "dgvListaCursos";
            this.dgvListaCursos.RowHeadersWidth = 51;
            this.dgvListaCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCursos.Size = new System.Drawing.Size(1127, 395);
            this.dgvListaCursos.TabIndex = 4;
            // 
            // FrmListaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1210, 600);
            this.Controls.Add(this.dgvListaCursos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmListaCursos";
            this.Text = ":: LISTA DE CURSOS OFRECIDOS POR CERSEU ::";
            this.Load += new System.EventHandler(this.FrmListaCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCursos;
    }
}