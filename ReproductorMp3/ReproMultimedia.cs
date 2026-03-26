using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReproductorMp3.Properties;
using System.IO;

namespace ReproductorMp3
{
    [DefaultEvent("PlayClick")]
    [DefaultProperty("Minutos")]
    public partial class ReproMultimedia : UserControl
    {
        private int minutos;
        private int segundos;
        private bool parado = true;

        [Category("Mis propiedades")]
        [Description("Indica si el reproductor está parado o no")]
        public bool Parado { get { return parado; } set { parado = value; } }

        [Category("Mis propiedades")]
        [Description("Minutos transcurridos")]
        public int Minutos
        {
            get { return minutos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                if (value > 59)
                {
                    minutos = 0;

                }
                else
                {
                    minutos = value;
                }
            }
        }
        [Category("Mis propiedades")]
        [Description("Segundos transcurridos")]
        public int Segundos
        {
            get { return segundos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                if (value > 59)
                {
                    
                    segundos = value % 60;
                    OnDesbordaTiempo(EventArgs.Empty);
                }
                else
                {
                    segundos = value;
                }
                etiquetaTiempo.Text = $"{Minutos:00}:{Segundos:00}";
                Refresh();
            }
        }
        public ReproMultimedia()
        {
            InitializeComponent();

            etiquetaTiempo.Text = $"{Minutos:00}:{Segundos:00}";

        }

        [Category("Mis eventos")]
        [Description("Se lanza cuando los segundos superan 59")]
        public event EventHandler DesbordaTiempo;
        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            DesbordaTiempo?.Invoke(this, e);
            Minutos++;
        }


        [Category("Mis eventos")]
        [Description("Se lanza cuando se clica el boton play/pause")]

        public event EventHandler PlayClick;
        protected virtual void OnPlayClick(EventArgs e)
        {
            PlayClick?.Invoke(this, e);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Parado)
            {
                Parado = false;
                btnPlay.BackgroundImage = Resources.pause;
            }
            else
            {
                Parado = true;
                btnPlay.BackgroundImage = Resources.play;
            }
            Refresh();

            OnPlayClick(e);


        }
        public void Parar()
        {
            Parado = true;
            btnPlay.BackgroundImage = Resources.play;
            Refresh();
        }


    }
}
