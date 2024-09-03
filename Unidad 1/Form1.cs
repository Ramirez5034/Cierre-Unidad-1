using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_1
{
    public partial class Form1 : Form
    {
        private string ruta = "C:\\Users\\Pablo\\Downloads\\Videos\\Alphamon VS Jesmon - Digimon Adventure tri. 3_ Kokuhaku.mp4";
        private string ruta2 = "\\Users\\Pablo\\Downloads\\Videos\\Digimon 02 The Beginning Imperialdramon FM.mp4";
        private string ruta3 = "\\Users\\Pablo\\Downloads\\Videos\\Great Xros - Shoutmon X7 [HD 1080i].mp4";
        private string rutaCarga = "";
        public Form1()
        {
            InitializeComponent();
        }
        //Videos Precargados
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta2;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta3;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        //Cargar Video desde Archivos
        private void button4_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                rutaCarga = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = rutaCarga;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }    
        }
    }
}
