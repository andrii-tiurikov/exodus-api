//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exodus.Domain
{
    using System;
    
    public partial class stp_GetTokenAction_Result
    {
        public long ID { get; set; }
        public string Token { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public string Action { get; set; }
        public Nullable<long> UserID { get; set; }
    }
}