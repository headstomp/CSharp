using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MathServiceWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                MathService.MathServiceClient loClient = new MathService.MathServiceClient();

                Int32 loNum1 = Convert.ToInt32(TextBoxNum1.Text.Trim());
                Int32 loNum2 = Convert.ToInt32(TextBoxNum2.Text.Trim());

                if (DropDownListOperator.Text == "Add")
                {
                    TextBoxResult.Text = loClient.Add(loNum1, loNum2).ToString();
                }
                else if (DropDownListOperator.Text == "Subtract")
                {
                    TextBoxResult.Text = loClient.Subtract(loNum1, loNum2).ToString();
                }
                else if (DropDownListOperator.Text == "Multiply")
                {
                    TextBoxResult.Text = loClient.Multiply(loNum1, loNum2).ToString();
                }
                else
                {

                    TextBoxResult.Text = loClient.Divide(loNum1, loNum2).ToString();
                }

            }
            catch (FaultException faultException)
            {
                LabelMessages.Text = faultException.Message;
            }
            
        }
    }
}