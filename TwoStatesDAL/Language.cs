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
    
    public partial class Language
    {
        public int L_ID { get; set; }
        public string Language_Name { get; set; }
        public Nullable<int> L_Cities { get; set; }
        public Nullable<int> L_user { get; set; }
    
        public virtual city city { get; set; }
        public virtual User_Details User_Details { get; set; }
    }
}
