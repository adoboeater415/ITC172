using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] calEvent = new string[5, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        calEvent[0, 0] = "Wedding Anniversary";
        calEvent[0, 1] = "4/28/2017";
        calEvent[1, 0] = "Mom's 7th Year Death Anniversay";
        calEvent[1, 1] = "7/31/2017";
        calEvent[2, 0] = "My Bday";
        calEvent[2, 1] = "10/10/2017";
        calEvent[3, 0] = "Kristine's Bday";
        calEvent[3, 1] = "11/08/2017";
        calEvent[4, 0] = "Random";
        calEvent[4, 1] = "11/14/2017";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetEvents();
    }

    private void GetEvents()
    {
        Label1.Text = "";
        if (Calendar1.SelectedDate > DateTime.MinValue)
        {
            string calendarDateTime = Calendar1.SelectedDate.ToShortDateString();
            for (int i = 0; i < calEvent.GetLength(0); i++)
            {
                if (calEvent[i, 1].Equals(calendarDateTime))
                {
                    Label1.Text += calEvent[i, 0] + "<br />";
                }
            }
        }
        if (Label1.Text.Length == 0)
        {
            Label1.Text = "No events found.";
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        //GetEvents();
        // debug for array length
        //Label1.Text = "Total length: " + calEvent.Length + "<br />Dimension 0: " + calEvent.GetLength(0) + "<br />Dimension 1: " + calEvent.GetLength(1);
    }
}