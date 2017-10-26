using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.Demo.Model;

namespace WCF.Demo.Client
{
    public partial class Edit : System.Web.UI.Page
    {
        SaveClient saveClient = new SaveClient();
        GetClient getClient = new GetClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                int userid = Convert.ToInt32(Request.QueryString["UserID"]);
                User model = getClient.DoWork(userid);

                txtUserName.Text = model.UserName;
                txtDiscribe.Text = model.Discribe;
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Request.QueryString["UserID"]);

            User model = getClient.DoWork(userid);

            model.UserName = txtUserName.Text;
            model.Discribe = txtDiscribe.Text;

            bool result = saveClient.DoWork(model);

            if (result)
            {
                Response.Write("修改成功！<a href='list.aspx'>返回列表</a><br/>");
            }
            else
            {
                Response.Write("修改失败");
            }
        }
    }
}