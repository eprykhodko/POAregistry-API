//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kpz4
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class subject
    {
        public subject()
        {
            this.poas = new HashSet<poa>();
        }
    
        public int idSubject { get; set; }
        public int Type { get; set; }
        public Nullable<int> SerId { get; set; }
        public Nullable<int> RegId { get; set; }
        public string Info { get; set; }

        [JsonIgnore]    
        public virtual ICollection<poa> poas { get; set; }
    }
}