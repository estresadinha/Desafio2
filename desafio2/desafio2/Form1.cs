using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            emoji.Visible = true;

        }

       

        private void botao1_Click(object sender, EventArgs e)
        {

            emoji.Visible = false;

        }

        private void emoji_click(object sender, EventArgs e)
        {
           

        }
    }
}
