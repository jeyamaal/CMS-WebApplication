//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessControlManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisement
    {
        public int post_id { get; set; }
        public System.DateTime post_date { get; set; }
        public int user_id { get; set; }
        public string ad_name { get; set; }
        public Nullable<System.DateTime> expire_date { get; set; }
    
        public virtual Post Post { get; set; }
    }
}
