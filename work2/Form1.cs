using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;

            try
            {
                num1 = Convert.ToInt32(TextNum1.Text);
                num2 = Convert.ToInt32(TextNum2.Text);
                switch (Operator.SelectedItem)
                {
                    case "+":
                        LblMsg.Text = $"Your result: {num1} + {num2} = " + (num1 + num2);
                        break;
                    case "-":
                        LblMsg.Text = $"Your result: {num1} - {num2} = " + (num1 - num2);
                        break;
                    case "*":
                        LblMsg.Text = $"Your result: {num1} * {num2} = " + (num1 * num2);
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            LblMsg.Text = "Error: divisor is zero!";
                        }
                        LblMsg.Text = $"Your result: {num1} / {num2} = " + (num1 / num2);
                        break;
                    default:
                        LblMsg.Text = "Please select operator!";
                        break;
                }
            }
            catch (FormatException)
            {
                LblMsg.Text = "Error: inputted format is error!";
            }
            catch (OverflowException)
            {
                LblMsg.Text = "Error: inputted number is overflow!";
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextNum1.Text = String.Empty;
            TextNum2.Text = String.Empty;
            LblMsg.Text = String.Empty;
            Operator.SelectedIndex = 0;
            TextNum1.TabIndex = 0;
        }
    }
}
