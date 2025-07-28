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
    public partial class problem4 : Form
    {
        public problem4()
        {
            InitializeComponent();
        }


        int ranN, n;

        private void luckranNum()
        {
            label1.Text = "Ans: ";
            listBox1.Items.Clear();
            listBox1.Items.Add("ตัวเลขที่ถูกปรากฎไว้แล้ว");
            listBox1.Items.Add("กรอกเลข แล้ว");
            listBox1.Items.Add("Random Check ได้เลย");

            Random ran = new Random();
            ranN = ran.Next(1, 101);

            label1.Text += "?";

        }

        private void constrtoint()
        {
            if (!int.TryParse(txtnum.Text, out n))
            {
                n = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            constrtoint();

            if (n == -1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("กรุณากรอกตัวเลขที่ถูกต้อง!");
                return;
            }

            while (true)
            {
                listBox1.Items.Clear();

                if (n < ranN)
                {
                    listBox1.Items.Add(n.ToString() + " เอ็งทายต่ำเกิ๊น");
                }
                else if (n > ranN)
                {
                    listBox1.Items.Add(n.ToString() + " เอ็งก็ทายสูงไป๊");
                }
                else
                {
                    listBox1.Items.Add(n.ToString() + " ถูกละ เก่งมาก!");
                    label1.Text = "Ans: " + ranN.ToString();
                    break;
                }

                break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            luckranNum();
            
        }
    }
}
