using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public DateTime AddTime { get; set; }
        [DataMember]
        public bool IsDel { set; get; }
        [DataMember]
        public decimal Price { get; set; }
    }
}