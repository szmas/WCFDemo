using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF.Demo.Client
{
    public partial class Remove : System.Web.UI.Page
    {
        RemoveClient client = new RemoveClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Request.QueryString["UserID"]);

            bool result = client.DoWork(userid);

            if (result)
            {
                Response.Write("删除成功！<a href='list.aspx'>返回列表</a><br/>");
            }
            else
            {
                Response.Write("删除成功！<a href='list.aspx'>返回列表</a><br/>");
            }
        }
    }
}