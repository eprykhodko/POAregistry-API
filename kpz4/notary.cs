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
    
    public partial class notary
    {
        public notary()
        {
            this.poas = new HashSet<poa>();
            this.poas1 = new HashSet<poa>();
            this.suspentions = new HashSet<suspention>();
        }
    
        public int idNotary { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Region { get; set; }

        [JsonIgnore]    
        public virtual ICollection<poa> poas { get; set; }
        [JsonIgnore]
        public virtual ICollection<poa> poas1 { get; set; }

        [JsonIgnore]
        public virtual ICollection<suspention> suspentions { get; set; }
    }
}
