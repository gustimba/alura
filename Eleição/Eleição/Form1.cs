using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eleição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileiro = true;
            
            if(idade >= 16  && brasileiro == true)
            {
                MessageBox.Show("pode Votar");

            } else
            {
                MessageBox.Show("idade insuficiente ou Voce nao é brasileiro");
            }

        }
    }
}
