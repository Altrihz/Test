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
    public partial class Form1 : Form
    {
        Random r = new Random();
        String[] aParticipantes = new String[16] { "Alvaro","Novo","Jalaico","Cascu" ," Runekk","Was Was","Gabi","Telmo","Hacko","Cris","Neira","Patu","Zalo","Pablo","Denis","Levas"};
        String[] aSorteados = new String[16] { "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20", "20" };
        public Form1()
        {
            InitializeComponent();
            rellenaArray();

        }
        private void rellenaArray() {
            int rand = randomiza();
            for (int i = 0; i < aParticipantes.Length; i++)
            {
                if (comprueba(rand))
                {
                    listBox1.Items.Add(aParticipantes[rand]);
                    aSorteados[i] = (aParticipantes[rand]);
                }
                else
                {
                    rand = randomiza();
                    i--;
                }
            }
        }
        private int randomiza()
        {
            return r.Next(16);

        }
        private bool comprueba(int rand)
        {

            if (listBox1.Items.Contains(aParticipantes[rand]))
            {
                return false;
            }
            else
                return true;
        }

        private void bt_Rellenar_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //foreach (Control elemento in Controls)
            //{
            //    if (elemento.Name.StartsWith("label"))
            //    {
            //        elemento.Text = aSorteados[i];
            //    }
            //    if (elemento.Name.StartsWith("label"))
            //    {
            //        i++;
            //    }

            //}
            label1.Text = "Zalo";
            label2.Text = "Telmo";
            label3.Text = "Runnek";
            label4.Text = "Cris";

            label5.Text = "Cascu";
            label6.Text = "Patu";
            label7.Text = "Neira";
            label8.Text = "Levas";


            label9.Text = "Novo";
            label10.Text = "Alvaro";
            label11.Text = "Pablo";
            label12.Text = "Was";

            label13.Text = "Denis";
            label14.Text = "Gabi";
            label15.Text = "Jalaico";
            label16.Text = "Hacko";
            bt_Rellenar.Enabled = false;
        }

        private void Ganador(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Green;
            if (clickedLabel.Name.Equals("label1"))
            {
                lblgan1.Text = label1.Text;
                label2.BackColor = Color.Red;
                label2.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label2"))
            {
                lblgan1.Text = label2.Text;
                label1.BackColor = Color.Red;
                label1.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label3"))
            {
                lblgan2.Text = label3.Text;
                label4.BackColor = Color.Red;
                label4.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label4"))
            {
                lblgan2.Text = label4.Text;
                label3.BackColor = Color.Red;
                label3.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label5"))
            {
                lblgan3.Text = label5.Text;
                label6.BackColor = Color.Red;
                label6.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label6"))
            {
                lblgan3.Text = label6.Text;
                label5.BackColor = Color.Red;
                label5.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label7"))
            {
                lblgan4.Text = label7.Text;
                label8.BackColor = Color.Red;
                label8.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label8"))
            {
                lblgan4.Text = label8.Text;
                label7.BackColor = Color.Red;
                label7.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label9"))
            {
                lblgan5.Text = label9.Text;
                label10.BackColor = Color.Red;
                label10.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label10"))
            {
                lblgan5.Text = label10.Text;
                label9.BackColor = Color.Red;
                label9.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label11"))
            {
                lblgan6.Text = label11.Text;
                label12.BackColor = Color.Red;
                label12.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label12"))
            {
                lblgan6.Text = label12.Text;
                label11.BackColor = Color.Red;
                label11.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label13"))
            {
                lblgan7.Text = label13.Text;
                label14.BackColor = Color.Red;
                label14.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label14"))
            {
                lblgan7.Text = label14.Text;
                label13.BackColor = Color.Red;
                label13.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label15"))
            {
                lblgan8.Text = label15.Text;
                label16.BackColor = Color.Red;
                label16.Enabled = false;
            }
            if (clickedLabel.Name.Equals("label16"))
            {
                lblgan8.Text = label16.Text;
                label15.BackColor = Color.Red;
                label15.Enabled = false;
            }
        }

        private void lblgan1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Green;
            if (clickedLabel.Name.Equals("lblgan1"))
            {
                lblgan12.Text = lblgan1.Text;
                lblgan2.Enabled = false;
                lblgan2.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan2"))
            {
                lblgan12.Text = lblgan2.Text;
                lblgan1.Enabled = false;
                lblgan1.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan3"))
            {
                lblgan34.Text = lblgan3.Text;
                lblgan4.Enabled = false;
                lblgan4.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan4"))
            {
                lblgan34.Text = lblgan4.Text;
                lblgan3.Enabled = false;
                lblgan3.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan5"))
            {
                lblgan56.Text = lblgan5.Text;
                lblgan6.Enabled = false;
                lblgan6.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan6"))
            {
                lblgan56.Text = lblgan6.Text;
                lblgan5.Enabled = false;
                lblgan5.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan7"))
            {
                lblgan78.Text = lblgan7.Text;
                lblgan8.Enabled = false;
                lblgan8.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan8"))
            {
                lblgan78.Text = lblgan8.Text;
                lblgan7.Enabled = false;
                lblgan7.BackColor = Color.Red;
            }
        }

        private void aSemis(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Green;
            if (clickedLabel.Name.Equals("lblgan12"))
            {
                lblsem1.Text = lblgan12.Text;
                lblgan34.Enabled = false;
                lblgan34.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan34"))
            {
                lblsem1.Text = lblgan34.Text;
                lblgan12.Enabled = false;
                lblgan12.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan56"))
            {
                lblsem2.Text = lblgan56.Text;
                lblgan78.Enabled = false;
                lblgan78.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblgan78"))
            {
                lblsem2.Text = lblgan78.Text;
                lblgan56.Enabled = false;
                lblgan56.BackColor = Color.Red;
            }
        }

        private void ganadorFinal(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            clickedLabel.BackColor = Color.Green;
            if (clickedLabel.Name.Equals("lblsem1"))
            {
                lblganador.Text = lblsem1.Text;
                lblsem2.Enabled = false;
                lblsem2.BackColor = Color.Red;
            }
            if (clickedLabel.Name.Equals("lblsem2"))
            {
                lblganador.Text = lblsem2.Text;
                lblsem1.Enabled = false;
                lblsem1.BackColor = Color.Red;
            }
            MessageBox.Show("El ganador del torneo es: " + lblganador.Text,"FIN DEL TORNEO");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control elemento in Controls)
            {
                if (elemento.Name.StartsWith("label") || elemento.Name.StartsWith("lbl"))
                {
                    elemento.Text = "";
                    elemento.BackColor = Color.Transparent;
                    elemento.Enabled = true;
                }
            }
            bt_Rellenar.Enabled = true;
            listBox1.Items.Clear();
            for (int i = 0; i < aSorteados.Length; i++)
            {
                aSorteados[i] = "20";
            }
            rellenaArray();
        }

        private void btEleccionMapa_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2( );
            f.ShowDialog();
        }
    }

}

