using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLoteria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int numero3;
            int dinero;
            

            Random rnd = new Random();
            numero1 = rnd.Next(0, 99);
            numero2 = rnd.Next(0, 99);
            numero3 = rnd.Next(0, 99);
            txtresultado1.Text = numero1.ToString();
            txtresultado2.Text = numero2.ToString();
            txtresultado3.Text = numero3.ToString();
            txtganada1.Text = "";
            txtganada2.Text = "";
            txtganada3.Text = "";

            if (Dato.loto1 ==  numero1)
            {
                MessageBox.Show("Ganaste EL PRIMER LOTO");
                dinero = Dato.cantidad1 * 20;
                txtganada1.Text = "RD$" + dinero.ToString();


            }
            else if (Dato.loto2 == numero2)
            {
                MessageBox.Show("Ganaste EL SEGUNDO LOTO");
                dinero = Dato.cantidad2 * 10;
                txtganada2.Text = "RD$" + dinero.ToString ();
            }
            else if (Dato.loto3 == numero3)
            {
                MessageBox.Show("Ganaste EL TERCER LOTO");
                dinero = Dato.cantidad3 * 10;
                txtganada3.Text = "RD$" + dinero.ToString();
            }






        }

        private void button4_Click(object sender, EventArgs e)
        {
                       int numero1;
            int numero2;
            int numero3;
            int dinero;
            

            Random q = new Random();
            numero1 = q.Next(0, 99);
            numero2 = q.Next(0, 99);
            numero3 = q.Next(0, 99);
            txtresultado1.Text = numero1.ToString();
            txtresultado2.Text = numero2.ToString();
            txtresultado3.Text = numero3.ToString();

            if (Dato.loto1 ==  numero1)
            {
                MessageBox.Show("Ganaste EL PRIMER LOTO");
                dinero = Dato.cantidad1 * 20;
                txtganada1.Text = "RD$" + dinero.ToString();


            }
            else if (Dato.loto2 == numero2)
            {
                MessageBox.Show("Ganaste EL SEGUNDO LOTO");
                dinero = Dato.cantidad2 * 10;
                txtganada2.Text = "RD$" + dinero.ToString();
            }
            else if (Dato.loto3 == numero3)
            {
                MessageBox.Show("Ganaste EL TERCER LOTO");
                dinero = Dato.cantidad3 * 5;
                txtganada3.Text = "RD$" + dinero.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtresultado2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
}
