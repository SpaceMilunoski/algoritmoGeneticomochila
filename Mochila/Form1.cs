using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mochila
{
    public partial class Form1 : Form
    {
        public static int val1, val2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int Poblacion = Convert.ToInt32(tbPoblacion.Text);
            Random r = new Random();

            double sumatoria = 0;
            //int vueltas = Convert.ToInt32(tbVueltas.Text);
            lbIndividuos.Items.Clear();
            //lbX.Items.Clear();
            //lbFx.Items.Clear();
            //lbFnorm.Items.Clear();
            //lbAcumulado.Items.Clear();
            //lbPadres.Items.Clear();
            //lbHijos.Items.Clear();
            //lbMutacion.Items.Clear();
            //lbMejornumero.Items.Clear();
            //lbMejorfx.Items.Clear();

            for (int i = 0; i < Poblacion; i++)
            {
                string binario = "";
                for (int j = 0; j < Convert.ToInt32(tbItems.Text); j++)//Generar numero binario aleatorio
                {
                    int random = r.Next(0, 2);
                    binario = binario + Convert.ToString(random);
                }
                lbIndividuos.Items.Add(binario);
            }
        }

        private void btnAdditems_Click(object sender, EventArgs e)
        {
            pedirItems pei = new pedirItems();
            if (pei.ShowDialog()==DialogResult.OK)
            {
                agregar(val1, val2);
            }
            
           

        }
        public void agregar(double p, double g)
        {
            lbGanancias.Items.Add(g);
            lbPesos.Items.Add(p);
        }
    }
}
