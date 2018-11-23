using NavySampleSite.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavySampleSite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string SecretCode
        { 
            get 
            {
                TextMaker tm = new TextMaker();
                return tm.SecretCode;
            }
        }
    }
}