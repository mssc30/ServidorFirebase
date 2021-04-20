namespace ServidorFirebase
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
            this.btnPeticion = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPeticion
            // 
            this.btnPeticion.Location = new System.Drawing.Point(83, 142);
            this.btnPeticion.Name = "btnPeticion";
            this.btnPeticion.Size = new System.Drawing.Size(159, 29);
            this.btnPeticion.TabIndex = 0;
            this.btnPeticion.Text = "Enviar";
            this.btnPeticion.UseVisualStyleBackColor = true;
            this.btnPeticion.Click += new System.EventHandler(this.btnPeticion_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(83, 18);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(159, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(44, 21);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuerpo";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(83, 53);
            this.txtCuerpo.Multiline = true;
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(159, 74);
            this.txtCuerpo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCuerpo);
            this.groupBox1.Controls.Add(this.Titulo);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.btnPeticion);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 185);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar Notificación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 239);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Firebase Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPeticion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

