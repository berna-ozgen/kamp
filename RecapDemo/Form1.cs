using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()//Constractor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Width = 50;
            button.Height = 50;
            this.Controls.Add(button);

        }

     
    }
}
