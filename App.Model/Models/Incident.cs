//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Incident
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string LocationId { get; set; }
        public Nullable<System.DateTime> HappenedAt { get; set; }
        public Nullable<bool> IsArchive { get; set; }
    }
}
