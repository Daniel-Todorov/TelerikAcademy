//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01._03.WorldWideInfo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Town
    {
        public int id { get; set; }
        public string name { get; set; }
        public int population { get; set; }
        public int countryId { get; set; }
    
        public virtual Country Country { get; set; }
    }
}
