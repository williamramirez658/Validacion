namespace EjValidacionExp
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
            this.components = new System.ComponentModel.Container();
            this.btnValPas = new System.Windows.Forms.Button();
            this.btnvalidacion = new System.Windows.Forms.Button();
            this.paswordIn = new System.Windows.Forms.TextBox();
            this.correoIn = new System.Windows.Forms.TextBox();
            this.codigoIn = new System.Windows.Forms.TextBox();
            this.nombreIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorM = new System.Windows.Forms.ErrorProvider(this.components);
            this.salida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValPas
            // 
            this.btnValPas.BackColor = System.Drawing.Color.LightCyan;
            this.btnValPas.Location = new System.Drawing.Point(245, 141);
            this.btnValPas.Name = "btnValPas";
            this.btnValPas.Size = new System.Drawing.Size(98, 31);
            this.btnValPas.TabIndex = 12;
            this.btnValPas.Text = "Validar Pasword";
            this.btnValPas.UseVisualStyleBackColor = false;
            this.btnValPas.Click += new System.EventHandler(this.btnValPas_Click_1);
            // 
            // btnvalidacion
            // 
            this.btnvalidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnvalidacion.Location = new System.Drawing.Point(245, 77);
            this.btnvalidacion.Name = "btnvalidacion";
            this.btnvalidacion.Size = new System.Drawing.Size(98, 33);
            this.btnvalidacion.TabIndex = 13;
            this.btnvalidacion.Text = "Validar";
            this.btnvalidacion.UseVisualStyleBackColor = false;
            this.btnvalidacion.Click += new System.EventHandler(this.btnvalidacion_Click);
            // 
            // paswordIn
            // 
            this.paswordIn.BackColor = System.Drawing.Color.Snow;
            this.paswordIn.Location = new System.Drawing.Point(95, 152);
            this.paswordIn.Name = "paswordIn";
            this.paswordIn.PasswordChar = '*';
            this.paswordIn.Size = new System.Drawing.Size(100, 20);
            this.paswordIn.TabIndex = 8;
            // 
            // correoIn
            // 
            this.correoIn.BackColor = System.Drawing.Color.Ivory;
            this.correoIn.Location = new System.Drawing.Point(95, 111);
            this.correoIn.Name = "correoIn";
            this.correoIn.Size = new System.Drawing.Size(100, 20);
            this.correoIn.TabIndex = 9;
            // 
            // codigoIn
            // 
            this.codigoIn.BackColor = System.Drawing.Color.Ivory;
            this.codigoIn.Location = new System.Drawing.Point(95, 70);
            this.codigoIn.Name = "codigoIn";
            this.codigoIn.Size = new System.Drawing.Size(100, 20);
            this.codigoIn.TabIndex = 10;
            // 
            // nombreIn
            // 
            this.nombreIn.BackColor = System.Drawing.Color.Ivory;
            this.nombreIn.Location = new System.Drawing.Point(95, 29);
            this.nombreIn.Name = "nombreIn";
            this.nombreIn.Size = new System.Drawing.Size(100, 20);
            this.nombreIn.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pasword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // errorM
            // 
            this.errorM.ContainerControl = this;
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.Location = new System.Drawing.Point(242, 18);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(0, 13);
            this.salida.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 271);
            this.Controls.Add(this.btnValPas);
            this.Controls.Add(this.btnvalidacion);
            this.Controls.Add(this.paswordIn);
            this.Controls.Add(this.correoIn);
            this.Controls.Add(this.codigoIn);
            this.Controls.Add(this.nombreIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salida);
            this.Name = "Form1";
            this.Text = "Validacion - Expresiones Regulares";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValPas;
        private System.Windows.Forms.Button btnvalidacion;
        private System.Windows.Forms.TextBox paswordIn;
        private System.Windows.Forms.TextBox correoIn;
        private System.Windows.Forms.TextBox codigoIn;
        private System.Windows.Forms.TextBox nombreIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorM;
        private System.Windows.Forms.Label salida;
    }
}

