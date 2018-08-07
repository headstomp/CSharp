using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServiceTestApp1.MathService1;

namespace MathServiceTestApp1
{
    public partial class Form1 : Form
    {
        MathService1.MathServiceClient loClient = null;

        public Form1()
        {
            InitializeComponent();
            loClient = new MathServiceClient();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
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
            catch (FaultException faultException)
            //catch (FaultException<MathService1.DivideByZeroFault> faultException)

            {
                //labelMessage.Text = faultException.Code.Name + " - " + faultException.Message;
                //labelMessage.Text = faultException.Detail.Error + " - " + faultException.Detail.Details;
                labelMessage.Text = faultException.Message;
            }
        }

        private void buttonNewProxy_Click(object sender, EventArgs e)
        {
            loClient = new MathServiceClient();
            MessageBox.Show("A new instance of proxy class is created");
        }
    }
}
