using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] tipPercent = { "Ten Percent", "Fifteen Percetn", "Twenty Percent", "Other" };
            TipPercentsRadioButtonList.DataSource = tipPercent;
            TipPercentsRadioButtonList.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        //getting the value of tip
        Tip tip = new Tip();
        //looping through texbox value and gives out an error if done wrong
        tip.MealAmount = double.Parse(MealTheBox.Text);
        if(OtherTextBox.Text=="")
        {
            //the looping starts here 
            foreach(ListItem item in TipPercentsRadioButtonList.Items)
            {
              
                if (item.Selected == true)
                {
                    if (item.Text.Equals("Ten Percent"))
                    {
                        tip.TipPercent = .1;
                    }
                    else if (item.Text.Equals("Fifteen Percetn"))
                    {
                        tip.TipPercent = .15;
                    }
                    else if (item.Text.Equals("Twenty Percent"))
                    {
                        tip.TipPercent = .2;
                    }
                }//end if selected
            }//end foreach
        }//end outer if
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }

        ResultLabel.Text = "Amount: " + tip.MealAmount.ToString() + "<br/>" +
            "Tip: " + tip.CalculateTip().ToString("$#,##0.00") + "<br/>" +
            "Tax: " + tip.CalculateTax().ToString("$#,##0.00") + "<br/>" +
            "Total: " + tip.CalculateTotal().ToString("$#,##0.00");
    }
}