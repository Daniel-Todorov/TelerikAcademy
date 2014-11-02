using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.SimpleCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Command(object sender, CommandEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.result.Text))
            {
                try
                {
                    double.Parse(this.result.Text);
                }
                catch (Exception)
                {
                    return;
                }
            }

            var button = sender as Button;

            switch (button.CommandName)
            {
                case "Number":
                    this.result.Text = this.result.Text + button.CommandArgument;
                    break;
                case "Operation":
                    this.ExecuteOperation(button.CommandArgument);
                    break;
                default:
                    break;
            }
        }

        private void ExecuteOperation(string operationName)
        {
            switch (operationName)
            {
                case "Clear":
                    this.argumentKeeper.InnerText = string.Empty;
                    this.operationKeeper.InnerText = string.Empty;
                    this.result.Text = string.Empty;
                    break;
                case "Equal":
                    this.ExecuteAction();

                    this.operationKeeper.InnerText = string.Empty;
                    break;
                case "Plus":
                    if (string.IsNullOrWhiteSpace(this.argumentKeeper.InnerText))
                    {
                        this.argumentKeeper.InnerText = this.result.Text;
                        this.result.Text = string.Empty;
                    }
                    else if (string.IsNullOrWhiteSpace(this.operationKeeper.InnerText))
                    {
                        this.operationKeeper.InnerText = "+";
                        this.result.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        this.ExecuteAction();

                        this.result.Text = string.Empty;
                    }

                    this.operationKeeper.InnerText = "+";
                    break;
                case "Minus":
                    if (string.IsNullOrWhiteSpace(this.argumentKeeper.InnerText))
                    {
                        this.argumentKeeper.InnerText = this.result.Text;
                        this.result.Text = string.Empty;
                    }
                    else if (string.IsNullOrWhiteSpace(this.operationKeeper.InnerText))
                    {
                        this.operationKeeper.InnerText = "-";
                        this.result.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        this.ExecuteAction();

                        this.result.Text = string.Empty;
                    }

                    this.operationKeeper.InnerText = "-";
                    break;
                case "Multiply":
                    if (string.IsNullOrWhiteSpace(this.argumentKeeper.InnerText))
                    {
                        this.argumentKeeper.InnerText = this.result.Text;
                        this.result.Text = string.Empty;
                    }
                    else if (string.IsNullOrWhiteSpace(this.operationKeeper.InnerText))
                    {
                        this.operationKeeper.InnerText = "x";
                        this.result.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        this.ExecuteAction();

                        this.result.Text = string.Empty;
                    }

                    this.operationKeeper.InnerText = "x";
                    break;
                case "Divide":
                    if (string.IsNullOrWhiteSpace(this.argumentKeeper.InnerText))
                    {
                        this.argumentKeeper.InnerText = this.result.Text;
                        this.result.Text = string.Empty;
                    }
                    else if (string.IsNullOrWhiteSpace(this.operationKeeper.InnerText))
                    {
                        this.operationKeeper.InnerText = "/";
                        this.result.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        this.ExecuteAction();

                        this.result.Text = string.Empty;
                    }

                    this.operationKeeper.InnerText = "/";
                    break;
                case "Sqrt":
                    try
                    {
                        double argument = double.Parse(this.result.Text);
                        double result = Math.Sqrt(argument);

                        if (argument <= 0)
                        {
                            return;
                        }

                        this.argumentKeeper.InnerText = result.ToString();
                        this.result.Text = string.Empty;
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    break;
                default:
                    break;
            }
        }

        private void ExecuteAction()
        {
            try
            {
                double firstArgument = double.Parse(this.argumentKeeper.InnerText);
                double secondArgument = double.Parse(this.result.Text);

                string action = this.operationKeeper.InnerText;
                switch (action)
                {
                    case "-":
                        this.argumentKeeper.InnerText = (firstArgument - secondArgument).ToString();
                        this.result.Text = (firstArgument - secondArgument).ToString();
                        break;
                    case "+":
                        this.argumentKeeper.InnerText = (firstArgument + secondArgument).ToString();
                        this.result.Text = (firstArgument + secondArgument).ToString();
                        break;
                    case "x":
                        this.argumentKeeper.InnerText = (firstArgument * secondArgument).ToString();
                        this.result.Text = (firstArgument * secondArgument).ToString();
                        break;
                    case "/":
                        this.argumentKeeper.InnerText = (firstArgument / secondArgument).ToString();
                        this.result.Text = (firstArgument / secondArgument).ToString();
                        break;
                    default:
                        break;
                }

                this.operationKeeper.InnerText = string.Empty;
            }
            catch (Exception)
            {
                this.result.Text = this.argumentKeeper.InnerText;
            }
        }
    }
}