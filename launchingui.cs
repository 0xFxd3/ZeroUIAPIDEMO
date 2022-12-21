using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroUIAPIDemo;

namespace ZeroUIAPIDemo
{
    public partial class launchingui : Form
    {
        public launchingui()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //lol retard.
            button1.Enabled = true;
        }
    }
}
