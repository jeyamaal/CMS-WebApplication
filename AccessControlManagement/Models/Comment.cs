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
    
    public partial class Comment
    {
        public int comment_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> post_id { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> comment_date { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual user user { get; set; }
    }
}
