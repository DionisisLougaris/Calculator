using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using com.dneonline.www;


public partial class Page1 : System.Web.UI.Page
{
    Calculator myWs = new Calculator();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        if (firstInput.Text != "" && secondInput.Text != "")
        {
            int firstNum, secondNum, result;
            firstNum = Convert.ToInt32(firstInput.Text);
            secondNum = Convert.ToInt32(secondInput.Text);
            result = myWs.Add(firstNum, secondNum);
            resultOutputLabel.Text = Convert.ToString(result);
        }
        else
        {
            resultOutputLabel.Text = "Please enter First and Second Number and try again!";
        }
    }

    protected void subtractButtton_Click(object sender, EventArgs e)
    {
        if (firstInput.Text != "" && secondInput.Text != "")
        {
            int firstNum, secondNum, result;
            firstNum = Convert.ToInt32(firstInput.Text);
            secondNum = Convert.ToInt32(secondInput.Text);
            result = myWs.Subtract(firstNum, secondNum);
            resultOutputLabel.Text = Convert.ToString(result);
        }
        else
        {
            resultOutputLabel.Text = "Please enter First and Second Number and try again!";
        }
    }

    protected void multiplyButton_Click(object sender, EventArgs e)
    {
        if (firstInput.Text != "" && secondInput.Text != "")
        {
            int firstNum, secondNum, result;
            firstNum = Convert.ToInt32(firstInput.Text);
            secondNum = Convert.ToInt32(secondInput.Text);
            result = myWs.Multiply(firstNum, secondNum);
            resultOutputLabel.Text = Convert.ToString(result);
        }
        else
        {
            resultOutputLabel.Text = "Please enter First and Second Number and try again!";
        }
    }

    protected void divideButton_Click(object sender, EventArgs e)
    {
        if (firstInput.Text != "" && secondInput.Text != "")
        {
            int firstNum, secondNum, result;
            firstNum = Convert.ToInt32(firstInput.Text);
            secondNum = Convert.ToInt32(secondInput.Text);
            if (secondNum != 0)
            {
                result = myWs.Divide(firstNum, secondNum);
                resultOutputLabel.Text = Convert.ToString(result);
            }
            else
            {
                resultOutputLabel.Text = "You can't divide by zero..";
            }
        }
        else
        {
            resultOutputLabel.Text = "Please enter First and Second Number and try again!";
        }
    }

    protected void clearButton_Click(object sender, EventArgs e)
    {
        firstInput.Text = "";
        secondInput.Text = "";
        resultOutputLabel.Text = "";
    }
}