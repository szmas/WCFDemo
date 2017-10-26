using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.WCFHost_Console;

namespace WCFClient
{
    public partial class Test_WCFConsole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            UserClient client = new UserClient();

            lblMsg.Text = client.ShowName(txtName.Text);
        }
    }
}