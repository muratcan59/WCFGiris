using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class ProductDT
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int? CategoryId { get; set; }
        [DataMember]
        public int? BrandId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public double Tax { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public double Discount { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
        [DataMember]
        public DateTime? CreateDate { get; set; }
        [DataMember]
        public DateTime? UpdateDate { get; set; }
        [DataMember]
        public DateTime? DeleteDate { get; set; }
        [DataMember]
        public bool IsDelete { get; set; }
    }
}