using ReproductorMultimedia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMultimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboSegundos.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                comboSegundos.Items.Add(i);
            }
            comboSegundos.SelectedIndex = 2;
        }
        string[] archivos = new string[0];
        string ruta;
        int indice;
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = folderBrowserDialog.SelectedPath;
                archivos = Directory.GetFiles(folderBrowserDialog.SelectedPath).Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)).ToArray();
                if (archivos.Length == 0)
                {
                    MessageBox.Show("No se encontraron imágenes");
                }
                indice = 0;
                pictureBox1.ImageLocation = archivos[indice];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(reproMultimedia1.Segundos == 59)
            {
                reproMultimedia1.Minutos++;
            }
            if (archivos.Length > 0)
            {
                reproMultimedia1.Segundos++;

            }
            



        }

        private void timerImagen_Tick(object sender, EventArgs e)
        {
            if (archivos.Length > 0)
            {
                indice = (indice + 1) % archivos.Length;
                pictureBox1.ImageLocation = archivos[indice];

            }
        }
        private void reproMultimedia1_PlayClick(object sender, EventArgs e)
        {
            if (archivos.Length == 0)
            {
                reproMultimedia1.Parar();

                MessageBox.Show("No se han seleccionado imágenes");

            }
            else
            {
                if (timerImagen.Enabled)
                {
                    timerImagen.Stop();
                    timerTiempotra.Stop();
                }
                else
                {
                    timerImagen.Interval = (int)comboSegundos.SelectedItem * 1000;
                    timerImagen.Start();
                    timerTiempotra.Start();
                }

            }
        }
    }
}
