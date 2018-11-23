using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NavySampleSite.Engine;

namespace NavySampleSite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextMaker tm = new TextMaker();
            LnkApplicationName.InnerHtml = tm.SiteName;
        }
    }
} 