//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infosys.Solutions.ConfigurationManager.Resource.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class healthcheck_iteration_tracker
    {
        public int TrackingId { get; set; }
        public int PlatformId { get; set; }
        public Nullable<int> PlatformModelVersion { get; set; }
        public string HealthcheckSource { get; set; }
        public string IpAddress { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Error { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public int TenantId { get; set; }
    }
}
