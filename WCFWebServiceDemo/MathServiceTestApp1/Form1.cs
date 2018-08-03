using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceTestApp1.MathService1;

namespace MathServiceTestApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            MathServiceClient loClient = new MathServiceClient();

            Int32 loNum1 = Convert.ToInt32(textBoxNum1.Text.Trim());
            Int32 loNum2 = Convert.ToInt32(textBoxNum2.Text.Trim());

            if (comboBoxOperator.Text == "Add")
            {
                textBoxResult.Text = loClient.Add(loNum1, loNum2).ToString();
            }
            else if (comboBoxOperator.Text == "Subtract")
            {
                textBoxResult.Text = loClient.Subtract(loNum1, loNum2).ToString();
            }
            else if (comboBoxOperator.Text == "Multiply")
            {
                textBoxResult.Text = loClient.Multiply(loNum1, loNum2).ToString();
            }
            else 
            {
                textBoxResult.Text = loClient.Divide(loNum1, loNum2).ToString();
            }
        }
    }
}
