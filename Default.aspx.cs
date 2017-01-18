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
        if(!IsPostBack)
        {
            string[] tipPercent = { "Ten Percent", "Fifteen Percent", "Twenty Percent", "Other" };
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
        Class1 tip = new Class1();
        tip.MealAmount = double.Parse(MealTextBox.Text);
        if(OtherTextBox.Text=="")
        {
            foreach(ListItem item in TipPercentsRadioButtonList.Items)
            {
                tip.TipPercent = 0;
                if (item.Selected)
                {
                    if(item.Text.Equals("Ten Percent"))
                    {
                        tip.TipPercent = .1;
                    }
                    else if(item.Text.Equals("Fifteen Percent"))
                    {
                        tip.TipPercent = .15;
                    }
                    else if (item.Text.Equals("Twenty Percent"))
                    {
                        tip.TipPercent = .2;
                    }
                    else
                    {
                        tip.TipPercent = 0;
                    }
                }//end selected if
            }//end foreach
        }//end outer if
        else
        {
            tip.TipPercent = double.Parse(OtherTextBox.Text);
        }
        ResultLabel.Text = "Amount:" + tip.MealAmount.ToString("$#,##0.00") + "<br/>" +
            "Tip:" + tip.CalculateTip().ToString("$#,##0.00") + "<br/>" +
            "Tax:" + tip.CalculateTax().ToString("$#,##0.00") + "<br/>" +
            "Total:" + tip.CalculateTotal().ToString("$#,##0.00");
    }
}