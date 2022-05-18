using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VSforWEB_ex_4
{
    public partial class Kalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Datum.Text = Convert.ToString(Calendar1.SelectedDate.ToLongDateString());
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}