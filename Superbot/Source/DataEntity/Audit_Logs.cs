//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infosys.Solutions.Superbot.Resource.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Audit_Logs
    {
        public int LogID { get; set; }
        public Nullable<int> AnomalyId { get; set; }
        public string ResourceID { get; set; }
        public int ObservableID { get; set; }
        public int ActionID { get; set; }
        public string ActionParameters { get; set; }
        public Nullable<System.DateTime> LogDate { get; set; }
        public string Status { get; set; }
        public string Output { get; set; }
        public int PlatformID { get; set; }
        public int TenantID { get; set; }
        public string TransactionId { get; set; }
        public string PortfolioId { get; set; }
        public string IncidentId { get; set; }
    
        public virtual action action { get; set; }
        public virtual observable observable { get; set; }
        public virtual resource resource { get; set; }
    }
}
