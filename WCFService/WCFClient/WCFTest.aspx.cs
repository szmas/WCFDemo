using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.WCFService;

namespace WCFClient
{
    public partial class WCFTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            //　上面中的UserClient类是在添加引用的时候生成的服务端User类的客户端代理类，
            //  一般客户端代理类名称都会是**Client。
            UserClient client = new UserClient();

            lblMsg.Text = client.ShowName(txtName.Text);
        }
    }
}