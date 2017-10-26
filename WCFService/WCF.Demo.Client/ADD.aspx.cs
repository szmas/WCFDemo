using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCF.Demo.Model;

namespace WCF.Demo.Client
{
    public partial class ADD : System.Web.UI.Page
    {
        AddClient addClient = new AddClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = this.txtUserName.Text;
            user.Password = this.txtPassword.Text;
            user.Discribe = this.txtDiscribe.Text;
            user.SubmitTime = System.DateTime.Now;
            addClient.DoWork(user);
            Response.Write("添加成功！<a href='list.aspx'>返回列表</a><br/>");
        }
    }
}