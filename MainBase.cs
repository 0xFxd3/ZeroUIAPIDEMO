using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroUIAPIDemo
{
    public partial class MainBase : Form
    {
        public MainBase()
        {
            InitializeComponent();
        }

        //your toggles here if u want//

        bool normaltoggle;

        // toggles end here//
        private void button2_Click(object sender, EventArgs e)
        {
            normaltoggle = !normaltoggle;
            if (normaltoggle)
            {
                button2.BackColor = Color.White;
                MessageBox.Show("I am toggled!");
                //enabled...
                API.YouKnowWhatFuckIt5MSEXECUTIOOONN("godmode");
            }
            else
            {
                button2.BackColor = Color.FromArgb(255, 30, 30, 30);
                
                //disabled
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selfie.Visible = !selfie.Visible;
        }
    }
}
