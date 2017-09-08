using System;
using System.Runtime.Serialization;

namespace HisPlus.Domain
{
    [Serializable]
    [DataContract]
    public class BsGfxeInfo : Entity<int>
    {
        [DataMember] 
        public virtual string Code { get; set; }
        [DataMember] 
        public virtual string Name { get; set; }
        [DataMember] 
        public virtual string PyCode { get; set; }
        [DataMember] 
        public virtual string WbCode { get; set; }
        [DataMember] 
        public virtual short OrderBy { get; set; }
        [DataMember] 
        public virtual bool IsActive { get; set; }
        [DataMember] 
        public virtual short IconIndex { get; set; }
    }
}
