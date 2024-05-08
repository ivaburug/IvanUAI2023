namespace Integrador_1
{
    partial class Usu_Contra
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
            this.TContra1 = new System.Windows.Forms.TextBox();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TContra2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TContra1
            // 
            this.TContra1.Location = new System.Drawing.Point(12, 105);
            this.TContra1.Multiline = true;
            this.TContra1.Name = "TContra1";
            this.TContra1.PasswordChar = '*';
            this.TContra1.Size = new System.Drawing.Size(244, 26);
            this.TContra1.TabIndex = 9;
            this.TContra1.UseSystemPasswordChar = true;
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(12, 44);
            this.TUsuario.Multiline = true;
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(244, 27);
            this.TUsuario.TabIndex = 8;
            this.TUsuario.TextChanged += new System.EventHandler(this.TUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de Usuario";
            // 
            // TContra2
            // 
            this.TContra2.Location = new System.Drawing.Point(12, 169);
            this.TContra2.Multiline = true;
            this.TContra2.Name = "TContra2";
            this.TContra2.PasswordChar = '*';
            this.TContra2.Size = new System.Drawing.Size(244, 26);
            this.TContra2.TabIndex = 11;
            this.TContra2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repetir Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Usu_Contra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(268, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TContra2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TContra1);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Usu_Contra";
            this.Text = "Usu_Contra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TContra1;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TContra2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}