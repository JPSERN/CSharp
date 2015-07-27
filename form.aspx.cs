using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class FormTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Debug.WriteLine("aaa");
    }

    protected void Button1_OnClick(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text) == false)
        {
            Label1.Text = TextBox1.Text;
            Debug.WriteLine("Button1 clicked.");
        }
    }

    protected void Button2_OnClick(object sender, EventArgs e)
    {
        Label2.Text = CheckBoxList1.SelectedItem.Text;
    }

}