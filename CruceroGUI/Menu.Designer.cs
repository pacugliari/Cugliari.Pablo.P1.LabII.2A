
namespace CruceroGUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtInformacionVendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInformesHistoricos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnVentaViajes = new System.Windows.Forms.Button();
            this.btnViajes = new System.Windows.Forms.Button();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInformacionVendedor
            // 
            this.txtInformacionVendedor.AutoSize = true;
            this.txtInformacionVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInformacionVendedor.Location = new System.Drawing.Point(18, 35);
            this.txtInformacionVendedor.Name = "txtInformacionVendedor";
            this.txtInformacionVendedor.Size = new System.Drawing.Size(51, 20);
            this.txtInformacionVendedor.TabIndex = 0;
            this.txtInformacionVendedor.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblAyuda);
            this.groupBox1.Controls.Add(this.txtInformacionVendedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInformesHistoricos);
            this.groupBox2.Controls.Add(this.btnInformes);
            this.groupBox2.Controls.Add(this.btnVentaViajes);
            this.groupBox2.Controls.Add(this.btnViajes);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu:";
            // 
            // btnInformesHistoricos
            // 
            this.btnInformesHistoricos.Location = new System.Drawing.Point(52, 174);
            this.btnInformesHistoricos.Name = "btnInformesHistoricos";
            this.btnInformesHistoricos.Size = new System.Drawing.Size(145, 29);
            this.btnInformesHistoricos.TabIndex = 3;
            this.btnInformesHistoricos.Text = "Informes historicos";
            this.btnInformesHistoricos.UseVisualStyleBackColor = true;
            this.btnInformesHistoricos.Click += new System.EventHandler(this.btnInformesHistoricos_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(52, 130);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(145, 29);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnVentaViajes
            // 
            this.btnVentaViajes.Location = new System.Drawing.Point(52, 86);
            this.btnVentaViajes.Name = "btnVentaViajes";
            this.btnVentaViajes.Size = new System.Drawing.Size(145, 29);
            this.btnVentaViajes.TabIndex = 1;
            this.btnVentaViajes.Text = "Venta de viajes";
            this.btnVentaViajes.UseVisualStyleBackColor = true;
            this.btnVentaViajes.Click += new System.EventHandler(this.btnVentaViajes_Click);
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(52, 41);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(145, 29);
            this.btnViajes.TabIndex = 0;
            this.btnViajes.Text = "Alta viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // lblAyuda
            // 
            this.lblAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.Color.Transparent;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAyuda.Image = ((System.Drawing.Image)(resources.GetObject("lblAyuda.Image")));
            this.lblAyuda.Location = new System.Drawing.Point(215, 15);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(29, 45);
            this.lblAyuda.TabIndex = 11;
            this.lblAyuda.Text = " ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(304, 481);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtInformacionVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnVentaViajes;
        private System.Windows.Forms.Button btnInformesHistoricos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Label lblAyuda;
    }
}