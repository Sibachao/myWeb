//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductImage
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Link { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
