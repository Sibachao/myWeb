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
    
    public partial class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}