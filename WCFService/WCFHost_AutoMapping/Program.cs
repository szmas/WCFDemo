using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFHost_AutoMapping
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ServiceHost host=new ServiceHost (typeof(Product)))
            {
                host.Open();

                Console.WriteLine("WCF中的HTTP监听已启动...");
                Console.WriteLine("按回车键结束HTTP监听...");

                Console.ReadLine();
                host.Close();
            }
        }
    }
}
