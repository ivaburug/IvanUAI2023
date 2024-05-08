namespace Integrador_1
{
    partial class Cargar_Empleado
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
            this.label4 = new System.Windows.Forms.Label();
            this.TApe = new System.Windows.Forms.TextBox();
            this.TNombrePila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboDocu = new System.Windows.Forms.ComboBox();
            this.TNDocu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tlegajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TACargoD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tarea = new System.Windows.Forms.TextBox();
            this.FIngreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // TApe
            // 
            this.TApe.Location = new System.Drawing.Point(11, 183);
            this.TApe.Name = "TApe";
            this.TApe.Size = new System.Drawing.Size(198, 20);
            this.TApe.TabIndex = 14;
            // 
            // TNombrePila
            // 
            this.TNombrePila.Location = new System.Drawing.Point(10, 129);
            this.TNombrePila.Name = "TNombrePila";
            this.TNombrePila.Size = new System.Drawing.Size(199, 20);
            this.TNombrePila.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de documento";
            // 
            // ComboDocu
            // 
            this.ComboDocu.FormattingEnabled = true;
            this.ComboDocu.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.ComboDocu.Location = new System.Drawing.Point(12, 26);
            this.ComboDocu.Name = "ComboDocu";
            this.ComboDocu.Size = new System.Drawing.Size(197, 21);
            this.ComboDocu.TabIndex = 10;
            // 
            // TNDocu
            // 
            this.TNDocu.Location = new System.Drawing.Point(12, 76);
            this.TNDocu.Name = "TNDocu";
            this.TNDocu.Size = new System.Drawing.Size(197, 20);
            this.TNDocu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Legajo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tlegajo
            // 
            this.Tlegajo.Location = new System.Drawing.Point(10, 239);
            this.Tlegajo.Name = "Tlegajo";
            this.Tlegajo.Size = new System.Drawing.Size(198, 20);
            this.Tlegajo.TabIndex = 16;
            this.Tlegajo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "A Cargo de";
            // 
            // TACargoD
            // 
            this.TACargoD.Location = new System.Drawing.Point(10, 294);
            this.TACargoD.Name = "TACargoD";
            this.TACargoD.Size = new System.Drawing.Size(198, 20);
            this.TACargoD.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 338);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Area";
            // 
            // Tarea
            // 
            this.Tarea.Location = new System.Drawing.Point(10, 354);
            this.Tarea.Name = "Tarea";
            this.Tarea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tarea.Size = new System.Drawing.Size(198, 20);
            this.Tarea.TabIndex = 20;
            // 
            // FIngreso
            // 
            this.FIngreso.Location = new System.Drawing.Point(9, 409);
            this.FIngreso.Name = "FIngreso";
            this.FIngreso.Size = new System.Drawing.Size(199, 20);
            this.FIngreso.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 393);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fecha de Ingreso";
            // 
            // BTNCargar
            // 
            this.BTNCargar.Location = new System.Drawing.Point(9, 457);
            this.BTNCargar.Name = "BTNCargar";
            this.BTNCargar.Size = new System.Drawing.Size(199, 34);
            this.BTNCargar.TabIndex = 24;
            this.BTNCargar.Text = "Cargar";
            this.BTNCargar.UseVisualStyleBackColor = true;
            this.BTNCargar.Click += new System.EventHandler(this.BTNCargar_Click);
            // 
            // Cargar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(220, 502);
            this.Controls.Add(this.BTNCargar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FIngreso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tarea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TACargoD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tlegajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TApe);
            this.Controls.Add(this.TNombrePila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboDocu);
            this.Controls.Add(this.TNDocu);
            this.Controls.Add(this.label1);
            this.Name = "Cargar_Empleado";
            this.Text = "Cargar_Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TApe;
        private System.Windows.Forms.TextBox TNombrePila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboDocu;
        private System.Windows.Forms.TextBox TNDocu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tlegajo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TACargoD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tarea;
        private System.Windows.Forms.DateTimePicker FIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNCargar;
    }
}