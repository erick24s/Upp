using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purificadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cobPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobPrueba.Items.Add ("Pedro");
            cobPrueba.Items.Add("eee");
            cobPrueba.Items.Add("dre");
            cobPrueba.Items.Add("ttt");
          
            txtPrueba1.Text = Convert.ToString (cobPrueba.Text);
         
        }
    }
}
