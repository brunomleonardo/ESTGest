//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESTGest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserPresenceList
    {
        public int upl_id { get; set; }
        public int upl_user_id { get; set; }
        public int upl_presence_id { get; set; }
    
        public virtual Presence Presence { get; set; }
        public virtual User User { get; set; }
    }
}