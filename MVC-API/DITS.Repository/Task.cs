//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DITS.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            this.TaskActivities = new HashSet<TaskActivity>();
            this.TaskAssignments = new HashSet<TaskAssignment>();
            this.DocumentRelations = new HashSet<DocumentRelation>();
        }
    
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> ScheduleStartDateTime { get; set; }
        public Nullable<System.DateTime> ScheduleEndDateTime { get; set; }
        public int AssignedBy { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int PercentageComplete { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<int> PredecessorTask { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool RecordDeleted { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskActivity> TaskActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentRelation> DocumentRelations { get; set; }
        public virtual User User { get; set; }
    }
}
