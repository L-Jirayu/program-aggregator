using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdomBet888
{
    public partial class Homework : Form
    {
        public Homework()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            problem1 x = new problem1();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            problem2 x = new problem2();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            problem5 x = new problem5();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            problem4 x = new problem4();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            problem3 x = new problem3();
            x.Show();
        }
    }
}
