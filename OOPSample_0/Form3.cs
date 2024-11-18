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
    public partial class Form3 : Form
    {

        //Foreach döngüsü sadece koleksiyonlarda dönebilen bir döngü mekanizmasıdır...Kendisi baska türde bir girdi alamaz...Kendisi sadece ileriye dogru döngü calıstırır (geriye dogru dönemez)


        /*
         
         foreach( string sehir in sehirler)
        {
        }
         
         
         
         */


        public Form3()
        {
            InitializeComponent();
        }

        List<string> sehirler = new List<string>
        {
            "İstanbul","Eskişehir","İzmir","Adana"
        };

        private void Form3_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < sehirler.Count; i++)
            //{
            //    MessageBox.Show(sehirler[i]);
            //}

            foreach (string item in sehirler)
            {
               
                MessageBox.Show(item);

            }
        }
    }
}
