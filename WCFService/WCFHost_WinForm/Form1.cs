using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFServiceLibrary;

namespace WCFHost_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost host;
        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            
            在这个例子中与Console应用程序不同的是，我们在Console配置是直接写在程序中的，而在本例中我们应用的是配置文件，
            区别在于如果写在配置文件中程序运行时直接到配置文件里取出相关的配置节去创建ServiceHost类。
            
           */


            host = new ServiceHost(typeof(User));

            host.Open();

            lblMsg.Text = "WCF中的HTTP监听已启动....";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            host.Close();
        }
    }
}
