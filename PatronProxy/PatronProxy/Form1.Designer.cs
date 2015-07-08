namespace PatronProxy
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBOriginal = new System.Windows.Forms.TextBox();
            this.textBProxy = new System.Windows.Forms.TextBox();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar Cambios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBOriginal
            // 
            this.textBOriginal.Location = new System.Drawing.Point(30, 12);
            this.textBOriginal.Multiline = true;
            this.textBOriginal.Name = "textBOriginal";
            this.textBOriginal.Size = new System.Drawing.Size(201, 262);
            this.textBOriginal.TabIndex = 3;
            // 
            // textBProxy
            // 
            this.textBProxy.Location = new System.Drawing.Point(269, 12);
            this.textBProxy.Multiline = true;
            this.textBProxy.Name = "textBProxy";
            this.textBProxy.Size = new System.Drawing.Size(184, 262);
            this.textBProxy.TabIndex = 4;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(74, 343);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(100, 49);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 405);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.textBProxy);
            this.Controls.Add(this.textBOriginal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Formulario";
            this.ShowIcon = false;
            this.Text = "Proxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBOriginal;
        private System.Windows.Forms.TextBox textBProxy;
        private System.Windows.Forms.Button Salir;
    }
}

