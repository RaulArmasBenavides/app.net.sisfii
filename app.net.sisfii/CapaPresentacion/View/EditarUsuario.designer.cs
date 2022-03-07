namespace CapaPresentacion
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.userNo = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            this.weak = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.PictureBox();
            this.err1 = new System.Windows.Forms.PictureBox();
            this.ico2 = new System.Windows.Forms.PictureBox();
            this.ico1 = new System.Windows.Forms.PictureBox();
            this.pwd2 = new System.Windows.Forms.TextBox();
            this.pwd1 = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnActualizarDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.userNo);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.weak);
            this.groupBox1.Controls.Add(this.err2);
            this.groupBox1.Controls.Add(this.err1);
            this.groupBox1.Controls.Add(this.ico2);
            this.groupBox1.Controls.Add(this.ico1);
            this.groupBox1.Controls.Add(this.pwd2);
            this.groupBox1.Controls.Add(this.pwd1);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // user
            // 
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(373, 54);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(26, 26);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.user.TabIndex = 13;
            this.user.TabStop = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // userNo
            // 
            this.userNo.Image = ((System.Drawing.Image)(resources.GetObject("userNo.Image")));
            this.userNo.Location = new System.Drawing.Point(373, 54);
            this.userNo.Margin = new System.Windows.Forms.Padding(4);
            this.userNo.Name = "userNo";
            this.userNo.Size = new System.Drawing.Size(26, 26);
            this.userNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userNo.TabIndex = 12;
            this.userNo.TabStop = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(408, 154);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(91, 15);
            this.status.TabIndex = 11;
            this.status.Text = "No coinciden";
            this.status.Visible = false;
            // 
            // weak
            // 
            this.weak.AutoSize = true;
            this.weak.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weak.ForeColor = System.Drawing.Color.Yellow;
            this.weak.Location = new System.Drawing.Point(403, 110);
            this.weak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weak.Name = "weak";
            this.weak.Size = new System.Drawing.Size(116, 15);
            this.weak.TabIndex = 10;
            this.weak.Text = "Contraseña débil";
            this.weak.Visible = false;
            // 
            // err2
            // 
            this.err2.Image = ((System.Drawing.Image)(resources.GetObject("err2.Image")));
            this.err2.Location = new System.Drawing.Point(377, 149);
            this.err2.Margin = new System.Windows.Forms.Padding(4);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(16, 16);
            this.err2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.err2.TabIndex = 9;
            this.err2.TabStop = false;
            this.err2.Visible = false;
            // 
            // err1
            // 
            this.err1.Image = ((System.Drawing.Image)(resources.GetObject("err1.Image")));
            this.err1.Location = new System.Drawing.Point(373, 108);
            this.err1.Margin = new System.Windows.Forms.Padding(4);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(16, 16);
            this.err1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.err1.TabIndex = 8;
            this.err1.TabStop = false;
            this.err1.Visible = false;
            // 
            // ico2
            // 
            this.ico2.Image = ((System.Drawing.Image)(resources.GetObject("ico2.Image")));
            this.ico2.Location = new System.Drawing.Point(373, 149);
            this.ico2.Margin = new System.Windows.Forms.Padding(4);
            this.ico2.Name = "ico2";
            this.ico2.Size = new System.Drawing.Size(19, 20);
            this.ico2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico2.TabIndex = 7;
            this.ico2.TabStop = false;
            // 
            // ico1
            // 
            this.ico1.Image = ((System.Drawing.Image)(resources.GetObject("ico1.Image")));
            this.ico1.Location = new System.Drawing.Point(373, 105);
            this.ico1.Margin = new System.Windows.Forms.Padding(4);
            this.ico1.Name = "ico1";
            this.ico1.Size = new System.Drawing.Size(19, 20);
            this.ico1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ico1.TabIndex = 6;
            this.ico1.TabStop = false;
            // 
            // pwd2
            // 
            this.pwd2.Location = new System.Drawing.Point(185, 149);
            this.pwd2.Margin = new System.Windows.Forms.Padding(4);
            this.pwd2.Name = "pwd2";
            this.pwd2.Size = new System.Drawing.Size(179, 22);
            this.pwd2.TabIndex = 5;
            this.pwd2.UseSystemPasswordChar = true;
            this.pwd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwd2_KeyPress);
            this.pwd2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwd2_KeyUp);
            // 
            // pwd1
            // 
            this.pwd1.Location = new System.Drawing.Point(185, 105);
            this.pwd1.Margin = new System.Windows.Forms.Padding(4);
            this.pwd1.Name = "pwd1";
            this.pwd1.Size = new System.Drawing.Size(179, 22);
            this.pwd1.TabIndex = 4;
            this.pwd1.UseSystemPasswordChar = true;
            this.pwd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pwd1_KeyPress);
            this.pwd1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwd1_KeyUp);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(185, 58);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 22);
            this.txtUser.TabIndex = 3;
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(28, 466);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(976, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(837, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnActualizarDatos);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(604, 30);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(400, 418);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario";
            // 
            // btnActualizarDatos
            // 
            this.btnActualizarDatos.Location = new System.Drawing.Point(36, 355);
            this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarDatos.Name = "btnActualizarDatos";
            this.btnActualizarDatos.Size = new System.Drawing.Size(333, 30);
            this.btnActualizarDatos.TabIndex = 1;
            this.btnActualizarDatos.Text = "Cambiar Foto de Perfil";
            this.btnActualizarDatos.UseVisualStyleBackColor = true;
            this.btnActualizarDatos.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1043, 586);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear/Editar";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ico1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pwd2;
        private System.Windows.Forms.TextBox pwd1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnActualizarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ico2;
        private System.Windows.Forms.PictureBox ico1;
        private System.Windows.Forms.PictureBox err2;
        private System.Windows.Forms.PictureBox err1;
        private System.Windows.Forms.Label weak;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.PictureBox userNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}