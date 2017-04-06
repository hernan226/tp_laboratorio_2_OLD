namespace tp_laboratorio_2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblResultado = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.CmbOperacion = new System.Windows.Forms.ComboBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(13, 13);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(13, 13);
            this.LblResultado.TabIndex = 0;
            this.LblResultado.Text = "0";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(13, 30);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(78, 20);
            this.TxtNumero.TabIndex = 1;
            // 
            // CmbOperacion
            // 
            this.CmbOperacion.FormattingEnabled = true;
            this.CmbOperacion.Items.AddRange(new object[] {
            "/",
            "*",
            "+",
            "-"});
            this.CmbOperacion.Location = new System.Drawing.Point(97, 30);
            this.CmbOperacion.Name = "CmbOperacion";
            this.CmbOperacion.Size = new System.Drawing.Size(41, 21);
            this.CmbOperacion.TabIndex = 2;
            this.CmbOperacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(144, 31);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(74, 20);
            this.TxtNumero2.TabIndex = 3;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(16, 69);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "&CC";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(97, 69);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(75, 23);
            this.BtnOperar.TabIndex = 5;
            this.BtnOperar.Text = "&=";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 119);
            this.Controls.Add(this.BtnOperar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.CmbOperacion);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblResultado);
            this.Name = "FrmPrincipal";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.ComboBox CmbOperacion;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnOperar;
    }
}

