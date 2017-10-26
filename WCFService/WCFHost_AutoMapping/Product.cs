﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHost_AutoMapping
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Product”。
    public class Product : IProduct
    {
        public void DoWork()
        {
        }


        public string GetProductName(string name)
        {
            return string.Format("WCF服务，产品名称：{0}", name);
        }
    }
}
