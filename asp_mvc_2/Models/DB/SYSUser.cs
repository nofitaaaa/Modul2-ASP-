//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asp_mvc_2.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUser
    {
        public SYSUser()
        {
            this.SYSUserRole = new HashSet<SYSUserRole>();
        }
    
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordEncryptedText { get; set; }
        public int RowCreatedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowMOdifiedDateTime { get; set; }
    
        public virtual ICollection<SYSUserRole> SYSUserRole { get; set; }
    }
}
