namespace ReproductorMp3
{
    partial class ReproMultimedia
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.etiquetaTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::ReproductorMp3.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(4, 4);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(61, 51);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // etiquetaTiempo
            // 
            this.etiquetaTiempo.AutoSize = true;
            this.etiquetaTiempo.Location = new System.Drawing.Point(87, 21);
            this.etiquetaTiempo.Name = "etiquetaTiempo";
            this.etiquetaTiempo.Size = new System.Drawing.Size(55, 16);
            this.etiquetaTiempo.TabIndex = 1;
            this.etiquetaTiempo.Text = "etiqueta";
            // 
            // ReproMultimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.etiquetaTiempo);
            this.Controls.Add(this.btnPlay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReproMultimedia";
            this.Size = new System.Drawing.Size(177, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label etiquetaTiempo;
    }
}
