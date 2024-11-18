using OOPSample_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSample_0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Human h = new Human();
            h.Name = "Ahmet";
            Human h2 = new Human();
            h2.Name = "Mehmet";

            h.CayIc(h2);
        }
    }
}
