using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IUser”。
    /// <summary>
    /// ServiceContract 来说明接口是一个WCF的接口，如果不加的话，将不能被外部调用。
    /// </summary>
    [ServiceContract]
    public interface IUser
    {
        [OperationContract]
        void DoWork();

        /// <summary>
        /// OperationContract 来说明该方法是一个WCF接口的方法，不加的话同上。 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [OperationContract]
        string ShowName(string name);
    }
}
