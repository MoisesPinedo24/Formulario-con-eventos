namespace Formulario_con_eventos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombres = new System.Windows.Forms.TextBox();
            this.ApPaterno = new System.Windows.Forms.TextBox();
            this.ApMaterno = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(351, 99);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(201, 20);
            this.Nombres.TabIndex = 0;
            this.Nombres.Text = "Nombre";
            this.Nombres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ApPaterno
            // 
            this.ApPaterno.Location = new System.Drawing.Point(351, 142);
            this.ApPaterno.Name = "ApPaterno";
            this.ApPaterno.Size = new System.Drawing.Size(201, 20);
            this.ApPaterno.TabIndex = 1;
            this.ApPaterno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ApMaterno
            // 
            this.ApMaterno.Location = new System.Drawing.Point(351, 186);
            this.ApMaterno.Name = "ApMaterno";
            this.ApMaterno.Size = new System.Drawing.Size(201, 20);
            this.ApMaterno.TabIndex = 2;
            this.ApMaterno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Genero
            // 
            this.Genero.FormattingEnabled = true;
            this.Genero.Items.AddRange(new object[] {
            "Hombre ",
            "Mujer",
            "Prefiero no decir"});
            this.Genero.Location = new System.Drawing.Point(351, 233);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(201, 21);
            this.Genero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genero";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(410, 365);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtRegistrar.TabIndex = 10;
            this.BtRegistrar.Text = "Finalizar";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 456);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.ApMaterno);
            this.Controls.Add(this.ApPaterno);
            this.Controls.Add(this.Nombres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox ApPaterno;
        private System.Windows.Forms.TextBox ApMaterno;
        private System.Windows.Forms.ComboBox Genero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtRegistrar;
    }
}

