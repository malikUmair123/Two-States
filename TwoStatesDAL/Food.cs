//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwoStatesDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        public int F_ID { get; set; }
        public Nullable<bool> SeaFood { get; set; }
        public Nullable<bool> South_Indian_Food { get; set; }
        public Nullable<bool> North_Indian_Food { get; set; }
        public Nullable<bool> Multicuisine { get; set; }
        public Nullable<int> F_Cities { get; set; }
    
        public virtual city city { get; set; }
    }
}
