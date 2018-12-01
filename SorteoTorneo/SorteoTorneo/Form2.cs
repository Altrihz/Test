using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteoTorneo
{
    public partial class Form2 : Form
    {
        String[] aMapas = { "Inferno", "Cache", "Overpass", "Cobble", "Train"};
        public Form2()
        {
            InitializeComponent();
            for (int i=0; i < aMapas.Length; i++)
            {
                lb_mapaspull.Items.Add(aMapas[i]);
            }
        }

        private void bt_sortear_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Random r1 = new Random();
            if (r1.Next(2) == 0)
            {
                textBox1.BackColor = Color.Blue;
                textBox2.BackColor = Color.Yellow;
            }
            else
            {
                textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Blue;
            }

            lblResultado.Text = aMapas[r.Next(5)];
        }
    }
}
