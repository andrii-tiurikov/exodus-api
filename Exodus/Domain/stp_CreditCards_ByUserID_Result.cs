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
    
    public partial class stp_CreditCards_ByUserID_Result
    {
        public long CreditCardID { get; set; }
        public long UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public long CreditCardTypeID { get; set; }
        public string CreditCardTypeName { get; set; }
        public long BankID { get; set; }
        public string BankName { get; set; }
        public string CardNumber { get; set; }
        public System.DateTime CardValidTill { get; set; }
        public string CardAdditionalInfo { get; set; }
    }
}