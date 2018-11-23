using NavySampleSite.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavySampleSite
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextMaker tm = new TextMaker();
            hdDescription.InnerText = tm.SiteDescription;
        }
    }
}