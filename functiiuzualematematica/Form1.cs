using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace functiiuzualematematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        natural na = new natural();
        natural nb = new natural();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void newline()
        {
            textBox2.Text += "\r\n";
        }
        public void deltextbox()
        {
            textBox2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                na.a = Int16.Parse(textBox1.Text);
                nb.a = Int16.Parse(textBox3.Text);

            deltextbox();
            textBox2.Text += "Nr A: " +  na.a.ToString(); newline();
            textBox2.Text += "Nr B: " + nb.a.ToString(); newline();
            textBox2.Text += "impar: " + na.eimpar().ToString(); newline();
            textBox2.Text += "par: " + na.epar().ToString(); newline();
            textBox2.Text += "prim: " + na.eprim().ToString(); newline();
            textBox2.Text += "divide: " + na.edivizibil(nb).ToString(); newline();
            textBox2.Text += "multiplu: " + na.emultiplu(nb).ToString(); newline();
            textBox2.Text += "submultiplu: " + na.esubmultiplu(nb).ToString(); newline();
            textBox2.Text += "egal: " + na.eegal(nb).ToString(); newline();
            textBox2.Text += "diferit: " + na.ediferit(nb).ToString(); newline();
            textBox2.Text += "mai mic: " + na.emaimic(nb).ToString(); newline();
            textBox2.Text += "mai mare: " + na.emaimare(nb).ToString(); newline();
            
            }
            catch { }
        }
    }
}
