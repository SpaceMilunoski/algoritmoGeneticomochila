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
    public partial class pedirItems : Form
    {
        public pedirItems()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1.val1 = Convert.ToInt32(tbPeso.Text);
            Form1.val2 = Convert.ToInt32(tbGanancia.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        
    }
}
