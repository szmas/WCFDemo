﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.WCFHost_WAS;

namespace WCFClient
{
    public partial class Test_WCFWAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ProductClient client = new ProductClient();

            lblMsg.Text = client.GetProduct(txtName.Text);

        }
    }
}