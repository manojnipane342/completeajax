//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        public tblCustomer()
        {
            this.tblSales = new HashSet<tblSale>();
        }
    
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Stat { get; set; }
        public string Zip { get; set; }
    
        public virtual ICollection<tblSale> tblSales { get; set; }
    }
}
