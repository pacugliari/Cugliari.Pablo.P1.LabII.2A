
namespace CruceroGUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ckbVer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(74, 133);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(181, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(74, 178);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(86, 20);
            this.lblContrasenia.TabIndex = 2;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasenia.Location = new System.Drawing.Point(181, 175);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(125, 27);
            this.txtContrasenia.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.Location = new System.Drawing.Point(120, 227);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(142, 29);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(134, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(143, 28);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Aida Cruceros";
            // 
            // ckbVer
            // 
            this.ckbVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbVer.AutoSize = true;
            this.ckbVer.Location = new System.Drawing.Point(321, 178);
            this.ckbVer.Name = "ckbVer";
            this.ckbVer.Size = new System.Drawing.Size(51, 24);
            this.ckbVer.TabIndex = 7;
            this.ckbVer.Text = "ver";
            this.ckbVer.UseVisualStyleBackColor = true;
            this.ckbVer.CheckedChanged += new System.EventHandler(this.ckbVer_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(417, 333);
            this.Controls.Add(this.ckbVer);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(418, 380);
            this.Name = "Login";
            this.Text = "Aida Cruceros";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox ckbVer;
    }
}

