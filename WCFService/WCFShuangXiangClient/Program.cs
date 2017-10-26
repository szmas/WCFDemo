using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFShuangXiangClient.WCFService;

namespace WCFShuangXiangClient
{

    /// <summary>
    /// 实现服务端的回调接口
    /// 1.它可以在处理完请求之后，通过请求客户端中的回调进行响应操作
    /// 2.消息交换过程中，服务端和客户端角色会发生调换
    /// 3.服务端处理完请求后，返回给客户端的不是reply，而是callback请求。
    /// 4.Duplex模式对Bindding有特殊的要求，它要求支持Duplex MEP(Message Exchange Pattern),如WSDualHttpBinding和NetTcpBinding
    /// </summary>
    public class CallbackHandler : IProductTwoWayCallback
    {
        public void PrintSomething(string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        /*
         
          注意：在WCF预定义绑定类型中，WSDualHttpBinding和NetTcpBinding均提供了对双工通信的支持，
          但是两者在对双工通信的实现机制上却有本质的区别。WSDualHttpBinding是基于HTTP传输协议的；
          而HTTP协议本身是基于请求-回复的传输协议，基于HTTP的通道本质上都是单向的。
          WSDualHttpBinding实际上创建了两个通道，一个用于客户端向服务端的通信，
          而另一个则用于服务端到客户端的通信，从而间接地提供了双工通信的实现。
          而NetTcpBinding完全基于支持双工通信的TCP协议。


         
         */

        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CallbackHandler());


            ProductTwoWayClient client = new ProductTwoWayClient(instanceContext);

            Console.WriteLine(DateTime.Now);
            string result = client.GetProduct("李林峰");

            Console.WriteLine(result);
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
