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
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.CourseClasses = new HashSet<CourseClass>();
            this.ScheduleContents = new HashSet<ScheduleContent>();
        }
    
        public int sch_id { get; set; }
        public string sch_designation { get; set; }
    
        public virtual ICollection<CourseClass> CourseClasses { get; set; }
        public virtual ICollection<ScheduleContent> ScheduleContents { get; set; }
    }
}