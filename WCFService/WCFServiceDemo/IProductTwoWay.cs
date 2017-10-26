using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceDemo
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IProductCallback”。
    [ServiceContract(CallbackContract = typeof(IProductTwoWayCallback))]
    public interface IProductTwoWay
    {
        [OperationContract]
        string GetProduct(string name);
    }

    //回调的接口 
    public interface IProductTwoWayCallback
    {
        [OperationContract(IsOneWay = true)]
        void PrintSomething(string str);
    }

}
