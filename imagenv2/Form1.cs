using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagenv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {

            string[] imagenes=new string[5];

            string dir= "C:\\Users\\JUAN PABLO\\Desktop\\Imagenes\\";

            imagenes[0] = dir + "Cos1.jpg";
            imagenes[1] = dir + "Cos2.jpg";
            imagenes[2] = dir + "Cos3.jpg";
            imagenes[3] = dir + "Cos4.jpg";
            imagenes[4] = dir + "Cos5.jpg";

            Random random = new Random();

            pic.Image = Image.FromFile(imagenes[random.Next(5)]);

        }
    }
}
