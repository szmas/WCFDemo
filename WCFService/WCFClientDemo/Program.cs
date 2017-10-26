using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFClientDemo.WCFService;

namespace WCFClientDemo
{

    /// <summary>
    /// 调用服务方法后需要等待服务的消息返回，即便该方法返回 void 类型
    /// 相比Duplex来讲，这种模式强调的是客户端的被动接受，也就是说客户端接受到响应后，消息交换就结束了。
    /// 在这种模式下，服务端永远是服务端，客户端就是客户端，职责分明。
    /// 它是缺省的消息交换模式，设置OperationContract便可以设置为此种消息交换模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //我们可以看到服务器响应的时间刚好为10s,正好是线程休眠的时间，并且客户端返回了信息

            ProductClient client = new ProductClient();

            Console.WriteLine(DateTime.Now);
            string result = client.GetProduct("李林峰");

            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
