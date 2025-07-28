using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Aggregator
{
    public partial class problem1 : Form
    {
        public problem1()
        {
            InitializeComponent();
        }

        int n1, n2;
        private void ConvertToInt()
        {

            int.TryParse(txtnum1.Text, out n1);
            int.TryParse(txtnum2.Text, out n2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToInt();
            result.Items.Clear();
            result.Items.Add("Result : ");
            if (n1 == n2)
            {
                result.Items.Add("Equal");
                txtnum2.Enabled = false;
            }
            else
            {
                result.Items.Add("Not Equal");
                txtnum2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConvertToInt();
            result.Items.Clear();
            for (int i = n1; i < n2; i++)
            {

                this.result.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConvertToInt();
            result.Items.Clear();
            switch (n1)
            {
                case 0:
                    {
                        result.Items.Add("ไฟปิด");
                        break;
                    }
                case 1:
                    {
                        result.Items.Add("ไฟเปิด");
                        break;
                    }
                default:

                    result.Items.Add("ไม่มีไฟ");
                    break;
            }


        }


    }
}
