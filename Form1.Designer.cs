namespace loggin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(182, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(173, 92);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(64, 13);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(158, 60);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(90, 20);
            this.txbUsuario.TabIndex = 2;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(158, 108);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(90, 20);
            this.txbContraseña.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(171, 149);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(66, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 270);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Button btnIngresar;
    }
}

