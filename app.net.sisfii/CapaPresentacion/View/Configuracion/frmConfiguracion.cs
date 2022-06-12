using CapaDatos.DataBase;
using CapaPresentacion.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;


namespace CapaPresentacion.View.Configuracion
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void txtConectar_Click(object sender, EventArgs e)
        {

            if (txtBaseDatos.Text != string.Empty && txtServidor.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                AccesoDB acconexion = new AccesoDB();
                string sFileName = @"C:\datos\feedback.ini";
                acconexion.Database = txtBaseDatos.Text;
                acconexion.Pwd = txtPassword.Text;
                acconexion.Server = txtServidor.Text;
                acconexion.user = txtUsuario.Text;

                string cadena = "Server=" + acconexion.Server + ";Database=" + acconexion.Database + "; User Id=" + acconexion.user + ";Password=" + acconexion.Pwd;

                acconexion.cadenadesencriptada = cadena;

                if (acconexion.conexion())
                {
                    File.Delete(sFileName);
                    if (checkPredeterminado.Checked)
                    {
                        acconexion.creararchivo();
                    }
                    lblEstado.ForeColor = System.Drawing.Color.DarkGreen;
                    lblEstado.Text = "Conexión estable";
                    Login login = new Login();
                    login.Show();
                    Hide();
                }
                else if (acconexion.conexion() == false)
                {
                    lblEstado.ForeColor = System.Drawing.Color.DarkRed;
                    lblEstado.Text = "Conexión no establecida";
                }
            }
            else
            {
                lblEstado.ForeColor = System.Drawing.Color.DarkRed;
                lblEstado.Text = "Rellene los campos correspondientes!!";
                txtServidor.Focus();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            AccesoDB conexion = new AccesoDB();
            if (txtBaseDatos.Text == string.Empty)
            {
                txtBaseDatos.Focus();
            }
            else
            {

                string cadena = "Server=" + txtServidor.Text + ";Database=" + txtBaseDatos.Text + "; User Id=" + txtUsuario.Text + ";Password=" + txtPassword.Text;
                conexion.cadenadesencriptada = cadena;
                if (conexion.conexion())
                {
                    lblEstado.ForeColor = System.Drawing.Color.DarkGreen;
                    lblEstado.Text = "Conexión estable";
                }
                else if (conexion.conexion() == false)
                {
                    lblEstado.ForeColor = System.Drawing.Color.DarkRed;
                    lblEstado.Text = "Conexión no establecida";
                }
            }
        }

        public void reemplazarFile()
        {

        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            checkPredeterminado.Checked = true;
            string sFileName = @"C:\datos\feedback.ini";
            if (File.Exists(sFileName))
            {
                StreamReader ar = new StreamReader(sFileName);
                string linea = ar.ReadLine();
                ar.Close();
                string[] cadenas = { };
                ClsInicio inicio = new ClsInicio();
                cadenas = inicio.datosBaseDatos().Split('=', ';');
                AccesoDB conexion = new AccesoDB();
                conexion.Database = cadenas[3];
                conexion.Pwd = cadenas[7];
                conexion.Server = cadenas[1];
                conexion.user = cadenas[5];
                string cadena = "Server=" + conexion.Server + ";Database=" + conexion.Database + "; User Id=" + conexion.user + ";Password=" + conexion.Pwd;
                conexion.cadenadesencriptada = cadena;
                conexion.cadenadesencriptada = Helper.Desencriptar(cadena);
                if (conexion.conexion())
                {
                    Login login = new Login();//Aquí de repente tenemos que cambiar algo 
                    Login.Show();
                    Hide();
                }
                else if (conexion.conexion() == false)
                {
                    lblEstado.ForeColor = System.Drawing.Color.DarkRed;
                    lblEstado.Text = "Conexión no establecida";
                }

            }
        }

        private void btnGenerarFile_Click(object sender, EventArgs e)
        {

            if (txtBaseDatos.Text != string.Empty && txtServidor.Text != string.Empty && txtUsuario.Text != string.Empty)
            {
                string Name = txtFileName.Text.Trim();
                string sFileName = @"C:\datos\" + Name + ".ini";
                if (Name == String.Empty)
                {
                    lblMostrarEstadoArchivo.ForeColor = System.Drawing.Color.DarkRed;
                    lblMostrarEstadoArchivo.Text = "Establezca un nombre *.ini";
                }
                else
                {



                    if (File.Exists(sFileName) || sFileName == Name + ".ini")
                    {
                        MessageBox.Show("Archivo Existente");
                    }
                    else
                    {
                        ClsConexion conexion = new ClsConexion();
                        conexion.bd = txtBaseDatos.Text;
                        conexion.pass = txtPassword.Text;
                        conexion.servidor = txtServidor.Text;
                        conexion.user = txtUsuario.Text;
                        string cadena = "Server=" + conexion.servidor + ";Database=" + conexion.bd + "; User Id=" + conexion.user + ";Password=" + conexion.pass;

                        conexion.cadenadesencriptada = cadena;

                        if (conexion.conexion())
                        {
                            //File.Delete(sFileName);


                            conexion.crearArchivoConNombre(Name);
                            lblMostrarEstadoArchivo.ForeColor = System.Drawing.Color.DarkGreen;
                            //lblEstado.ForeColor = System.Drawing.Color.DarkGreen;
                            lblMostrarEstadoArchivo.Text = "Archivo Creado Correctamente!!";
                            LimpiarCajas();
                            //lblEstado.Text = "Conexión estable";



                            //frmLogin login = new frmLogin();
                            //login.Show();
                            //Hide();
                        }
                        else if (conexion.conexion() == false)
                        {
                            lblMostrarEstadoArchivo.ForeColor = System.Drawing.Color.DarkRed;
                            lblMostrarEstadoArchivo.Text = "Conexión No Establecida - Archivo No Creado";
                            txtBaseDatos.Focus();
                            //lblEstado.ForeColor = System.Drawing.Color.DarkGreen;
                            //lblEstado.ForeColor = System.Drawing.Color.DarkRed;
                            //lblEstado.Text = "Conexión no establecida";
                        }
                    }
                }
            }
            else
            {
                lblMostrarEstadoArchivo.ForeColor = System.Drawing.Color.DarkRed;
                lblMostrarEstadoArchivo.Text = "Rellene los campos";
            }

        }


        public void LimpiarCajas()
        {
            txtBaseDatos.Text = "";
            txtFileName.Text = "";
            txtPassword.Text = "";
            txtServidor.Text = "";
            txtUsuario.Text = "";

        }

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Files *.ini (*.ini)|*.ini";//|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string DirectoryName = openFileDialog1.FileName;
                        lblDirectorio.Text = DirectoryName;
                        StreamReader reader = new StreamReader(@"" + DirectoryName);
                        AccesoDB conexion = new AccesoDB();
                        //ClsDatos dat = new ClsDatos();
                        //conexion.cadenadesencriptada = reader.ReadToEnd();

                        string file = reader.ReadToEnd();
                        string[] cadenas = { };

                        string cadena = Helper.Desencriptar(file);
                        cadenas = cadena.Split('=', ';');
                        txtServidor.Text = cadenas[1];
                        txtBaseDatos.Text = cadenas[3];
                        txtUsuario.Text = cadenas[5];
                        txtPassword.Text = cadenas[7];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        } 
    }
}
