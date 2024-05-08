namespace Integrador_1
{
    partial class Crear_cuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.TNDocu = new System.Windows.Forms.TextBox();
            this.ComboDocu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TNombrePila = new System.Windows.Forms.TextBox();
            this.TApe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TCalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TCNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TPiso = new System.Windows.Forms.TextBox();
            this.TDepto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.FNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNRegistrarme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // TNDocu
            // 
            this.TNDocu.Location = new System.Drawing.Point(12, 89);
            this.TNDocu.Name = "TNDocu";
            this.TNDocu.Size = new System.Drawing.Size(197, 20);
            this.TNDocu.TabIndex = 1;
            // 
            // ComboDocu
            // 
            this.ComboDocu.FormattingEnabled = true;
            this.ComboDocu.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.ComboDocu.Location = new System.Drawing.Point(12, 39);
            this.ComboDocu.Name = "ComboDocu";
            this.ComboDocu.Size = new System.Drawing.Size(197, 21);
            this.ComboDocu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero";
            // 
            // TNombrePila
            // 
            this.TNombrePila.Location = new System.Drawing.Point(10, 142);
            this.TNombrePila.Name = "TNombrePila";
            this.TNombrePila.Size = new System.Drawing.Size(199, 20);
            this.TNombrePila.TabIndex = 5;
            // 
            // TApe
            // 
            this.TApe.Location = new System.Drawing.Point(10, 196);
            this.TApe.Name = "TApe";
            this.TApe.Size = new System.Drawing.Size(198, 20);
            this.TApe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calle";
            // 
            // TCalle
            // 
            this.TCalle.Location = new System.Drawing.Point(9, 339);
            this.TCalle.Name = "TCalle";
            this.TCalle.Size = new System.Drawing.Size(147, 20);
            this.TCalle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero";
            // 
            // TCNumero
            // 
            this.TCNumero.Location = new System.Drawing.Point(162, 339);
            this.TCNumero.Name = "TCNumero";
            this.TCNumero.Size = new System.Drawing.Size(46, 20);
            this.TCNumero.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Piso";
            // 
            // TPiso
            // 
            this.TPiso.Location = new System.Drawing.Point(9, 386);
            this.TPiso.Name = "TPiso";
            this.TPiso.Size = new System.Drawing.Size(45, 20);
            this.TPiso.TabIndex = 12;
            // 
            // TDepto
            // 
            this.TDepto.Location = new System.Drawing.Point(61, 386);
            this.TDepto.Name = "TDepto";
            this.TDepto.Size = new System.Drawing.Size(147, 20);
            this.TDepto.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de cliente";
            // 
            // ComboCliente
            // 
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Items.AddRange(new object[] {
            "RSocial",
            "Unipersonal"});
            this.ComboCliente.Location = new System.Drawing.Point(9, 299);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(199, 21);
            this.ComboCliente.TabIndex = 16;
            // 
            // FNacimiento
            // 
            this.FNacimiento.Location = new System.Drawing.Point(9, 249);
            this.FNacimiento.Name = "FNacimiento";
            this.FNacimiento.Size = new System.Drawing.Size(200, 20);
            this.FNacimiento.TabIndex = 18;
            this.FNacimiento.ValueChanged += new System.EventHandler(this.FNacimiento_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de nacimiento";
            // 
            // BTNRegistrarme
            // 
            this.BTNRegistrarme.Location = new System.Drawing.Point(10, 426);
            this.BTNRegistrarme.Name = "BTNRegistrarme";
            this.BTNRegistrarme.Size = new System.Drawing.Size(88, 30);
            this.BTNRegistrarme.TabIndex = 20;
            this.BTNRegistrarme.Text = "Regirstrarme";
            this.BTNRegistrarme.UseVisualStyleBackColor = true;
            this.BTNRegistrarme.Click += new System.EventHandler(this.BTNRegistrarme_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crear_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(215, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNRegistrarme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FNacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TDepto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TPiso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TCNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TCalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TApe);
            this.Controls.Add(this.TNombrePila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboDocu);
            this.Controls.Add(this.TNDocu);
            this.Controls.Add(this.label1);
            this.Name = "Crear_cuenta";
            this.Text = "Crear_cuenta";
            this.Load += new System.EventHandler(this.Crear_cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNDocu;
        private System.Windows.Forms.ComboBox ComboDocu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TNombrePila;
        private System.Windows.Forms.TextBox TApe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TCalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TCNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TPiso;
        private System.Windows.Forms.TextBox TDepto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.DateTimePicker FNacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTNRegistrarme;
        private System.Windows.Forms.Button button1;
    }
}