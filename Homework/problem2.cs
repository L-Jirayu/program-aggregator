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
    public partial class problem2 : Form
    {
        public problem2()
        {
            InitializeComponent();
        }

        int check;
        private void ConvertToInt()
        {

            int.TryParse(num.Text, out check);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToInt();
            result.Text = "";
            result.Text = "Result : ";
            if (check%2 == 0)
            {
                result.Text = ("Even");
            }
            else
            {
                result.Text = ("Odd");
            }
        }
    }
}
