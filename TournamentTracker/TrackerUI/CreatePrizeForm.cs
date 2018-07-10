using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                placeNumberValidateLabel.Text = "not a valid number";
                output = false;
            }else { placeNumberValidateLabel.Text = ""; }

            if (placeNumber < 1)
            {
                placeNumberValidateLabel.Text = "must be greater than 0";
                output = false;
            }else { placeNameValidateLabel.Text = ""; }

            if (placeNameValue.Text.Length == 0)
            {
                placeNameValidateLabel.Text = "** required field"; 
                output = false;
            }else { placeNameValidateLabel.Text = ""; }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentValid = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentValid == false)
            {
                placeAmountValidateLabel.Text = "amount or percent required";
                placePercentValidateLabel.Text = "amount or percent required";
                output = false;
            }else { placeAmountValidateLabel.Text = ""; placePercentValidateLabel.Text = ""; }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                placeAmountValidateLabel.Text = "must be a positive number";
                placePercentValidateLabel.Text = "must be a positive number";
                output = false;
            }else { placeAmountValidateLabel.Text = ""; placePercentValidateLabel.Text = ""; }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                placePercentValidateLabel.Text = "must be between 1-100";
                output = false;
            }else { placePercentValidateLabel.Text = ""; }



            return output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
