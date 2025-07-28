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
    public partial class problem3 : Form
    {
        public problem3()
        {
            InitializeComponent();
        }

        int num;
        public void changetoint()
        {
            int.TryParse(txtnum.Text, out num);
        }

        public void calmulti()
        {
            changetoint();
            result.Items.Clear();

            for (int i = 1; i < 13; i++)
            {
                int multi = num * i;
                string line = $"{num} x {i} = {multi}";
                this.result.Items.Add(line);
            }
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            calmulti();
        }
    }
}
