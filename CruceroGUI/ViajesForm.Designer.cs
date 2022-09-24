
namespace CruceroGUI
{
    partial class ViajesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCostoViajePremium = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCrucero = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudadPartida = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudadDestino = new System.Windows.Forms.ComboBox();
            this.textBoxDuracionViaje = new System.Windows.Forms.TextBox();
            this.textBoxCostoViajeTurista = new System.Windows.Forms.TextBox();
            this.textBoxCCT = new System.Windows.Forms.TextBox();
            this.textBoxCCP = new System.Windows.Forms.TextBox();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxListaViajes = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCostoViajePremium);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaViaje);
            this.groupBox1.Controls.Add(this.comboBoxCrucero);
            this.groupBox1.Controls.Add(this.comboBoxCiudadPartida);
            this.groupBox1.Controls.Add(this.comboBoxCiudadDestino);
            this.groupBox1.Controls.Add(this.textBoxDuracionViaje);
            this.groupBox1.Controls.Add(this.textBoxCostoViajeTurista);
            this.groupBox1.Controls.Add(this.textBoxCCT);
            this.groupBox1.Controls.Add(this.textBoxCCP);
            this.groupBox1.Controls.Add(this.btnCrearViaje);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear viaje:";
            // 
            // textBoxCostoViajePremium
            // 
            this.textBoxCostoViajePremium.Location = new System.Drawing.Point(620, 132);
            this.textBoxCostoViajePremium.Name = "textBoxCostoViajePremium";
            this.textBoxCostoViajePremium.ReadOnly = true;
            this.textBoxCostoViajePremium.Size = new System.Drawing.Size(125, 27);
            this.textBoxCostoViajePremium.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Costo premium del viaje:";
            // 
            // dateTimePickerFechaViaje
            // 
            this.dateTimePickerFechaViaje.CustomFormat = "dd/MM/yy H:mm";
            this.dateTimePickerFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaViaje.Location = new System.Drawing.Point(20, 151);
            this.dateTimePickerFechaViaje.MinDate = new System.DateTime(2022, 9, 24, 0, 0, 0, 0);
            this.dateTimePickerFechaViaje.Name = "dateTimePickerFechaViaje";
            this.dateTimePickerFechaViaje.Size = new System.Drawing.Size(340, 27);
            this.dateTimePickerFechaViaje.TabIndex = 20;
            this.dateTimePickerFechaViaje.ValueChanged += new System.EventHandler(this.dateTimePickerFechaViaje_ValueChanged);
            // 
            // comboBoxCrucero
            // 
            this.comboBoxCrucero.FormattingEnabled = true;
            this.comboBoxCrucero.Location = new System.Drawing.Point(173, 94);
            this.comboBoxCrucero.Name = "comboBoxCrucero";
            this.comboBoxCrucero.Size = new System.Drawing.Size(187, 28);
            this.comboBoxCrucero.TabIndex = 19;
            this.comboBoxCrucero.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrucero_SelectedIndexChanged);
            // 
            // comboBoxCiudadPartida
            // 
            this.comboBoxCiudadPartida.FormattingEnabled = true;
            this.comboBoxCiudadPartida.Location = new System.Drawing.Point(173, 25);
            this.comboBoxCiudadPartida.Name = "comboBoxCiudadPartida";
            this.comboBoxCiudadPartida.Size = new System.Drawing.Size(187, 28);
            this.comboBoxCiudadPartida.TabIndex = 18;
            // 
            // comboBoxCiudadDestino
            // 
            this.comboBoxCiudadDestino.FormattingEnabled = true;
            this.comboBoxCiudadDestino.Location = new System.Drawing.Point(173, 59);
            this.comboBoxCiudadDestino.Name = "comboBoxCiudadDestino";
            this.comboBoxCiudadDestino.Size = new System.Drawing.Size(187, 28);
            this.comboBoxCiudadDestino.TabIndex = 17;
            this.comboBoxCiudadDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiudadDestino_SelectedIndexChanged);
            // 
            // textBoxDuracionViaje
            // 
            this.textBoxDuracionViaje.Location = new System.Drawing.Point(620, 165);
            this.textBoxDuracionViaje.Name = "textBoxDuracionViaje";
            this.textBoxDuracionViaje.ReadOnly = true;
            this.textBoxDuracionViaje.Size = new System.Drawing.Size(125, 27);
            this.textBoxDuracionViaje.TabIndex = 15;
            // 
            // textBoxCostoViajeTurista
            // 
            this.textBoxCostoViajeTurista.Location = new System.Drawing.Point(620, 99);
            this.textBoxCostoViajeTurista.Name = "textBoxCostoViajeTurista";
            this.textBoxCostoViajeTurista.ReadOnly = true;
            this.textBoxCostoViajeTurista.Size = new System.Drawing.Size(125, 27);
            this.textBoxCostoViajeTurista.TabIndex = 14;
            // 
            // textBoxCCT
            // 
            this.textBoxCCT.Location = new System.Drawing.Point(620, 64);
            this.textBoxCCT.Name = "textBoxCCT";
            this.textBoxCCT.ReadOnly = true;
            this.textBoxCCT.Size = new System.Drawing.Size(125, 27);
            this.textBoxCCT.TabIndex = 13;
            // 
            // textBoxCCP
            // 
            this.textBoxCCP.Location = new System.Drawing.Point(620, 28);
            this.textBoxCCP.Name = "textBoxCCP";
            this.textBoxCCP.ReadOnly = true;
            this.textBoxCCP.Size = new System.Drawing.Size(125, 27);
            this.textBoxCCP.TabIndex = 12;
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Location = new System.Drawing.Point(773, 69);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(84, 53);
            this.btnCrearViaje.TabIndex = 8;
            this.btnCrearViaje.Text = "Crear viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Duracion del viaje (Horas):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Costo turista del viaje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad de camarotes turista:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de camarotes premium:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha y hora de inicio del viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crucero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad de destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de partida:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxListaViajes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(25, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista viajes:";
            // 
            // listBoxListaViajes
            // 
            this.listBoxListaViajes.FormattingEnabled = true;
            this.listBoxListaViajes.ItemHeight = 20;
            this.listBoxListaViajes.Location = new System.Drawing.Point(8, 46);
            this.listBoxListaViajes.Name = "listBoxListaViajes";
            this.listBoxListaViajes.Size = new System.Drawing.Size(1170, 144);
            this.listBoxListaViajes.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(960, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ciudad de partida        | Ciudad de destino           | Crucero                 " +
    "              | Fecha y hora de partida | CCP | CCT | CP           | CT         " +
    "   | D |";
            // 
            // ViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViajesForm";
            this.Text = "Viajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDuracionViaje;
        private System.Windows.Forms.TextBox textBoxCostoViajeTurista;
        private System.Windows.Forms.TextBox textBoxCCT;
        private System.Windows.Forms.TextBox textBoxCCP;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxListaViajes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblCCT;
        private System.Windows.Forms.Label lblCCP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxCrucero;
        private System.Windows.Forms.ComboBox comboBoxCiudadPartida;
        private System.Windows.Forms.ComboBox comboBoxCiudadDestino;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaViaje;
        private System.Windows.Forms.TextBox textBoxCostoViajePremium;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblT;
    }
}