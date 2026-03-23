namespace ReproductorMultimedia
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
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerTiempotra = new System.Windows.Forms.Timer(this.components);
            this.timerImagen = new System.Windows.Forms.Timer(this.components);
            this.comboSegundos = new System.Windows.Forms.ComboBox();
            this.reproMultimedia1 = new ReproductorMp3.ReproMultimedia();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(310, 348);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(84, 23);
            this.btnSeleccion.TabIndex = 1;
            this.btnSeleccion.Text = "Selecciona";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(185, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timerTiempotra
            // 
            this.timerTiempotra.Interval = 1000;
            this.timerTiempotra.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerImagen
            // 
            this.timerImagen.Tick += new System.EventHandler(this.timerImagen_Tick);
            // 
            // comboSegundos
            // 
            this.comboSegundos.FormattingEnabled = true;
            this.comboSegundos.Location = new System.Drawing.Point(594, 148);
            this.comboSegundos.Name = "comboSegundos";
            this.comboSegundos.Size = new System.Drawing.Size(121, 24);
            this.comboSegundos.TabIndex = 3;
            // 
            // reproMultimedia1
            // 
            this.reproMultimedia1.Location = new System.Drawing.Point(274, 276);
            this.reproMultimedia1.Margin = new System.Windows.Forms.Padding(4);
            this.reproMultimedia1.Minutos = 0;
            this.reproMultimedia1.Name = "reproMultimedia1";
            this.reproMultimedia1.Parado = true;
            this.reproMultimedia1.Segundos = 0;
            this.reproMultimedia1.Size = new System.Drawing.Size(177, 65);
            this.reproMultimedia1.TabIndex = 0;
            this.reproMultimedia1.PlayClick += new System.EventHandler(this.reproMultimedia1_PlayClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboSegundos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.reproMultimedia1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReproductorMp3.ReproMultimedia reproMultimedia1;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTiempotra;
        private System.Windows.Forms.Timer timerImagen;
        private System.Windows.Forms.ComboBox comboSegundos;
    }
}

