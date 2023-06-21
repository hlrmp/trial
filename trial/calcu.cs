using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial
{
    public partial class calcu : Form
    {
        public calcu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1 != null)
            {
                //   one = int(textBox1.Text);
                numone();
            }


        }

        public int one = 1;


        public int numone()
        {
            return one;



        }
    }
}
