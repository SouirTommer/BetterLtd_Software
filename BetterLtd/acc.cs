//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterLtd
{
    using System;
    using System.Collections.Generic;
    
    public partial class acc
    {
        public int accid { get; set; }
        public string Pwd { get; set; }
        public int isValid { get; set; }
        public System.DateTime RegDate { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
