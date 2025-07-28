using System;
using System.Windows.Forms;

namespace UdomBet888
{
    public partial class problem5 : Form
    {
        private double num1, num2;
        private char cal;

        public problem5()
        {
            InitializeComponent();

            num1 = num2 = 0.0;
            cal = '\0';
        }

        private void enter_num(object sender, EventArgs e)
        {
            Button button = sender as Button;
            result.Text += button.Text; 
        }

        private void clickclear(object sender, EventArgs e)
        {
            result.Clear();
            num1 = num2 = 0.0;
            cal = '\0';
        }

        private void opare_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (!string.IsNullOrEmpty(result.Text))
            {
                num1 = Convert.ToDouble(result.Text);
                cal = Convert.ToChar(button.Text); 
                result.Text += " " + button.Text + " ";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            double ans = 0.0;

            string[] parts = result.Text.Split(' ');

            if (parts.Length == 3) 
            {
                num2 = Convert.ToDouble(parts[2]); 

                switch (cal)
                {
                    case '+':
                        ans = num1 + num2;
                        break;

                    case '-':
                        ans = num1 - num2;
                        break;

                    case 'X':
                        ans = num1 * num2;
                        break;

                    case '%': 
                        if (num2 == 0) 
                        {
                            MessageBox.Show("Error: Division by zero is not allowed.");
                            result.Clear();
                            return;
                        }
                        ans = num1 / num2;
                        break;

                    default:
                        MessageBox.Show("Unknown operator.");
                        return;
                }

                result.Text = Convert.ToString(ans);
                num1 = ans; 
                cal = '\0';
            }
            else
            {
                MessageBox.Show("Invalid operation.");
            }
        }
    }
}
