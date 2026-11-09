using Datos;
using Entidad;
using FontAwesome.Sharp;
using MetroFramework;
using MetroFramework.Forms;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class frmLogin : MetroForm
    {
        private IconPictureBox pbxLogin;
        private MetroFramework.Controls.MetroPanel pnlLineaSuperior;
        private MetroFramework.Controls.MetroPanel pnlLineaInferior;
        private MetroFramework.Controls.MetroLabel lblUsuario;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private IconButton btnIniciarSesion;
        private MetroFramework.Controls.MetroPanel pnlLateral;

        public frmLogin()
        {
            InitializeComponent();
            CargarIconos();
        }

        private void CargarIconos()
        {
            var imgUsuario = IconChar.User.ToBitmap(Color.DodgerBlue, 28);
            var imgPassword = IconChar.Lock.ToBitmap(Color.DodgerBlue, 28);

            txtUsuario.Icon = imgUsuario;
            txtPassword.Icon = imgPassword;
        }

        
        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Ingrese usuario", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Ingrese password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLateral = new MetroFramework.Controls.MetroPanel();
            this.pbxLogin = new FontAwesome.Sharp.IconPictureBox();
            this.pnlLineaSuperior = new MetroFramework.Controls.MetroPanel();
            this.pnlLineaInferior = new MetroFramework.Controls.MetroPanel();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLateral.BackgroundImage")));
            this.pnlLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLateral.HorizontalScrollbarBarColor = true;
            this.pnlLateral.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLateral.HorizontalScrollbarSize = 10;
            this.pnlLateral.Location = new System.Drawing.Point(1, 5);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(479, 494);
            this.pnlLateral.TabIndex = 0;
            this.pnlLateral.VerticalScrollbarBarColor = true;
            this.pnlLateral.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLateral.VerticalScrollbarSize = 10;
            // 
            // pbxLogin
            // 
            this.pbxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pbxLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxLogin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.pbxLogin.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxLogin.IconSize = 161;
            this.pbxLogin.Location = new System.Drawing.Point(549, 39);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(169, 161);
            this.pbxLogin.TabIndex = 1;
            this.pbxLogin.TabStop = false;
            // 
            // pnlLineaSuperior
            // 
            this.pnlLineaSuperior.BackColor = System.Drawing.Color.Gray;
            this.pnlLineaSuperior.HorizontalScrollbarBarColor = true;
            this.pnlLineaSuperior.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLineaSuperior.HorizontalScrollbarSize = 10;
            this.pnlLineaSuperior.Location = new System.Drawing.Point(502, 242);
            this.pnlLineaSuperior.Name = "pnlLineaSuperior";
            this.pnlLineaSuperior.Size = new System.Drawing.Size(275, 1);
            this.pnlLineaSuperior.TabIndex = 2;
            this.pnlLineaSuperior.UseCustomBackColor = true;
            this.pnlLineaSuperior.VerticalScrollbarBarColor = true;
            this.pnlLineaSuperior.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLineaSuperior.VerticalScrollbarSize = 10;
            // 
            // pnlLineaInferior
            // 
            this.pnlLineaInferior.BackColor = System.Drawing.Color.Gray;
            this.pnlLineaInferior.HorizontalScrollbarBarColor = true;
            this.pnlLineaInferior.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlLineaInferior.HorizontalScrollbarSize = 10;
            this.pnlLineaInferior.Location = new System.Drawing.Point(502, 418);
            this.pnlLineaInferior.Name = "pnlLineaInferior";
            this.pnlLineaInferior.Size = new System.Drawing.Size(275, 1);
            this.pnlLineaInferior.TabIndex = 3;
            this.pnlLineaInferior.UseCustomBackColor = true;
            this.pnlLineaInferior.VerticalScrollbarBarColor = true;
            this.pnlLineaInferior.VerticalScrollbarHighlightOnWheel = false;
            this.pnlLineaInferior.VerticalScrollbarSize = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(520, 278);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(518, 331);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.DisplayIcon = true;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(607, 280);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Ingrese usuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(170, 23);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.UseCustomBackColor = true;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Ingrese usuario";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(607, 332);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Ingrese contraseña";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(170, 23);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Ingrese contraseña";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.IconSize = 32;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(502, 377);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(275, 35);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlLineaInferior);
            this.Controls.Add(this.pnlLineaSuperior);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.pnlLateral);
            this.Name = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarUsuario())
                return;

            string strUsuario = txtUsuario.Text.Trim();
            string strPassword = txtPassword.Text.Trim();

            E_Usuarios Usuario = N_Usuario.Login(strUsuario, strPassword);

            if (Usuario != null)
            {
                this.Hide();
                frmPrincipal frm = new frmPrincipal();
                frm.SESION_USUARIO = Usuario;
                frm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario o clave incorrecto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
