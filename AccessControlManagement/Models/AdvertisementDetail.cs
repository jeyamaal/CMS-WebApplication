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
    
    public partial class AdvertisementDetail
    {
        public int ADD_id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> wantToPostDate { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> postedDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
        public Nullable<System.DateTime> dueDate { get; set; }
        public Nullable<int> category_id { get; set; }
        public string adImage { get; set; }
    
        public virtual Category Category1 { get; set; }
    }
}
