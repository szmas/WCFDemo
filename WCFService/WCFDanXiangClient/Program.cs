using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDanXiangClient.WCFService;

namespace WCFDanXiangClient
{

    /// <summary>
    /// 在这种交换模式中，存在着如下的特征：
    /// 只有客户端发起请求，服务端并不会对请求进行回复
    /// 不能包含ref或者out类型的参数
    /// 没有返回值，返回类型只能为void
    /// 通过设置OperationContract的IsOneWay=True可以将满足要求的方法设置为这种消息交换模式
    /// 只有请求消息，没有返回的消息，说明服务器并没有对此作出任何反应。
    ///<summary></summary>
    class Program
    {
        static void Main(string[] args)
        {
            //我们发现前后两次的时间相同，虽然服务器方法的时间进程暂停了10s，但客户端的表现出的只是单向的，
            //并没有等待服务器的时间，也就是服务器并没有像客户端发送响应的消息。

            ProductClient client = new ProductClient();
            Console.WriteLine(DateTime.Now);


            //调用WCF服务的方法
            client.DoWork();
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
