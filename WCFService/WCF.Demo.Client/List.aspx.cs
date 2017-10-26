using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF.Demo.Client
{
    public partial class List : System.Web.UI.Page
    {
        SearchClient client = new SearchClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            repUsers.DataSource = client.DoWork();
            repUsers.DataBind();
        }
    }
}