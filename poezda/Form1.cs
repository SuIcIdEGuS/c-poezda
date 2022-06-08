using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glushkov_windowsframeworkpoezda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            int vV = y / k;
            int h = y % k;
            if (h > 0)
            { vV = vV + 1; textBox5.Text = Convert.ToString(vV); }
            else {textBox5.Text = Convert.ToString(vV); }
            int vP = x / k;
            int Q = x % k;
            if (Q > 0)
            { vP = vP + 1; textBox4.Text = Convert.ToString(vP); }
            else { textBox4.Text = Convert.ToString(vP); }
            if (vP>vV)
            { int p = vP - vV; textBox6.Text = Convert.ToString(p); }
            else { int p = vV - vP; textBox6.Text = Convert.ToString(p); }

        }
    }
}
