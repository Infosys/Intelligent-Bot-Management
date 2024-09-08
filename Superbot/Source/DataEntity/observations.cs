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
    
    public partial class observations
    {
        public int ObservationId { get; set; }
        public int PlatformId { get; set; }
        public string ResourceId { get; set; }
        public int ResourceTypeId { get; set; }
        public int ObservableId { get; set; }
        public string ObservableName { get; set; }
        public string ObservationStatus { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> ObservationTime { get; set; }
        public string SourceIp { get; set; }
        public string Description { get; set; }
        public Nullable<int> RemediationPlanExecId { get; set; }
        public string RemediationStatus { get; set; }
        public string EventType { get; set; }
        public string Source { get; set; }
        public string State { get; set; }
        public string IsNotified { get; set; }
        public Nullable<System.DateTime> NotifiedTime { get; set; }
        public int TenantId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string PortfolioId { get; set; }
        public string ConfigId { get; set; }
        public Nullable<int> ObservationSequence { get; set; }
        public string IncidentId { get; set; }
        public string Application { get; set; }
        public string TransactionId { get; set; }
    }
}
