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
    
    public partial class stp_Event_GetEventTypes_Result
    {
        public long EventTypeID { get; set; }
        public int fk_EventCategoryID { get; set; }
        public int fk_ImportanceLevelID { get; set; }
        public string EventTypeNameEng { get; set; }
        public string EventTypeNameRus { get; set; }
        public string EventTypeComment { get; set; }
    }
}