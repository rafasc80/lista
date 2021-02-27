using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                llenarLista();
                textBox1.Clear();
            }
        }
        List<string> lista = new List<string>();

        public void llenarLista()
        {
            string linea;
            linea = textBox1.Text;
            lista.Add(linea);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {

            lista.ForEach(delegate (String name)
            {
                richTextBox1.Text = richTextBox1.Text + name + "\n";
            });

        }
    }
}
