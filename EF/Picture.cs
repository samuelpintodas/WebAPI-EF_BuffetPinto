//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        public int IdPicture { get; set; }
        public string Url { get; set; }
        public int IdRoom { get; set; }
    
        public virtual Room Room { get; set; }
    }
}
