using Lista_de_ReproduccionMP3.Clases;
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

namespace Lista_de_ReproduccionMP3
{
    public partial class Form1 : Form
    {
        bool play = false;
        Lista lista = new Lista();
        private string[] canciones;
        private string[] ruta;    

        public Form1()
        {
            InitializeComponent();
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reproductor.URL = ruta[lstCanciones.SelectedIndex];
            
        }


        private void Play_Click(object sender, EventArgs e)
        {
            Reproductor.URL = ruta[lstCanciones.SelectedIndex];
            pictureBox2.Image = Properties.Resources.rounded_pause_button;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog busqueda = new OpenFileDialog();
            busqueda.Multiselect = true;
            if (busqueda.ShowDialog() == DialogResult.OK)
            {
                canciones = busqueda.SafeFileNames;
                ruta = busqueda.FileNames;

                foreach (var cancion in canciones)
                {

                    lista.insertarCancion(cancion);
                    lstCanciones.Items.Add(cancion);

                    //lista = new Lista();
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            switch (play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    pictureBox2.Image = Properties.Resources.play_button;
                    play = false;

                    break;
                case false:
                    if(play == true)
                    {
                        Reproductor.URL = ruta[lstCanciones.SelectedIndex];
                    }
                    Reproductor.Ctlcontrols.play();
                    pictureBox2.Image = Properties.Resources.rounded_pause_button;
                    play = true;
                    break;
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //lista.eliminar(lstCanciones.SelectedItem);
            lista.eliminarCancion(lstCanciones.SelectedIndex);
            lstCanciones.Items.Remove(lstCanciones.SelectedItem);
            Reproductor.Ctlcontrols.stop();
            int pausa;
            pausa = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(10, 0, 0, 0);
            pictureBox2.BackColor = Color.FromArgb(10, 0, 0, 0);
            pictureBox3.BackColor = Color.FromArgb(10, 0, 0, 0);
           
        }
    }
}
